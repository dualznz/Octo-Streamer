﻿using System;
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

namespace Octo_Streamer
{
    public partial class Form1 : Form
    {
        // Form declarations
        int remoteConnection = 0;
        int connectionState = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Load

        private void Form1_Load(object sender, EventArgs e)
        {
            // Reset server status label
            toolServerStatus.Text = null;

            // Set server status label
            toolServerStatus.ForeColor = Color.Black;
            toolServerStatus.Text = "Waiting for connection...";

            // Hide main panel
            pnlMainDisplay.Visible = false;

            // Reset misc labels
            lblPrinterStatusValue.Text = "Waiting for connection";

            // Hide main panel
            pnlMainDisplay.Visible = true;

            if (Properties.Settings.Default.Host == "")
            {
                // start receive connection timer
                tmrUpdateConnectionData.Start();

                // No connection settings have been found, open new connection window
                frmConnection connectionWindow = new frmConnection();
                connectionWindow.Show();
            }
        }

        #endregion

        #region Connect Button
        private void btnConnect_Click(object sender, EventArgs e)
        {
            switch (connectionState)
            {
                case 0:
                    // No connection has been made to the remote server
                    // Enable api connection

                    // Begin host transaction timer
                    tmrHandshake.Enabled = true;
                    tmrHandshake.Start();

                    // Change connection state
                    connectionState = 1;

                    // Update connection button to disconnect state
                    btnConnect.Text = "Disconnect From Server";
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
                    connectionState = 0;

                    // Disable job panel
                    pnlActivePrint.Visible = false;

                    // Update tool stop label
                    toolServerStatus.ForeColor = Color.Black;
                    toolServerStatus.Text = "Waiting for connection...";

                    // Reset misc labels
                    lblPrinterStatusValue.Text = "Waiting for connection";

                    // Update connection button to disconnect state
                    btnConnect.Text = "Connect To Server";
                    break;
                default:
                    // No connection has been made to the remote server
                    // Enable api connection

                    // Begin host transaction timer
                    tmrHandshake.Enabled = true;
                    tmrHandshake.Start();

                    // Change connection state
                    connectionState = 1;

                    // Update connection button to disconnect state
                    btnConnect.Text = "Disconnect From Server";
                    break;
            }
        }

        #endregion

        #region Connnection Update Worker
        private void tmrUpdateConnectionData_Tick(object sender, EventArgs e)
        {
            if (csSettings.connectionAddress != null)
            {
                // Connection settings have been updated and an initial connection has been made to the remote server

                // Stop the timer
                tmrUpdateConnectionData.Stop();

                // Update connection label with failure
                toolServerStatus.ForeColor = Color.Orange;
                toolServerStatus.Text = "Establishing connection...";

                // Begin host transaction timer
                tmrHandshake.Enabled = true;
                tmrHandshake.Start();
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
            pnlMainDisplay.Visible = true;

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

                // Update connection label with confirmation
                toolServerStatus.ForeColor = Color.DarkGreen;
                toolServerStatus.Text = "Connection established...";

                // Enable percistant handshake to remote server
                remoteConnection = 1;

                if (remoteConnection == 1)
                {
                    // Set a percistant handshake to remote server (every 1 minute)
                    tmrLifeline.Enabled = true;
                    tmrLifeline.Start();
                }

                // start api handle
                tmrApi.Enabled = true;
                tmrApi.Start();

            }
            catch (Exception)
            {
                // Disable percistant handshake to remote server
                remoteConnection = 0;
                tmrLifeline.Stop();
                tmrLifeline.Enabled = false;

                // Update connection label with failure
                toolServerStatus.ForeColor = Color.Red;
                toolServerStatus.Text = "Connection failed...";
            }
        }

        #endregion

        #region DEV
        private void btnFlash_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = "";
            Properties.Settings.Default.Port = "";
            Properties.Settings.Default.ApiKey = "";
            Properties.Settings.Default.Save();

            Application.ExitThread();
        }

        #endregion

        #region Application Exit
        private void tsExitApplication_Click(object sender, EventArgs e)
        {
            // Exit Application
            Application.ExitThread();
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

                pnlActivePrint.Visible = true;

                csSettings.name = jObject["job"]["file"]["display"].ToString();
                lblCurrentFileName.Text = csSettings.name;

                csSettings.completion = jObject["progress"]["completion"].ToString();
                double inputCompletion = Convert.ToDouble(csSettings.completion);
                lblCompletedValue.Text = inputCompletion.ToString("N2") + " %";

                csSettings.date = Convert.ToInt32(jObject["job"]["file"]["date"].ToString());
                lblDateStartedValue.Text = TimeSpanConverterDate(csSettings.date);

                csSettings.printTime = Convert.ToInt32(jObject["progress"]["printTime"].ToString());
                lblTimeElapsed.Text = TimeSpanConverter(csSettings.printTime);

                csSettings.printTimeLeft = Convert.ToInt32(jObject["progress"]["printTimeLeft"].ToString());
                lblTimeLeft.Text = TimeSpanConverter(csSettings.printTimeLeft);

            }
            catch (Exception)
            {

                //throw;
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

            }
        }

        private void processApiPrinterData(string inputApiData)
        {
            try
            {
                // Decode api data into json variables
                Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(inputApiData);

                csSettings.toolActual = Convert.ToDecimal(jObject["temperature"]["tool0"]["actual"].ToString());
                lblToolActual.Text = string.Format("{0} \u00B0C /", csSettings.toolActual);

                csSettings.toolTarget = Convert.ToDecimal(jObject["temperature"]["tool0"]["target"].ToString());
                lblToolTarget.Text = string.Format("{0} \u00B0C target", csSettings.toolTarget);

                csSettings.bedActual = Convert.ToDecimal(jObject["temperature"]["bed"]["actual"].ToString());
                lblBedActual.Text = string.Format("{0} \u00B0C /", csSettings.bedActual);

                csSettings.bedTarget = Convert.ToDecimal(jObject["temperature"]["bed"]["target"].ToString());
                lblBedTarget.Text = string.Format("{0} \u00B0C target", csSettings.bedTarget);
            }
            catch (Exception)
            {

                //throw;
            }
        }
        #endregion



        #endregion


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


    }
}
