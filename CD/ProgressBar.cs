using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace CD
{
    public class ProgressBar
    {
        public Task ProgresData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProgress = list.Count;
            ProgressReport progressReport = new ProgressReport();

            return Task.Run(() =>
            {
                for (int i = 0; i < totalProgress; i++)
                {
                    progressReport.PercentCompelete = index++ * 100 / totalProgress;
                    progress.Report(progressReport);
                }
            });
        }
    }
}
