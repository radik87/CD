using CD.Constans;
using CD.Service;
using CD.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
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
        private Task ProgresData(List<string> list, IProgress<ProgressReport> progress)
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
                    Thread.Sleep(10);
                }
            });
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

            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }

            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                PersentLb.Text = string.Format("{0} %", report.PercentCompelete);
                ProgressBarC.Value = report.PercentCompelete;
                ProgressBarC.Update();
            };

            await ProgresData(list, progress);

            try
            {

                string parent = Path.GetFullPath(Path.Combine(Folder.Current, @"..\"));

                bool exists = Directory.Exists(string.Concat(parent, Folder.CD_Out));

                if (!exists)
                {
                    Directory.CreateDirectory(string.Concat(parent, Folder.CD_Out));
                }

                var files = FileReaderWriter.GetFile(Folder.Current, "*.txt");

                int[] arrValues = new FileReaderWriter().Read(files[0]);

                average = new Alghoritm().AverageByBlockSize(Convert.ToInt32(BlockSizeTxtBox.Text), arrValues);
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

        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}