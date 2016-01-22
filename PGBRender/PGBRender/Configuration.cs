using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBRender
{
    public class Configuration : ICloneable
    {
        public Configuration()
        {
            ProgressResolution = 10;
            ProgressMemory = 30;
        }

        public string BlenderPath { get; set; }
        public string FFMPEGPath { get; set; }
        public string OutputPath { get; set; }
        public string TempPath { get; set; }

        public int ProgressResolution { get; set; }
        public int ProgressMemory { get; set; }

        public object Clone()
        {
            return new Configuration() { BlenderPath = this.BlenderPath, FFMPEGPath = this.FFMPEGPath, OutputPath = this.OutputPath, TempPath = this.TempPath,
                ProgressMemory = this.ProgressMemory, ProgressResolution = this.ProgressResolution };
        }
    }
}
