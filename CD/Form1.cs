using CD.Constans;
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

        private void cdInFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Folder.Current = dialog.SelectedPath;
            }

            var files = Directory.GetFiles(Folder.Current, "*.txt");
        }

        private void displayPathBtn_Click(object sender, EventArgs e)
        {
            displayPathBtn.Text = Folder.Current;
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            string path = Folder.Current;

            string parent = Path.GetFullPath(Path.Combine(path, @"..\"));

            bool exists = Directory.Exists(string.Concat(parent, Folder.CD_Out));

            if (!exists)
            {
               Directory.CreateDirectory(string.Concat(parent, Folder.CD_Out));
            }
        }
    }
}
