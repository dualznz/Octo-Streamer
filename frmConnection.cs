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
using Microsoft.Win32;

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
            // Define host registry folder

            if (csSettings.connectionAddress != null)
            {
                txtHost.Text = csSettings.connectionAddress;
            }

            if (csSettings.connectionPort != null)
            {
                txtPort.Text = csSettings.connectionPort;
            }

            if (csSettings.connectionAuthToken != null)
            {
                txtApiKey.Text = csSettings.connectionAuthToken;
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
                csSettings.connectionPort = txtPort.Text.ToString();
            }
            else
            {
                csSettings.connectionPort = "";
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
                if (csSettings.connectionPort != null)
                {
                    portCheck = ":" + csSettings.connectionPort;
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

                // Update connection state
                csSettings.updateDataSignal = 1;

                // Store connection in the registry
                registryDep();
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

        #region Connect to server
        private void tmrConnect_Tick(object sender, EventArgs e)
        {
            // stop timer and disable it
            tmrConnect.Stop();
            tmrConnect.Enabled = false;

            // connect to server
            beginConnectionTransaction();
        }
        #endregion

        #region Reset all connection / application perameters

        private void linkResetConnectionData_Click(object sender, EventArgs e)
        {
            // Reset all connection data
            // Define host registry folder
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Octo-Streamer", true);

            // Check to see if the host regisrtry folder exists, if not create it
            if (key != null)
            {
                RegistryKey newKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Octo-Streamer");
                newKey.SetValue("host", "");
                newKey.SetValue("port", "");
                newKey.SetValue("apiKey", "");
                newKey.SetValue("displayLayerProgress", "0");
                newKey.SetValue("toolTempTarget", "0");
                newKey.SetValue("bedTempTarget", "0");
                newKey.Close();
            }

            // Reset text boxes
            txtHost.Text = null;
            txtPort.Text = null;
            txtApiKey.Text = null;

            // uppdate connection state
            csSettings.updateDataSignal = 3;
        }

        #endregion

        #region Registry Dependencies

        public static void registryDep()
        {
            // Define host registry folder
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Octo-Streamer", true);

            // Check to see if the host regisrtry folder exists, if not create it
            if (key == null)
            {
                RegistryKey newKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Octo-Streamer");
                newKey.SetValue("host", csSettings.connectionAddress);
                newKey.SetValue("port", csSettings.connectionPort);
                newKey.SetValue("apiKey", csSettings.connectionAuthToken);
                newKey.SetValue("displayLayerProgress", "0");
                newKey.SetValue("toolTempTarget", "0");
                newKey.SetValue("bedTempTarget", "0");
                newKey.Close();
            }
        }
        #endregion

    }
}
