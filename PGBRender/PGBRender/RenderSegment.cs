using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Management;
using System.Threading;
using System.Diagnostics;

namespace PGBRender
{
    class RenderSegment
    {
        public ProcessComplete OnComplete;
        public FrameRendered OnFrameRendered;
        public ProcessState State { get { return _State; } }
        private ProcessState _State { get; set; }
        public string BlendFile { get; set; }
        public string OutputDirectory { get; set; }
        public int StartFrame { get; set; }
        public int EndFrame { get; set; }
        public Process BlenderRenderer { get { return _BlenderRenderer; } }
        private Process _BlenderRenderer;

        public int TotalFrames { get { return (EndFrame - StartFrame) + 1; } }
        public int CompletedFrames { get { return LastFrame - StartFrame; } }
        public int LastFrame { get { return _LastFrame; } }
        private int _LastFrame;

        public string OutputPath
        {
            get
            {
                string outputName = Path.GetFileNameWithoutExtension(BlendFile) + " Render";
                string outputFull = Path.Combine(OutputDirectory, outputName);
                return outputFull + " " + StartFrame + "-" + EndFrame;
            }
        }

        public RenderSegment()
        {
            _State = ProcessState.Prestart;
        }

        public void Render()
        {
            _LastFrame = StartFrame;
            ThreadStart start = new ThreadStart(RenderInternal);
            Thread sprinter = new Thread(start);
            sprinter.Start();
        }

        public void Cancel()
        {
            _State = ProcessState.Cancelled;
            KillProcessAndChildren(BlenderRenderer.Id);
        }

        private static void KillProcessAndChildren(int pid)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }

        private void RenderInternal()
        {
            _BlenderRenderer = new Process();
            ProcessStartInfo blenderArgs = new ProcessStartInfo(@"C:\Program Files\Blender Foundation\Blender\blender.exe", BuildCommandLineArgs());
            blenderArgs.CreateNoWindow = true;
            blenderArgs.RedirectStandardOutput = true;
            blenderArgs.UseShellExecute = false;
            BlenderRenderer.StartInfo = blenderArgs;
            BlenderRenderer.OutputDataReceived += BlenderRenderer_OutputDataReceived;
            BlenderRenderer.Start();
            BlenderRenderer.BeginOutputReadLine();
            _State = ProcessState.Running;
            BlenderRenderer.WaitForExit();

            if (State != ProcessState.Cancelled)
            {
                _State = ProcessState.Complete;

                if (OnComplete != null)
                    OnComplete();
            }
        }

        private void BlenderRenderer_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {            
            if (e.Data != null && e.Data.StartsWith("Append frame "))
            {
                _LastFrame = int.Parse(e.Data.Substring(13));
                OnFrameRendered(this);
            }
        }

        private string BuildCommandLineArgs()
        {
            string outputName = Path.GetFileNameWithoutExtension(BlendFile) + " Render #";
            string outputFull = Path.Combine(OutputDirectory, outputName);
            return string.Format(@"-b ""{0}"" -E BLENDER_RENDER -s {1} -e {2} -o ""{3}"" -a", BlendFile, StartFrame, EndFrame, outputFull);
        }
    }

    delegate void ProcessComplete();
    delegate void FrameRendered(RenderSegment sender);
    
    enum ProcessState
    {
        Prestart,
        Running,
        Complete,
        Cancelled
    }
}
