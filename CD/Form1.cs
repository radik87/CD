using CD.Constans;
using CD.Constants_Models;
using CD.Service;
using CD.Services;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD
{
    public partial class CD_Delta : Form
    {
        public CD_Delta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CdInFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Folder.Current = dialog.SelectedPath;
            }
        }

        private void DisplayPathBtn_Click(object sender, EventArgs e)
        {
            displayPathBtn.Text = Folder.Current;
        }

        private async void ExecuteBtn_Click(object sender, EventArgs e)
        {
            ErrorLb.Text = string.Empty;

            FileReaderWriter fileReaderWriter = new FileReaderWriter();
            Progress<ProgressReport> progress = new Progress<ProgressReport>();
            List<Task> tasks = new List<Task>();
            Folder folder = new Folder();
            List<Tuple<int, decimal>> deltaAverage = new List<Tuple<int, decimal>>();
            Stats stats = new Stats();
            
            try
            {
                folder.ParentFormCurrent = Path.GetFullPath(Path.Combine(Folder.Current, @"..\"));
                folder.CdOut = string.Concat(folder.ParentFormCurrent, "CD-out");

                List<string> filesNames = fileReaderWriter.GetFile(Folder.Current, "*.txt").ToList();

                foreach (string filename in filesNames)
                {
                    tasks.Add(Task.Run(() =>
                    {
                        int[] blockValues = fileReaderWriter.Read(filename);

                        deltaAverage = new Alghoritm().DeltaAverageByBlockSize(Convert.ToInt32(BlockSizeTxtBox.Text), blockValues);
                    }));
                }

                await Task.WhenAll(tasks);

                if (WithoutCdOutCheckBox.Checked)
                {
                    if (Directory.Exists(folder.CdOut))
                    {
                        Array.ForEach(Directory.GetFiles(folder.CdOut), File.Delete);
                        Directory.Delete(folder.CdOut);
                    }
                }
                else
                {
                    Directory.CreateDirectory(folder.CdOut);
                    //
                    fileReaderWriter.Write(deltaAverage, folder.CdOut);
                }

                progress.ProgressChanged += (o, report) =>
                {
                    PersentLb.Text = string.Format("{0} %", report.PercentCompelete);
                    ProgressBarC.Value = report.PercentCompelete;
                    ProgressBarC.Update();
                };

                await new ProgressBar().ProgresData(filesNames, progress);
            }

            catch (Exception ex)
            {
                ErrorLb.Text = ex.Message;
            }


            if (StatsCheckBox.Checked)
            {
                MessageBox.Show(
                    "Loaded :" + Environment.NewLine +
                     "Uploaded :" + Environment.NewLine +
                     "Delta: "
                    );
            }

            else
            {
                MessageBox.Show("Calculation completed");
            }

            //todo List<Tuple >.Clear();
            //InfoLb.Text = deltaAverage.ToString();

            ReadingTimeLb.Text = string.Concat(nameof(TotalTime.Reading) + ": ", TotalTime.Reading.ToString(TotalTime.Format));
            AlgTimeLb.Text = string.Concat(nameof(TotalTime.Alghoritm) + ": ", TotalTime.Alghoritm.ToString(TotalTime.Format));

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}