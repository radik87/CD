using System;
using System.Windows.Forms;

namespace CD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CD_Delta(new Services.FileReaderWriter(), new Constans.Folder(), new Service.Alghoritm()));
        }
    }
}
