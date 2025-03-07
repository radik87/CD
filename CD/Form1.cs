using CD.Constans;
using CD.Service;
using CD.Services;
using System;
using System.IO;
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

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            double average = default;

            string parent = Path.GetFullPath(Path.Combine(Folder.Current, @"..\"));

            bool exists = Directory.Exists(string.Concat(parent, Folder.CD_Out));

            if (!exists)
            {
                Directory.CreateDirectory(string.Concat(parent, Folder.CD_Out));
            }

            var files = FileReaderWriter.GetFile(Folder.Current, "*.txt");

            int[] arrValues = new FileReaderWriter().Read(files[0]);

            try
            {
                average = new Alghoritm().AverageByBlockSize(Convert.ToInt32(BlockSizeTxtBox.Text), arrValues);
            }

            catch (Exception ex)
            {
                errorLb.Text = ex.Message;
            }

            errorLb.Text = average.ToString();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}