using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectAD
{
    static class Program
    {
        public static string FilePath = Path.Combine(Environment.CurrentDirectory, @"JsonFile\Documents.txt");
        public static string FilePathToResolutions = Path.Combine(Environment.CurrentDirectory, @"JsonFile\Resolutions.txt");
        public static string FilePathToProtocols = Path.Combine(Environment.CurrentDirectory, @"JsonFile\Protocols.txt");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
