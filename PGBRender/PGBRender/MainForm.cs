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

        private void button1_Click(object sender, EventArgs e)
        {
            int remainder = ((int)nudFrameCount.Value + 1) % ((int)nudCoreCount.Value);
            int framesPerWorker = ((int)nudFrameCount.Value) / ((int)nudCoreCount.Value);
            int currentStartFrame = 0;

            for (int core = 0; core < nudCoreCount.Value; core++)
            {
                RenderSegment segment = new RenderSegment();
                segment.BlendFile = txtBlendFile.Text;
                segment.StartFrame = currentStartFrame;
                segment.EndFrame = currentStartFrame + framesPerWorker - 1;
                if (core == nudCoreCount.Value - 1)
                    segment.EndFrame += remainder;
                currentStartFrame = currentStartFrame + framesPerWorker;
                segment.OutputDirectory = "D:\\Editing";
                segment.Render();
            }
        }
    }
}
