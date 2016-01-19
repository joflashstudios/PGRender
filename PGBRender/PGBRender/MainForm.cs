using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
