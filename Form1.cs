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
            // Reset server status label
            toolServerStatus.Text = null;

            // Set server status label
            toolServerStatus.ForeColor = Color.Orange;
            toolServerStatus.Text = "Establishing connection...";

            if (Properties.Settings.Default.Host == "")
            {
                // start receive connection timer
                tmrUpdateConnectionData.Start();

                // No connection settings have been found, open new connection window
                frmConnection connectionWindow = new frmConnection();
                connectionWindow.Show();
            } else
            {
                // Begin host transaction timer
                tmrHandshake.Enabled = true;
                tmrHandshake.Start();
            }
        }

        #endregion

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

        #region Remote Connection Establish
        private void tmrHandshake_Tick(object sender, EventArgs e)
        {
            // Stop and disable timer
            tmrHandshake.Stop();
            tmrHandshake.Enabled = false;

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

        private void btnFlash_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = "";
            Properties.Settings.Default.Port = "";
            Properties.Settings.Default.ApiKey = "";
            Properties.Settings.Default.Save();

            Application.ExitThread();
        }

        
    }
}
