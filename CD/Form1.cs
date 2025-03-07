using System;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cdInFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathLb.Text = dialog.SelectedPath;
            }
            else
            {
                pathLb.Text = "Folder is not selected";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
