using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace Octo_Streamer
{
    public partial class Form1 : Form
    {
        // Form declarations
        int remoteConnection = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Load

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check for stream files
            checkStreamDirectory();

            // Set current version of application in the tool menu
            toolCurrentVersionToolStripMenuItem.Text = "Version: " + Program.ApplicationVersion;

            // Reset server status label
            toolServerStatus.Text = null;

            // Set server status label
            toolServerStatus.ForeColor = Color.Black;
            toolServerStatus.Text = "Waiting for connection...";

            // Reset misc labels
            lblPrinterStatusValue.Text = "Waiting for connection";

            // Show main panel
            pnlMainDisplay.Visible = true;

            // Reset value labels
            resetValueLabels();

            // Server connection state
            csSettings.connectionActive = 0;

            // start receive connection timer
            tmrUpdateConnectionData.Start();

            // Reset stream file data / populate with NaN values
            dumpStreamDefaults();


            // check for application updates
            if (Program.devMode == false)
            {
                // Developer mode has been disabled, we can run the update version check
                tmrCheckForUpdates.Enabled = true;
                tmrCheckForUpdates.Start();
            }

            if (Properties.Settings.Default.Host == "")
            {
                // Change state for the connection to the server button event
                tsConnect.Enabled = false;
                tsConnect.Text = "Connect To Server";
                tsConnect.ForeColor = Color.DarkGreen;

                // No connection settings have been found, open new connection window
                frmConnection connectionWindow = new frmConnection();
                connectionWindow.Show();
            }
            else
            {
                // Change state for the connection to the server button event
                tsConnect.Enabled = true;
                tsConnect.Text = "Connect To Server";
                tsConnect.ForeColor = Color.DarkGreen;
            }

            // Check to see if displayLayerProgress setting is enabled
            switch (Properties.Settings.Default.DisplayLayerProgress)
            {
                case 0:
                    // Hide displayLayerProgress panel
                    pnlDisplayLayerProgress.Visible = false;
                    break;
                case 1:
                    // Show displayLayerProgress panel
                    pnlDisplayLayerProgress.Visible = true;

                    // reset labels
                    lblLayer.Text = "NaN";
                    lblFanSpeed.Text = "NaN";
                    break;
            }
        }

        #endregion

        #region Label Resets
        public void resetValueLabels()
        {
            lblBedActual.Text = "NaN";
            lblBedTarget.Text = "NaN";
            lblToolActual.Text = "NaN";
            lblToolTarget.Text = "NaN";
            lblTimeElapsed.Text = "NaN";
            lblTimeLeft.Text = "NaN";
            lblDateStartedValue.Text = "NaN";
            lblCurrentFileName.Text = "NaN";
            lblCompletedValue.Text = "NaN";
        }
        #endregion

        #region Connect Button
        private void tsConnect_Click(object sender, EventArgs e)
        {
            switch (csSettings.connectionActive)
            {
                case 0:
                    // No connection has been made to the remote server
                    // Enable api connection

                    // Begin host transaction timer
                    tmrHandshake.Enabled = true;
                    tmrHandshake.Start();

                    // Change connection state
                    csSettings.connectionActive = 1;

                    // Update connection button to disconnect state
                    tsConnect.Text = "Disconnect From Server";
                    tsConnect.ForeColor = Color.Red;
                    break;
                case 1:
                    // Connection has been made to the remote server
                    // diable api connection

                    // Stop remote api connection
                    tmrApi.Enabled = false;
                    tmrApi.Stop();

                    tmrLifeline.Enabled = false;
                    tmrLifeline.Stop();

                    // Change connection state
                    csSettings.connectionActive = 0;

                    // Update tool stop label
                    toolServerStatus.ForeColor = Color.Black;
                    toolServerStatus.Text = "Waiting for connection...";

                    // Reset misc labels
                    lblPrinterStatusValue.Text = "Waiting for connection";

                    // Update connection button to disconnect state
                    tsConnect.Text = "Connect To Server";
                    tsConnect.ForeColor = Color.DarkGreen;

                    // Reset value labels
                    resetValueLabels();

                    // Reset stream values
                    //dumpStreamDefaults();
                    break;
                default:
                    // No connection has been made to the remote server
                    // Enable api connection

                    // Begin host transaction timer
                    tmrHandshake.Enabled = true;
                    tmrHandshake.Start();

                    // Change connection state
                    csSettings.connectionActive = 1;

                    // Update connection button to disconnect state
                    tsConnect.Text = "Disconnect From Server";
                    tsConnect.ForeColor = Color.Red;
                    break;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            switch (csSettings.connectionActive)
            {
                case 0:
                    // No connection has been made to the remote server
                    // Enable api connection

                    // Begin host transaction timer
                    tmrHandshake.Enabled = true;
                    tmrHandshake.Start();

                    // Change connection state
                    csSettings.connectionActive = 1;

                    // Update connection button to disconnect state
                    tsConnect.Text = "Disconnect From Server";
                    tsConnect.ForeColor = Color.Red;
                    break;
                case 1:
                    // Connection has been made to the remote server
                    // diable api connection

                    // Stop remote api connection
                    tmrApi.Enabled = false;
                    tmrApi.Stop();

                    tmrLifeline.Enabled = false;
                    tmrLifeline.Stop();

                    // Change connection state
                    csSettings.connectionActive = 0;

                    // Update tool stop label
                    toolServerStatus.ForeColor = Color.Black;
                    toolServerStatus.Text = "Waiting for connection...";

                    // Reset misc labels
                    lblPrinterStatusValue.Text = "Waiting for connection";

                    // Update connection button to disconnect state
                    tsConnect.Text = "Connect To Server";
                    tsConnect.ForeColor = Color.DarkGreen;

                    // Reset value labels
                    resetValueLabels();
                    break;
                default:
                    // No connection has been made to the remote server
                    // Enable api connection

                    // Begin host transaction timer
                    tmrHandshake.Enabled = true;
                    tmrHandshake.Start();

                    // Change connection state
                    csSettings.connectionActive = 1;

                    // Update connection button to disconnect state
                    tsConnect.Text = "Disconnect From Server";
                    tsConnect.ForeColor = Color.Red;
                    break;
            }
        }

        #endregion

        #region Connnection Update Worker
        private void tmrUpdateConnectionData_Tick(object sender, EventArgs e)
        {
            if (csSettings.updateDataSignal == 1)
            {
                if (Properties.Settings.Default.Host != "")
                {
                    // Connection settings have been updated and an initial connection has been made to the remote server
                    // Enable connect to server button
                    tsConnect.Enabled = true;

                    // Reset connectionActive state
                    csSettings.updateDataSignal = 0;

                }
                else
                {
                    // Disable connect to server button
                    tsConnect.Enabled = false;

                    // Reset connectionActive state
                    csSettings.updateDataSignal = 0;
                }
            }
            else if (csSettings.updateDataSignal == 2)
            {
                // Check to see if displayLayerProgress setting is enabled
                switch (Properties.Settings.Default.DisplayLayerProgress)
                {
                    case 0:
                        // Hide displayLayerProgress panel
                        pnlDisplayLayerProgress.Visible = false;

                        // Reset connectionActive state
                        csSettings.connectionActive = 0;
                        break;
                    case 1:
                        // Show displayLayerProgress panel
                        pnlDisplayLayerProgress.Visible = true;

                        // Reset connectionActive state
                        csSettings.updateDataSignal = 0;
                        break;
                }
            }
            else if (csSettings.updateDataSignal == 3)
            {
                // Disable connect to server button
                tsConnect.Enabled = false;

                // Reset connectionActive state
                csSettings.updateDataSignal = 0;
            }
        }

        #endregion

        #region Remote Connection Establish
        private void tmrHandshake_Tick(object sender, EventArgs e)
        {
            // Stop and disable timer
            tmrHandshake.Stop();
            tmrHandshake.Enabled = false;

            // Enable main panel
            //pnlMainDisplay.Visible = true;

            // Access remote host process
            remoteServerHandshake(Properties.Settings.Default.Host, Properties.Settings.Default.Port, Properties.Settings.Default.ApiKey);

        }

        private void tmrLifeline_Tick(object sender, EventArgs e)
        {
            // Access remote host process
            remoteServerHandshake(Properties.Settings.Default.Host, Properties.Settings.Default.Port, Properties.Settings.Default.ApiKey);
        }

        private void remoteServerHandshake(string host, string port, string apiKey)
        {
            try
            {
                string portCheck = null;
                if (port != null)
                {
                    portCheck = ":" + port;
                }
                else
                {
                    portCheck = null;
                }

                // Transmission Data (POST / GET)
                string authServer = host + portCheck + "/api/files";

                // Create request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(authServer); request.KeepAlive = false;
                request.Headers.Add("Authorization", "Bearer " + apiKey);
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "GET";
                request.Accept = "application/json";

                // Await response from remote server
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var test = new StreamReader(response.GetResponseStream()).ReadToEnd();


                // Close remote connection
                response.Close();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Update connection label with confirmation
                    toolServerStatus.ForeColor = Color.DarkGreen;
                    toolServerStatus.Text = "Connection established...";

                    // Enable percistant handshake to remote server
                    remoteConnection = 1;

                    if (remoteConnection == 1)
                    {
                        // Set a percistant handshake to remote server (every 1 seconds)
                        tmrLifeline.Enabled = true;
                        tmrLifeline.Start();
                    }

                    // start api handle
                    tmrApi.Enabled = true;
                    tmrApi.Start();

                    // Set server connection state
                    csSettings.connectionActive = 1;
                }

            }
            catch (Exception)
            {
                // Disable percistant handshake to remote server
                remoteConnection = 0;
                tmrLifeline.Stop();
                tmrLifeline.Enabled = false;

                tmrApi.Enabled = false;
                tmrApi.Stop();

                // Update connection label with failure
                toolServerStatus.ForeColor = Color.Red;
                toolServerStatus.Text = "Connection failed...";

                // Update connection button to disconnect state
                tsConnect.Text = "Connect To Server";
                tsConnect.ForeColor = Color.DarkGreen;

                // Reset value labels
                resetValueLabels();

                // Set server connection state
                csSettings.connectionActive = 0;
            }
        }

        #endregion

        #region Application Exit
        private void tsExitApplication_Click(object sender, EventArgs e)
        {
            // Exit Application
            System.Windows.Forms.Application.Exit();
        }
        #endregion

        #region Github URL
        private void linkDualznzGithub_Click(object sender, EventArgs e)
        {
            // Open dualznz github profile
            System.Diagnostics.Process.Start("https://github.com/dualznz");
        }
        #endregion

        #region Main API Interaction

        private void tmrApi_Tick(object sender, EventArgs e)
        {
            // Create connection to the api request declaration
            apiJobRequest(Properties.Settings.Default.Host, Properties.Settings.Default.Port, Properties.Settings.Default.ApiKey);
            apiPrinterRequest(Properties.Settings.Default.Host, Properties.Settings.Default.Port, Properties.Settings.Default.ApiKey);

            // Stream data to files
            streamToFiles();
        }

        #region Job Data
        private void apiJobRequest(string host, string port, string apiKey)
        {
            try
            {
                string portCheck = null;
                if (port != null)
                {
                    portCheck = ":" + port;
                }
                else
                {
                    portCheck = null;
                }

                // Transmission Data (POST / GET)
                string authServer = host + portCheck + "/api/job";

                // Create request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(authServer); request.KeepAlive = false;
                request.Headers.Add("Authorization", "Bearer " + apiKey);
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "GET";
                request.Accept = "application/json";

                // Await response from remote server
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    rtbPrinterStatus.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    csSettings.recievedData = rtbPrinterStatus.Text;
                    processApiJobData(csSettings.recievedData);
                    processApiPrinterData(csSettings.recievedPrinterData);
                }

            }
            catch (Exception)
            {
                // Reset value labels
                resetValueLabels();
            }
        }

        private void processApiJobData(string inputApiData)
        {
            try
            {
                // Decode api data into json variables
                Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(inputApiData);

                csSettings.state = jObject["state"].ToString();
                lblPrinterStatusValue.Text = csSettings.state;

                switch (csSettings.state)
                {
                    case "Printing":
                        // Add values to class
                        csSettings.completion = jObject["progress"]["completion"].ToString();
                        csSettings.date = Convert.ToInt32(jObject["job"]["file"]["date"].ToString());
                        csSettings.printTime = Convert.ToInt32(jObject["progress"]["printTime"].ToString());
                        csSettings.printTimeLeft = Convert.ToInt32(jObject["progress"]["printTimeLeft"].ToString());

                        csSettings.name = jObject["job"]["file"]["display"].ToString();
                        lblCurrentFileName.Text = csSettings.name;

                        double inputCompletion = Convert.ToDouble(csSettings.completion);
                        lblCompletedValue.Text = inputCompletion.ToString("N2") + " %";

                        lblDateStartedValue.Text = TimeSpanConverterDate(csSettings.date);

                        lblTimeElapsed.Text = TimeSpanConverter(csSettings.printTime);

                        lblTimeLeft.Text = TimeSpanConverter(csSettings.printTimeLeft);
                        break;
                    case "Operational":
                        lblCurrentFileName.Text = "NaN";
                        lblTimeElapsed.Text = "NaN";
                        lblTimeLeft.Text = "NaN";
                        lblDateStartedValue.Text = "NaN";
                        lblCurrentFileName.Text = "NaN";
                        lblCompletedValue.Text = "NaN";
                        lblLayer.Text = "NaN";
                        lblFanSpeed.Text = "NaN";
                        lblLayer.Text = "NaN";
                        break;
                }
                

            }
            catch (Exception)
            {
                // Reset value labels
                resetValueLabels();

                csSettings.connectionActive = 0;
            }
        }

        #endregion

        #region Printer Data
        private void apiPrinterRequest(string host, string port, string apiKey)
        {
            try
            {
                string portCheck = null;
                if (port != null)
                {
                    portCheck = ":" + port;
                }
                else
                {
                    portCheck = null;
                }

                // Transmission Data (POST / GET)
                string authServer = host + portCheck + "/api/printer?history=false";

                // Create request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(authServer); request.KeepAlive = false;
                request.Headers.Add("Authorization", "Bearer " + apiKey);
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "GET";
                request.Accept = "application/json";

                // Await response from remote server
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    csSettings.recievedPrinterData = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    processApiPrinterData(csSettings.recievedPrinterData);
                }

            }
            catch (Exception)
            {
                // Reset value labels
                resetValueLabels();
            }
        }

        private void processApiPrinterData(string inputApiData)
        {
            try
            {
                // Decode api data into json variables
                Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(inputApiData);

                // Available declarations
                //https://docs.octoprint.org/en/master/api/printer.html#retrieve-the-current-printer-state

                if (jObject["state"]["flags"]["printing"].ToString() == "True")
                {
                    // Job is printing
                    csSettings.toolActual = Convert.ToDecimal(jObject["temperature"]["tool0"]["actual"].ToString());
                    lblToolActual.Text = string.Format("{0} \u00B0C /", csSettings.toolActual);

                    csSettings.toolTarget = Convert.ToDecimal(jObject["temperature"]["tool0"]["target"].ToString());
                    lblToolTarget.Text = string.Format("{0} \u00B0C target", csSettings.toolTarget);

                    csSettings.bedActual = Convert.ToDecimal(jObject["temperature"]["bed"]["actual"].ToString());
                    lblBedActual.Text = string.Format("{0} \u00B0C /", csSettings.bedActual);

                    csSettings.bedTarget = Convert.ToDecimal(jObject["temperature"]["bed"]["target"].ToString());
                    lblBedTarget.Text = string.Format("{0} \u00B0C target", csSettings.bedTarget);

                    // Create connection to displayLayerProgress
                    displayLayerProgress(Properties.Settings.Default.Host, Properties.Settings.Default.Port, Properties.Settings.Default.ApiKey);
                }
                else if (jObject["state"]["flags"]["ready"].ToString() == "True")
                {
                    // Job is idle but the printer is ready to recieve data
                    // Reset the printer data fields
                    //resetValueLabels();
                    csSettings.toolActual = Convert.ToDecimal(jObject["temperature"]["tool0"]["actual"].ToString());
                    lblToolActual.Text = string.Format("{0} \u00B0C /", csSettings.toolActual);

                    csSettings.toolTarget = Convert.ToDecimal(jObject["temperature"]["tool0"]["target"].ToString());
                    lblToolTarget.Text = string.Format("{0} \u00B0C target", csSettings.toolTarget);

                    csSettings.bedActual = Convert.ToDecimal(jObject["temperature"]["bed"]["actual"].ToString());
                    lblBedActual.Text = string.Format("{0} \u00B0C /", csSettings.bedActual);

                    csSettings.bedTarget = Convert.ToDecimal(jObject["temperature"]["bed"]["target"].ToString());
                    lblBedTarget.Text = string.Format("{0} \u00B0C target", csSettings.bedTarget);
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        private void displayLayerProgress(string host, string port, string apiKey)
        {
            try
            {
                string portCheck = null;
                if (port != null)
                {
                    portCheck = ":" + port;
                }
                else
                {
                    portCheck = null;
                }

                // Transmission Data (POST / GET)
                string authServer = host + portCheck + "/plugin/DisplayLayerProgress/values";

                // Create request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(authServer); request.KeepAlive = false;
                request.Headers.Add("Authorization", "Bearer " + apiKey);
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "GET";
                request.Accept = "application/json";

                // Await response from remote server
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    csSettings.recievedDisplayLayerProgressData = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    processDisplayLayerProgressData(csSettings.recievedDisplayLayerProgressData);
                }
            }
            catch (Exception)
            {

            }
        }

        private void processDisplayLayerProgressData(string inputApiData)
        {
            try
            {
                // Decode api data into json variables
                Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(inputApiData);

                // Add variables to class and fields
                csSettings.dlpCurrentLayer = jObject["layer"]["current"].ToString();
                csSettings.dlpTotalLayers = jObject["layer"]["total"].ToString();
                // HTML in label control
                lblLayer.Text = "<b>" + csSettings.dlpCurrentLayer + "</b>" + " of " + csSettings.dlpTotalLayers;
                lblLayer.AllowHtmlString = true;
                lblLayer.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                lblLayer.Appearance.Options.UseTextOptions = true;
                lblLayer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;

                csSettings.dlpFanSpeed = jObject["fanSpeed"].ToString();
                lblFanSpeed.Text = csSettings.dlpFanSpeed;


            }
            catch (Exception)
            {

                
            }
        }

        #endregion

        #region Timespan Converter
        public string TimeSpanConverter(int time)
        {
            var timeSpan = TimeSpan.FromSeconds(time);
            int hr = timeSpan.Hours;
            int mn = timeSpan.Minutes;

            return " " + hr + ":" + mn + " h";
        }

        public string TimeSpanConverterDate(int time)
        {
            var localDateTime = DateTimeOffset.FromUnixTimeSeconds(time).DateTime.ToLocalTime();
            return Convert.ToString(localDateTime);
        }
        #endregion

        #region Navigation
        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No connection settings have been found, open new connection window
            frmConnection connectionWindow = new frmConnection();
            connectionWindow.Show();
        }

        private void applicationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open application settings window
            frmAppSettings appSettingsWindow = new frmAppSettings();
            appSettingsWindow.Show();
        }

        #endregion

        #region Check for stream files
        private void checkStreamDirectory()
        {
            // Define base location of application stream files
            string coreLocation = System.Windows.Forms.Application.StartupPath;
            string streamDirectory = "stream";

            // Check to see if stream directory has been created or not
            if (System.IO.Directory.Exists(coreLocation + "/" + streamDirectory) == false)
            {
                // Directory does not exsit so we will need to create it
                System.IO.Directory.CreateDirectory(coreLocation + "/" + streamDirectory);

                // Check for stream files
                checkStreamfiles(coreLocation, streamDirectory);
            }
            else
            {
                // Directory exists so we can begin checking for files
                checkStreamfiles(coreLocation, streamDirectory);
            }

        }

        private void checkStreamfiles(string coreDirectory, string streamDirectory)
        {
            // Define strict location
            string directoryRoot = coreDirectory + "/" + streamDirectory + "/";

            #region Printer

            // Check for folder: printer
            if (System.IO.Directory.Exists(directoryRoot + "printer") == false)
            {
                // Directory does not exist, we need to create it
                System.IO.Directory.CreateDirectory(directoryRoot + "printer");

                // Check for individual files
                printerFiles(directoryRoot, "printer");
            } 
            else
            {
                // Directory exists, check for files
                printerFiles(directoryRoot, "printer");
            }

            #endregion

            #region Temp

            // Check for folder: temp
            if (System.IO.Directory.Exists(directoryRoot + "temp") == false)
            {
                // Directory does not exist, we need to create it
                System.IO.Directory.CreateDirectory(directoryRoot + "temp");

                // Check for individual files
                tempFiles(directoryRoot, "temp");
            }
            else
            {
                // Directory exists, check for files
                tempFiles(directoryRoot, "temp");
            }

            #endregion

            #region Progress

            // Check for folder: progress
            if (System.IO.Directory.Exists(directoryRoot + "progress") == false)
            {
                // Directory does not exist, we need to create it
                System.IO.Directory.CreateDirectory(directoryRoot + "progress");

                // Check for individual files
                progressFiles(directoryRoot, "progress");
            }
            else
            {
                // Directory exists, check for files
                progressFiles(directoryRoot, "progress");
            }

            #endregion

            #region DisplayLayerProgress

            // Check for folder: displayLayerProgress
            if (System.IO.Directory.Exists(directoryRoot + "displayLayerProgress") == false)
            {
                // Directory does not exist, we need to create it
                System.IO.Directory.CreateDirectory(directoryRoot + "displayLayerProgress");

                // Check for individual files
                displayLayerProgressFiles(directoryRoot, "displayLayerProgress");
            }
            else
            {
                // Directory exists, check for files
                displayLayerProgressFiles(directoryRoot, "displayLayerProgress");
            }

            #endregion
        }

        private void printerFiles(string coreDirectory, string subDirectory)
        {
            // define base location
            string directoryRoot = coreDirectory + subDirectory + "/";

            // Check for file: printerStatus
            if (System.IO.File.Exists(directoryRoot + "printerStatus.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "printerStatus.txt");
            }

            // Check for file: printerFile
            if (System.IO.File.Exists(directoryRoot + "printerFile.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "printerFile.txt");
            }
        }

        private void tempFiles(string coreDirectory, string subDirectory)
        {
            // define base location
            string directoryRoot = coreDirectory + subDirectory + "/";

            // Check for file: tempStatusHotend
            if (System.IO.File.Exists(directoryRoot + "tempStatusHotend.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "tempStatusHotend.txt");
            }

            // Check for file: tempStatusBed
            if (System.IO.File.Exists(directoryRoot + "tempStatusBed.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "tempStatusBed.txt");
            }
        }

        private void progressFiles(string coreDirectory, string subDirectory)
        {
            // Define base location
            string directoryRoot = coreDirectory + subDirectory + "/";

            // Check for file: printProgressCompleted
            if (System.IO.File.Exists(directoryRoot + "printProgressCompleted.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "printProgressCompleted.txt");
            }

            // Check for file: printProgressElasped
            if (System.IO.File.Exists(directoryRoot + "printProgressElasped.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "printProgressElasped.txt");
            }

            // Check for file: printProgressLeft
            if (System.IO.File.Exists(directoryRoot + "printProgressLeft.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "printProgressLeft.txt");
            }
        }

        private void displayLayerProgressFiles(string coreDirectory, string subDirectory)
        {
            // Define base location
            string directoryRoot = coreDirectory + subDirectory + "/";

            // Check for file: layerStatus
            if (System.IO.File.Exists(directoryRoot + "layerStatus.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "layerStatus.txt");
            }

            // Check for file: fanSpeed
            if (System.IO.File.Exists(directoryRoot + "fanSpeed.txt") == false)
            {
                // File does not exist, create it
                System.IO.File.Create(directoryRoot + "fanSpeed.txt");
            }
        }

        #endregion

        #region Stream data to files

        private void streamToFiles()
        {
            // Define base location for data fields
            string defaultDirectory = System.Windows.Forms.Application.StartupPath + "/stream/";

            // Define sub-directories
            string printerDir = "printer/";
            string tempDir = "temp/";
            string progressDir = "progress/";
            string displayLayerProgressDir = "displayLayerProgress/";

            #region Printer

            // Check for file: printerFile
            if (System.IO.File.Exists(defaultDirectory + printerDir + "printerFile.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printerFile = new System.IO.StreamWriter(defaultDirectory + printerDir + "printerFile.txt");
                printerFile.Write(lblCurrentFileName.Text);
                printerFile.Close();
            }

            // Check for file: printerStatus
            if (System.IO.File.Exists(defaultDirectory + printerDir + "printerStatus.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printerStatus = new System.IO.StreamWriter(defaultDirectory + printerDir + "printerStatus.txt");
                printerStatus.Write(lblPrinterStatusValue.Text);
                printerStatus.Close();
            }

            #endregion

            #region Temp

            // Check for file: tempStatusHotend
            if (System.IO.File.Exists(defaultDirectory + tempDir + "tempStatusHotend.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter tempStatusHotend = new System.IO.StreamWriter(defaultDirectory + tempDir + "tempStatusHotend.txt");

                // Convert temp to string with celcius format
                string toolTemp = string.Format("{0} \u00B0C", csSettings.toolActual);
                string toolTarget = string.Format(" / {0} \u00B0C", csSettings.toolTarget);

                // Check if target has been enabled
                switch (Properties.Settings.Default.ToolTempTarget)
                {
                    case 0:
                        tempStatusHotend.Write(toolTemp);
                        break;
                    case 1:
                        tempStatusHotend.Write(toolTemp + toolTarget);
                        break;
                    default:
                        tempStatusHotend.Write(toolTemp + toolTarget);
                        break;
                }
                
                // Close connection
                tempStatusHotend.Close();
            }

            // Check for file: tempStatusBed
            if (System.IO.File.Exists(defaultDirectory + tempDir + "tempStatusBed.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter tempStatusBed = new System.IO.StreamWriter(defaultDirectory + tempDir + "tempStatusBed.txt");

                // Convert temp to string with celcius format
                string bedTemp = string.Format("{0} \u00B0C", csSettings.bedActual);
                string bedTarget = string.Format(" / {0} \u00B0C", csSettings.bedTarget);

                // Check if target has been enabled
                switch (Properties.Settings.Default.BedTempTarget)
                {
                    case 0:
                        tempStatusBed.Write(bedTemp);
                        break;
                    case 1:
                        tempStatusBed.Write(bedTemp + bedTarget);
                        break;
                    default:
                        tempStatusBed.Write(bedTemp + bedTarget);
                        break;
                }

                // Close connection
                tempStatusBed.Close();
            }

            #endregion

            #region Progress

            // Check for file: printProgressCompleted
            if (System.IO.File.Exists(defaultDirectory + progressDir + "printProgressCompleted.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printProgressCompleted = new System.IO.StreamWriter(defaultDirectory + progressDir + "printProgressCompleted.txt");
                printProgressCompleted.Write(lblCompletedValue.Text);
                printProgressCompleted.Close();
            }

            // Check for file: printProgressElasped
            if (System.IO.File.Exists(defaultDirectory + progressDir + "printProgressElasped.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printProgressElasped = new System.IO.StreamWriter(defaultDirectory + progressDir + "printProgressElasped.txt");
                printProgressElasped.Write(lblTimeElapsed.Text);
                printProgressElasped.Close();
            }

            // Check for file: printProgressLeft
            if (System.IO.File.Exists(defaultDirectory + progressDir + "printProgressLeft.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printProgressLeft = new System.IO.StreamWriter(defaultDirectory + progressDir + "printProgressLeft.txt");
                printProgressLeft.Write(lblTimeLeft.Text);
                printProgressLeft.Close();
            }

            #endregion

            #region DisplayLayerProgress

            // Check to see if DisplayLayerProgress is enabled in application settings before updating files
            if (Properties.Settings.Default.DisplayLayerProgress == 1)
            {
                // Process information from class
                string layerTrigger = "";

                // Plugin is enabled, we can process StreamWriter events
                // Check for file: layerStatus
                if (System.IO.File.Exists(defaultDirectory + displayLayerProgressDir + "layerStatus.txt") == true)
                {
                    // File exists, stream data to file
                    System.IO.StreamWriter layerStatus = new System.IO.StreamWriter(defaultDirectory + displayLayerProgressDir + "layerStatus.txt");
                    
                    if (csSettings.state == "Printing")
                    {
                        layerTrigger = csSettings.dlpCurrentLayer + " of " + csSettings.dlpTotalLayers + " layers";
                    }
                    else
                    {
                        layerTrigger = "NaN";
                    }

                    layerStatus.Write(layerTrigger);
                    layerStatus.Close();
                }

                // Check for file: fanSpeed
                if (System.IO.File.Exists(defaultDirectory + displayLayerProgressDir + "fanSpeed.txt") == true)
                {
                    // File exists, stream data to file
                    System.IO.StreamWriter fanSpeed = new System.IO.StreamWriter(defaultDirectory + displayLayerProgressDir + "fanSpeed.txt");
                    fanSpeed.Write(csSettings.dlpFanSpeed);
                    fanSpeed.Close();
                }
            } else
            {
                // Reset values in files
                lblLayer.Text = "NaN";
                lblFanSpeed.Text = "NaN";

                if (System.IO.File.Exists(defaultDirectory + displayLayerProgressDir + "layerStatus.txt") == true)
                {
                    // Stream data to layer status file
                    System.IO.StreamWriter layerStatus = new System.IO.StreamWriter(defaultDirectory + displayLayerProgressDir + "layerStatus.txt");
                    layerStatus.Write("NaN");
                    layerStatus.Close();
                }
            }

            #endregion
        }

        #endregion

        #region Reset stream files data

        private void dumpStreamDefaults()
        {
            // Define base location for data fields
            string defaultDirectory = System.Windows.Forms.Application.StartupPath + "/stream/";

            // Define sub-directories
            string printerDir = "printer/";
            string tempDir = "temp/";
            string progressDir = "progress/";
            string displayLayerProgressDir = "displayLayerProgress/";

            #region Printer

            // Check for file: printerStatus
            if (System.IO.File.Exists(defaultDirectory + printerDir + "printerStatus.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printerStatus = new System.IO.StreamWriter(defaultDirectory + printerDir + "printerStatus.txt");
                printerStatus.Write("Not connected");
                printerStatus.Close();
            }

            // Check for file: printerFile
            if (System.IO.File.Exists(defaultDirectory + printerDir + "printerFile.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printerFile = new System.IO.StreamWriter(defaultDirectory + printerDir + "printerFile.txt");
                printerFile.Write("NaN");
                printerFile.Close();
            }

            #endregion

            #region Temp

            // Check for file: tempStatusHotend
            if (System.IO.File.Exists(defaultDirectory + tempDir + "tempStatusHotend.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter tempStatusHotend = new System.IO.StreamWriter(defaultDirectory + tempDir + "tempStatusHotend.txt");
                tempStatusHotend.Write("NaN");
                tempStatusHotend.Close();
            }

            // Check for file: tempStatusBed
            if (System.IO.File.Exists(defaultDirectory + tempDir + "tempStatusBed.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter tempStatusBed = new System.IO.StreamWriter(defaultDirectory + tempDir + "tempStatusBed.txt");
                tempStatusBed.Write("NaN");
                tempStatusBed.Close();
            }

            #endregion

            #region Progress

            // Check for file: printProgressCompleted
            if (System.IO.File.Exists(defaultDirectory + progressDir + "printProgressCompleted.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printProgressCompleted = new System.IO.StreamWriter(defaultDirectory + progressDir + "printProgressCompleted.txt");
                printProgressCompleted.Write("NaN");
                printProgressCompleted.Close();
            }

            // Check for file: printProgressElasped
            if (System.IO.File.Exists(defaultDirectory + progressDir + "printProgressElasped.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printProgressElasped = new System.IO.StreamWriter(defaultDirectory + progressDir + "printProgressElasped.txt");
                printProgressElasped.Write("NaN");
                printProgressElasped.Close();
            }

            // Check for file: printProgressLeft
            if (System.IO.File.Exists(defaultDirectory + progressDir + "printProgressLeft.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter printProgressLeft = new System.IO.StreamWriter(defaultDirectory + progressDir + "printProgressLeft.txt");
                printProgressLeft.Write("NaN");
                printProgressLeft.Close();
            }

            #endregion

            #region DisplayLayerProgress

            // Check for file: layerStatus
            if (System.IO.File.Exists(defaultDirectory + displayLayerProgressDir + "layerStatus.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter layerStatus = new System.IO.StreamWriter(defaultDirectory + displayLayerProgressDir + "layerStatus.txt");
                layerStatus.Write("NaN");
                layerStatus.Close();
            }

            // Check for file: fanSpeed
            if (System.IO.File.Exists(defaultDirectory + displayLayerProgressDir + "fanSpeed.txt") == true)
            {
                // File exists, stream data to file
                System.IO.StreamWriter fanSpeed = new System.IO.StreamWriter(defaultDirectory + displayLayerProgressDir + "fanSpeed.txt");
                fanSpeed.Write("NaN");
                fanSpeed.Close();
            }

            #endregion
        }

        #endregion

        #region Application Update Check

        private void tmrCheckForUpdates_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            tmrCheckForUpdates.Stop();
            tmrCheckForUpdates.Enabled = false;

            // Check for updates
            UpdateCheck();
        }
        private async void UpdateCheck()
        {
            try
            {
                var github = new GitHubClient(new ProductHeaderValue("Octo-Streamer"));
                var repo = await github.Repository.Release.GetLatest("dualznz", "Octo-Streamer");

                // check to see if there is a new version
                if (Program.ApplicationVersion != repo.TagName)
                {
                    // New application release is available, enable and show update event
                    linkGithubReleases.Enabled = true;
                    linkGithubReleases.Visible = true;

                    // Debug
                    Console.WriteLine(repo.TagName);

                    // Navigate to the github releases page
                    System.Diagnostics.Process.Start("https://github.com/dualznz/Octo-Streamer/releases");
                }
                else
                {
                    // Application is on the latest version
                    linkGithubReleases.Enabled = false;
                    linkGithubReleases.Visible = false;

                    // Debug
                    Console.WriteLine(repo.TagName);
                }

            }
            catch (Exception)
            {
                // No tags have been found or error connecting to GitHub
                Console.WriteLine("Unable to connect to Octo-Streamer Repo and check for new releases");
            }
        }
        #endregion

        #region Github Homepage
        private void githubHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigate to project homepage
            System.Diagnostics.Process.Start("https://github.com/dualznz/Octo-Streamer");
        }

        #endregion

        #region Github Issues
        private void githubIssuesRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigate to project issue / features page
            System.Diagnostics.Process.Start("https://github.com/dualznz/Octo-Streamer/issues");
        }
        #endregion

        #region Form Closing

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset all stream values before closing the application
            dumpStreamDefaults();
        }

        #endregion
    }
}
