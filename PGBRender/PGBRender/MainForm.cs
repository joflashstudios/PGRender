using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Diagnostics;

namespace PGBRender
{
    public partial class MainForm : Form
    {
        JobManager manager;
        Configuration _config;

        Configuration config
        {
            get
            {
                if (_config == null)
                {
                    if (File.Exists("config.xml"))
                    {
                        try
                        {
                            XmlSerializer ser = new XmlSerializer(typeof(Configuration));
                            using (StreamReader reader = new StreamReader("config.xml"))
                            {
                                _config = (Configuration)ser.Deserialize(reader);
                            }
                        }
                        catch
                        {
                            config = new Configuration();
                        }
                    }
                    else
                    {
                        _config = new Configuration();
                    }
                }
                return _config;
            }
            set
            {
                _config = value;
            }
        }

        private void SaveConfig()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Configuration));
            var loadedConfig = config;
            using (StreamWriter writer = new StreamWriter("config.xml"))
            {
                ser.Serialize(writer, loadedConfig);
            }
        }

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
            manager = new JobManager(config);

            manager.Job.BlendFile = txtBlendFile.Text;
            manager.Job.FFMPEGFile = config.FFMPEGPath;
            manager.Job.CoreCount = (int)nudCoreCount.Value;
            manager.Job.StartFrame = (int)nudFrameStart.Value;
            manager.Job.EndFrame = (int)nudFrameEnd.Value;

            manager.Job.OnJobProgress += new JobProgress(JobProgressed);
            manager.Job.OnJobComplete += new ProcessComplete(JobComplete);
            manager.Job.Run();

            PrepRunningPanel();
            ToggleRunning();
        }

        private void JobComplete()
        {
            this.Invoke(new Action(delegate () {
                progressBar.Value = 100;
                lblRunETA.Text = "Complete";
                btnCancel.Enabled = false;
                btnPause.Enabled = false;
                lblRunFPS.Text = "N/A";
                lblRunRealtime.Text = "N/A";
            }));
        }

        private void JobProgressed(RenderJob job)
        {
            lock (manager.UpdateLock)
            {
                if (manager.UpdateCount % manager.Resolution == 0 && job.State == ProcessState.Running)
                {
                    manager.UpdateCount = 1;
                    Action reportProgress = delegate () {
                        int totalFrames = job.TotalFrames;
                        int completedFrames = job.CompletedFrames;

                        TimeSpan elapsed = DateTime.Now - manager.LastPoll;
                        manager.LastPoll = DateTime.Now;

                        progressBar.Value = (int)(Math.Round((double)(100 * completedFrames) / (double)totalFrames));
                        Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance.SetProgressValue(progressBar.Value, 100);
                        double FPS = (completedFrames - manager.LastFramesCompleted) / elapsed.TotalSeconds;
                        manager.HistoricFPS[manager.HistoricFPSIndex] = FPS;
                        manager.HistoricFPSIndex++;
                        if (manager.HistoricFPSIndex == manager.HistoricFPS.Length)
                            manager.HistoricFPSIndex = 0;

                        double averageFPS = manager.HistoricFPS.Where(n => n != 0).Average();

                        if (averageFPS != 0)
                        {
                            lblRunFPS.Text = Math.Round(averageFPS, 1).ToString("0.0");
                            lblRunRealtime.Text = Math.Round((100 * averageFPS) / (double)nudFPS.Value, 1).ToString("0.0") + "%";

                            TimeSpan ETA = TimeSpan.FromSeconds((totalFrames - completedFrames) / averageFPS);
                            DateTime ETATime = DateTime.Now.Add(ETA);
                            lblRunETA.Text = ETA.ToString("hh'h 'mm'm 'ss's'") + " – " + ETATime.ToString("t");
                        }
                        manager.LastFramesCompleted = completedFrames;
                    };
                    this.Invoke(reportProgress);
                }
                else
                {
                    manager.UpdateCount++;
                }
            }
        }

        private void PrepRunningPanel()
        {
            lblRunProject.Text = "Rendering " + Path.GetFileName(txtBlendFile.Text);
            lblRunCores.Text = nudCoreCount.Value + " Cores";

            TimeSpan length = TimeSpan.FromSeconds((double)((nudFrameEnd.Value - nudFrameStart.Value) / nudFPS.Value));
            lblRunFrames.Text = "Frames " + nudFrameStart.Value + "–" + nudFrameEnd.Value + ", " + length.ToString("h'h 'm'm 's's'");
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
                ProcessStartInfo blenderArgs = new ProcessStartInfo(config.BlenderPath, args);
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

        private void ToggleRunning()
        {
            manager.Running = !manager.Running;
            panelRunning.Visible = manager.Running;
            panelSetup.Visible = !manager.Running;
            panelRunning.Dock = manager.Running ? DockStyle.Fill : DockStyle.None;
            panelSetup.Dock = manager.Running ? DockStyle.None : DockStyle.Fill;

            Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance.SetProgressState(manager.Running ? Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal : Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.NoProgress);          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            manager.Job.Cancel();

            lblRunETA.Text = "Cancelled";
            lblRunFPS.Text = "N/A";
            lblRunRealtime.Text = "N/A";

            btnCancel.Enabled = false;
            btnPause.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (manager != null && manager.Job.State == ProcessState.Running)
            {
                if (MessageBox.Show("Exiting now will cancel the render in progress.\n\nAre you sure you want to exit?", "Render in progress", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    manager.Job.Cancel();
                    SaveConfig();
                }
            }
            else
            {
                SaveConfig();
            }
        }

        private void lnkConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            config = ConfigForm.ShowConfig(config);
        }
    }
}