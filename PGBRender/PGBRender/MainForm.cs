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
            RenderSegment oneSegment = new RenderSegment();
            oneSegment.BlendFile = txtBlendFile.Text;
            oneSegment.StartFrame = 0;
            oneSegment.EndFrame = (int)nudFrameCount.Value;
            oneSegment.OutputDirectory = "D:\\Editing";
            oneSegment.Render();
        }
    }
}
