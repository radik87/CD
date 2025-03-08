using CD.Constans;
using CD.Constants_Models;
using CD.Service;
using CD.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            double average = default;

            FileReaderWriter fileReaderWriter = new FileReaderWriter();
            Progress<ProgressReport> progress = new Progress<ProgressReport>();

            Stopwatch readingTime = new Stopwatch();
            Stopwatch algTime = new Stopwatch();

            try
            {
                Folder.ParentFormCurrent = Path.GetFullPath(Path.Combine(Folder.Current, @"..\"));
                Folder.CD_Out = string.Concat(Folder.ParentFormCurrent, "CD-out");

                List<string> filesNames = FileReaderWriter.GetFile(Folder.Current, "*.txt").ToList();

                foreach (string filename in filesNames)
                {
                    readingTime.Start();
                    int[] arrValues = fileReaderWriter.Read(filename);
                    readingTime.Stop();
                    TotalTime.Reading += readingTime.Elapsed;

                    algTime.Start();
                    average = new Alghoritm().AverageByBlockSize(Convert.ToInt32(BlockSizeTxtBox.Text), arrValues);
                    algTime.Stop();
                    TotalTime.Alghoritm += algTime.Elapsed;
                }

                if (WithoutCdOutCheckB.Checked)
                {
                    if (Directory.Exists(Folder.CD_Out))
                    {
                        Array.ForEach(Directory.GetFiles(Folder.CD_Out), File.Delete);
                        Directory.Delete(Folder.CD_Out);
                    }
                }
                else
                {
                    Directory.CreateDirectory(Folder.CD_Out);

                    fileReaderWriter.Write(average, Folder.CD_Out);
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
                MessageBox.Show("STATISTICA SUKA");
            }

            else
            {
                MessageBox.Show("Calculation completed");
            }

            InfoLb.Text = average.ToString();

            ReadingTimeLb.Text = string.Concat(nameof(TotalTime.Reading )+ ": ", TotalTime.Reading.ToString(TotalTime.Format));
            AlgTimeLb.Text = string.Concat(nameof(TotalTime.Alghoritm) + ": ", TotalTime.Alghoritm.ToString(TotalTime.Format));
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}