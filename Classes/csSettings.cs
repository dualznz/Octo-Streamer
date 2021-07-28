using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo_Streamer
{
    class csSettings
    {
        public static string connectionAddress { get; set; }
        public static string ConnectionPort { get; set; }
        public static string connectionAuthToken { get; set; }
        public static string recievedData { get; set; }



        // Octoprint api
        public static string state { get; set; }
        public static decimal estimatedPrintTime { get; set; }

        // filament
        public static decimal length { get; set; }

        // file
        public static int date { get; set; }
        public static string name { get; set; }
        public static string path { get; set; }
        public static int size { get; set; }

        public static string user { get; set; }

        // progress
        public static decimal completion { get; set; }
        public static int filepos { get; set; }
        public static int printTime { get; set; }
        public static int printTimeLeft { get; set; }
    }
}
