using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Atom_Care
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WindowsMediaPlayer soundtrack = new WindowsMediaPlayer();
            string a = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "\\music.mp3";
            soundtrack.URL = a;

            soundtrack.controls.play();
            soundtrack.settings.volume = 25;

            Application.Run(new Form1());
        }
    }
}
