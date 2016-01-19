using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace PGBRender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            nudCoreCount.Maximum = Environment.ProcessorCount;
        }

        private void txtBlendFile_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "Blender Project File (*.blend)|*.blend";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBlendFile.Text = dlg.FileName;
            }
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            RenderJob job = new RenderJob();
            job.BlendFile = txtBlendFile.Text;
            job.CoreCount = (int)nudCoreCount.Value;
            job.StartFrame = (int)nudFrameStart.Value;
            job.EndFrame = (int)nudFrameEnd.Value;
            job.OutputDirectory = @"D:\Editing\Renders";
            job.TempDirectory = @"D:\Editing\Renders\Temp";
            job.Run();
        }

        private void nudFrameStart_ValueChanged(object sender, EventArgs e)
        {
            nudFrameEnd.Minimum = nudFrameStart.Value + 1;
        }

        private void txtBlendFile_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtBlendFile.Text) && txtBlendFile.Text.EndsWith(".blend"))
            {
                string args = string.Format(@"-b ""{0}"" -P ""{1}""", txtBlendFile.Text, "blendinfo.py");
                ProcessStartInfo blenderArgs = new ProcessStartInfo(@"C:\Program Files\Blender Foundation\Blender\blender.exe", args);
                blenderArgs.CreateNoWindow = true;
                blenderArgs.RedirectStandardOutput = true;
                blenderArgs.UseShellExecute = false;
                Process blender = new Process();
                blender.StartInfo = blenderArgs;
                blender.Start();
                string output = blender.StandardOutput.ReadToEnd();
                if (output.Contains("frame set: "))
                {
                    int start = output.IndexOf("frame set: ");
                    string info = output.Substring(start, output.IndexOf("\n", start) - start - 1);
                    string startFrame = info.Substring(info.IndexOf("set: ") + 5, info.IndexOf(" to ") - (info.IndexOf("set: ") + 5));
                    string stopFrame = info.Substring(info.IndexOf(" to ") + 4, info.IndexOf(" for a ") - (info.IndexOf(" to ") + 4));
                    nudFrameStart.Value = int.Parse(startFrame);
                    nudFrameEnd.Value = int.Parse(stopFrame);
                }
            }
        }
    }
}
