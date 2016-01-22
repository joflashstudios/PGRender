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
    public partial class ConfigForm : Form
    {
        Configuration Config { get; set; }

        public ConfigForm(Configuration config)
        {
            Config = config;
            InitializeComponent();

            txtBlender.Text = config.BlenderPath;
            txtFFMPEG.Text = config.FFMPEGPath;
            txtOutput.Text = config.OutputPath;
            txtTemp.Text = config.TempPath;
        }

        public static Configuration ShowConfig(Configuration previous)
        {            
            ConfigForm form = new ConfigForm((Configuration)previous.Clone());
            form.ShowDialog();
            return form.Config;
        }

        private void txtBlender_TextChanged(object sender, EventArgs e)
        {
            Config.BlenderPath = txtBlender.Text;
        }

        private void txtFFMPEG_TextChanged(object sender, EventArgs e)
        {
            Config.FFMPEGPath = txtFFMPEG.Text;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            Config.OutputPath = txtOutput.Text;
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {
            Config.TempPath = txtTemp.Text;
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
