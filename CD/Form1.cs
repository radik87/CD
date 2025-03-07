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
            FileReaderWriter fileReaderWriter = new FileReaderWriter();
            Alghoritm alghoritm = new Alghoritm();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Folder.Current = dialog.SelectedPath;
            }

            var files = Directory.GetFiles(Folder.Current, "*.txt");

            int[] arrValues = fileReaderWriter.Read(files[0]);

            int sum = alghoritm.GetSumBites(arrValues);

            errorLb.Text = sum.ToString();
        }

        private void DisplayPathBtn_Click(object sender, EventArgs e)
        {
            displayPathBtn.Text = Folder.Current;
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            string parent = Path.GetFullPath(Path.Combine(Folder.Current, @"..\"));

            bool exists = Directory.Exists(string.Concat(parent, Folder.CD_Out));

            if (!exists)
            {
                Directory.CreateDirectory(string.Concat(parent, Folder.CD_Out));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}