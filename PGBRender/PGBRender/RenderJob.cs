using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace PGBRender
{
    class RenderJob
    {
        private RenderSegment[] Segments;
        private Guid JobID;
        private string WorkDirectory { get { return Path.Combine(TempDirectory, JobID.ToString("D")); } }

        public string BlendFile { get; set; }
        public int CoreCount { get; set; }
        public int StartFrame { get; set; }
        public int EndFrame { get; set; }
        public string TempDirectory { get; set; }
        public string OutputDirectory { get; set; }
        public ProcessComplete OnJobComplete;

        public ProcessState State { get { return _State; } }
        private ProcessState _State { get; set; }

        private string Extension;

        public RenderJob()
        {
            _State = ProcessState.Prestart;
        }

        private void OnSegmentComplete()
        {
            if (Segments.All(n => n.State == ProcessState.Complete))
            {
                FFMPEGCombine();
                CleanUp();

                if (OnJobComplete != null)
                    OnJobComplete();
            }                
        }

        private void OnFrameRendered(RenderSegment segment)
        {

        }

        private void CleanUp()
        {
            Directory.Delete(WorkDirectory, true);
        }

        private void SetUp()
        {
            JobID = Guid.NewGuid();
            Directory.CreateDirectory(WorkDirectory);
        }

        public void Run()
        {
            SetUp();
            StartSegments();
        }

        private void StartSegments()
        {
            Segments = new RenderSegment[CoreCount];
            int remainder = (EndFrame + 1 - StartFrame) % (CoreCount);
            int framesPerWorker = (EndFrame + 1 - StartFrame) / (CoreCount);
            int currentStartFrame = StartFrame;

            for (int core = 0; core < CoreCount; core++)
            {
                RenderSegment segment = new RenderSegment();
                segment.BlendFile = BlendFile;
                segment.StartFrame = currentStartFrame;
                segment.EndFrame = currentStartFrame + framesPerWorker - 1;
                segment.OutputDirectory = WorkDirectory;
                segment.OnComplete = new ProcessComplete(OnSegmentComplete);
                segment.OnFrameRendered = new FrameRendered(OnFrameRendered);

                if (core == CoreCount - 1)
                    segment.EndFrame += remainder;

                currentStartFrame = currentStartFrame + framesPerWorker;
                segment.Render();
                Segments[core] = segment;
            }
        }

        private void FFMPEGCombine()
        {
            string[] lines = new string[Segments.Length];
            for (int i = 0; i < Segments.Length; i++)
            {
                string path = Directory.GetFiles(WorkDirectory, Path.GetFileName(Segments[i].OutputPath) + "*")[0];
                lines[i] = "file '" + path + "'";
                Extension = Path.GetExtension(path); //This, I am ashamed of. Yes.
            }
            File.WriteAllLines(Path.Combine(WorkDirectory, "combine.txt"), lines);

            Process ffmpeg = new Process();
            ProcessStartInfo ffmpegArgs = new ProcessStartInfo(@"C:\Program Files\FFMPEG\bin\ffmpeg", BuildCommandLineArgs());
            SetProcessProperties(ffmpeg, ffmpegArgs);
            ffmpeg.Start();
            ffmpeg.StandardOutput.ReadToEnd();
        }

        private string BuildCommandLineArgs()
        {
            string list = Path.Combine(WorkDirectory, "combine.txt");
            string filename = Path.GetFileNameWithoutExtension(BlendFile) + " " + StartFrame + "-" + EndFrame + Extension;
            string destination = Path.Combine(OutputDirectory, filename);
            return string.Format(@"-f concat -i ""{0}"" -c copy ""{1}""", list, destination);
        }

        private static void SetProcessProperties(Process blenderRenderer, ProcessStartInfo blenderArgs)
        {
            blenderArgs.CreateNoWindow = true;
            blenderArgs.RedirectStandardOutput = true;
            blenderArgs.UseShellExecute = false;
            blenderRenderer.StartInfo = blenderArgs;
        }
    }
}
