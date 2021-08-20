namespace Octo_Streamer
{
    class csSettings
    {
        public static string connectionAddress { get; set; }
        public static string connectionPort { get; set; }
        public static string connectionAuthToken { get; set; }
        public static string recievedData { get; set; }
        public static string recievedPrinterData { get; set; }
        public static int connectionActive { get; set; }
        public static int updateDataSignal { get; set; }
        public static int displayLayerProgress { get; set; }
        public static string recievedDisplayLayerProgressData { get; set; }

        public static int toolTempTargetSwitch { get; set; }
        public static int bedTempTargetSwitch { get; set; }


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
        public static string completion { get; set; }
        public static int filepos { get; set; }
        public static int printTime { get; set; }
        public static int printTimeLeft { get; set; }

        // printer
        public static decimal bedActual { get; set; }
        public static decimal bedTarget { get; set; }
        public static decimal toolActual { get; set; }
        public static decimal toolTarget { get; set; }

        // displayLayerProgress
        public static string dlpCurrentLayer { get; set; }
        public static string dlpTotalLayers { get; set; }
        public static string dlpFanSpeed { get; set; }
    }
}
