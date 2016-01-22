using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBRender
{
    class JobManager
    {
        public JobManager(Configuration config)
        {
            HistoricFPS = new double[config.ProgressMemory];
            Resolution = config.ProgressResolution;
            Job = new RenderJob();
            Job.OutputDirectory = config.OutputPath;
            Job.TempDirectory = config.TempPath;
        }

        public bool Running;
        public RenderJob Job;
        public DateTime LastPoll = DateTime.Now;
        public double[] HistoricFPS;
        public int HistoricFPSIndex = 0;
        public int LastFramesCompleted = 0;
        public int Resolution;
        public int UpdateCount = 1;
        public object UpdateLock = new object();        
    }
}
