using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octo_Streamer
{
    static class Program
    {
        // Define application version
        public static string ApplicationVersion = "v0.0.3";

        // Dev mode
        // Disable update check features on git repo
        public static bool devMode = true;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
