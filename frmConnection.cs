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
    public partial class frmConnection : Form
    {

        public frmConnection()
        {
            InitializeComponent();
        }

        #region Form Load
        private void frmConnection_Load(object sender, EventArgs e)
        {
            // Check to see if there is any data in the application settings, if so populate fields
            string host = Properties.Settings.Default.Host;
            string port = Properties.Settings.Default.Port;
            string apiKey = Properties.Settings.Default.ApiKey;

            if (host != null)
            {
                txtHost.Text = host;
            }

            if (port != null)
            {
                txtPort.Text = port;
            }

            if (apiKey != null)
            {
                txtApiKey.Text = apiKey;
            }

            // check to see if there is currently a connection active to the remote server
            if (csSettings.connectionActive == 1)
            {
                // there is currently an active connection to the remote server so we cannot allow a new connection to be added
                btnConnect.Enabled = false;
                lblConnectionStatus.Text = "Please disconnect from the remote server first!";
                txtHost.Enabled = false;
                txtPort.Enabled = false;
                txtApiKey.Enabled = false;
            } else
            {
                // there is currently no connection to the remote server
                btnConnect.Enabled = true;
                lblConnectionStatus.Text = null;
                txtHost.Enabled = true;
                txtPort.Enabled = true;
                txtApiKey.Enabled = true;
            }
        }

        #endregion

        #region Octoprint Website documentation
        private void linkApiKey_Click(object sender, EventArgs e)
        {
            // Open octoprint documentation site & access api authentication procedures
            System.Diagnostics.Process.Start("https://docs.octoprint.org/en/master/api/general.html#authorization");
        }

        #endregion

        #region Connection Submit

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Disable submit button
            btnConnect.Enabled = false;

            // Check to see if txtPort is filled
            if (txtPort.Text != null || txtPort.Text == "")
            {
                // Push string output to class
                csSettings.ConnectionPort = txtPort.Text.ToString();
            }
            else
            {
                csSettings.ConnectionPort = "";
            }

            // Apply addtional data to class
            csSettings.connectionAddress = txtHost.Text;
            csSettings.connectionAuthToken = txtApiKey.Text;

            // Update connection label with begin connection
            lblConnectionStatus.Appearance.ForeColor = Color.Orange;
            lblConnectionStatus.Text = "Establishing connection...";

            // Start the connection test transaction
            tmrConnect.Enabled = true;
            tmrConnect.Start();
        }

        #endregion

        #region Connection Listener

        private void beginConnectionTransaction()
        {
            try
            {
                string portCheck = null;
                if (csSettings.ConnectionPort != null)
                {
                    portCheck = ":" + csSettings.ConnectionPort;
                }
                else
                {
                    portCheck = null;
                }

                // Transmission Data (POST / GET)
                string authServer = csSettings.connectionAddress + portCheck + "/api/files";

                // Create request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(authServer); request.KeepAlive = false;
                request.Headers.Add("Authorization", "Bearer " + csSettings.connectionAuthToken);
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "GET";
                request.Accept = "application/json";

                // Await response from remote server
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var test = new StreamReader(response.GetResponseStream()).ReadToEnd();


                // Close remote connection
                response.Close();

                // Update connection label with confirmation
                lblConnectionStatus.Appearance.ForeColor = Color.DarkGreen;
                lblConnectionStatus.Text = "Connection established";

                // Re-enable submit button
                btnConnect.Enabled = true;

                // Save connection information into application settings
                Properties.Settings.Default.Host = csSettings.connectionAddress;
                Properties.Settings.Default.Port = csSettings.ConnectionPort;
                Properties.Settings.Default.ApiKey = csSettings.connectionAuthToken;
                Properties.Settings.Default.Save();

                // Update connection state
                csSettings.updateDataSignal = 1;
            }
            catch (Exception ex)
            {
                // Update connection label with failure
                lblConnectionStatus.Appearance.ForeColor = Color.Red;
                lblConnectionStatus.Text = "Connection failure";

                // Re-enable submit button
                btnConnect.Enabled = true;

                // Display error messagebox
                MessageBox.Show(ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void tmrConnect_Tick(object sender, EventArgs e)
        {
            // stop timer and disable it
            tmrConnect.Stop();
            tmrConnect.Enabled = false;

            // connect to server
            beginConnectionTransaction();
        }

        private void linkResetConnectionData_Click(object sender, EventArgs e)
        {
            // Reset all connection data
            Properties.Settings.Default.Host = "";
            Properties.Settings.Default.Port = "";
            Properties.Settings.Default.ApiKey = "";
            Properties.Settings.Default.DisplayLayerProgress = 0;
            Properties.Settings.Default.Save();

            // Reset text boxes
            txtHost.Text = null;
            txtPort.Text = null;
            txtApiKey.Text = null;

            // uppdate connection state
            csSettings.updateDataSignal = 3;
        }
    }
}
