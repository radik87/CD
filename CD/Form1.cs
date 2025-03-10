using CD.Constans;
using CD.Constants_Models;
using CD.Service;
using CD.Services;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD
{
    public partial class CD_Delta : Form
    {
        private readonly FileReaderWriter _fileReaderWriter;
        private readonly Folder _folder;
        private readonly Alghoritm _alghoritm;
        public CD_Delta(FileReaderWriter fileReaderWriter, Folder folder, Alghoritm alghoritm)
        {
            InitializeComponent();
            _fileReaderWriter = fileReaderWriter;
            _folder = folder;
            _alghoritm = alghoritm;
        }

        int[] blockValues = new int[] { };

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

            Progress<ProgressReport> progress = new Progress<ProgressReport>();
            List<Task> tasks = new List<Task>();
            int indexDelta = 0;
            decimal averageBits = 0;
            Stats stats = new Stats();

            try
            {
                _folder.ParentFormCurrent = Path.GetFullPath(Path.Combine(Folder.Current, @"..\"));
                _folder.CdOut = string.Concat(_folder.ParentFormCurrent, "CD-out");

                List<string> filesNames = _fileReaderWriter.GetFile(Folder.Current, "*.txt").ToList();
                int blockSize = int.TryParse(BlockSizeTxtBox.Text, out blockSize) ? blockSize : 0;

                foreach (string filename in filesNames)
                {
                    tasks.Add(Task.Run(() =>
                    {
                        blockValues = _fileReaderWriter.Read(filename);

                        (indexDelta, averageBits) = _alghoritm.DeltaAverageByBlockSize(blockSize, blockValues);
                    }));
                }

                await Task.WhenAll(tasks);

                stats.Delta = indexDelta;
                stats.Average = averageBits;

                if (WithoutCdOutCheckBox.Checked)
                {
                    if (Directory.Exists(_folder.CdOut))
                    {
                        Array.ForEach(Directory.GetFiles(_folder.CdOut), File.Delete);
                        Directory.Delete(_folder.CdOut);
                    }
                }
                else
                {
                    Directory.CreateDirectory(_folder.CdOut);

                    _fileReaderWriter.Write(stats, blockValues, _folder.CdOut);
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
                    $"Delta: {stats.Delta}" + Environment.NewLine +
                    $"Average: {stats.Average}" + Environment.NewLine +
                    $"Data: [0-{stats.Delta - 1}] indexes from Cd-in file has minimal average bits"
                    );
            }
            else
            {
                MessageBox.Show("Calculation completed");
            }

            ReadingTimeLb.Text = string.Concat(nameof(TotalTime.Reading) + ": ", TotalTime.Reading.ToString(TotalTime.Format));
            AlgTimeLb.Text = string.Concat(nameof(TotalTime.Alghoritm) + ": ", TotalTime.Alghoritm.ToString(TotalTime.Format));
        }

        private void CancelBtn_Click()
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}