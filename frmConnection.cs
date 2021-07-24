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

        private void frmConnection_Load(object sender, EventArgs e)
        {
            
        }

        private void linkApiKey_Click(object sender, EventArgs e)
        {
            // Open octoprint documentation site & access api authentication procedures
            System.Diagnostics.Process.Start("https://docs.octoprint.org/en/master/api/general.html#authorization");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // check to see if txtPort is filled
            if (txtPort.Text != null || txtPort.Text == "")
            {
                // push string output to class
                csSettings.ConnectionPort = ":" + txtPort.Text.ToString();
            } else
            {
                csSettings.ConnectionPort = "";
            }

            csSettings.connectionAddress = txtHost.Text;
            csSettings.connectionAuthToken = txtApiKey.Text;

            // start the connection test transaction
            beginConnectionTransaction();
        }


        #region Connection Listener

        private void beginConnectionTransaction()
        {
            try
            {
                // Transmission Data (POST / GET)
                string postData = "";
                string authServer = csSettings.connectionAddress + csSettings.ConnectionPort + "/api/files";

                // Create request
                HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(authServer); request.KeepAlive = false;
                request.Headers.Add("Authorization", "Bearer " + csSettings.connectionAuthToken);
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "GET";
                request.Accept = "application/json";

                // await response from remote server
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var test = new StreamReader(response.GetResponseStream()).ReadToEnd();

                // test response
                MessageBox.Show(test);


                // close connections
                response.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to server");
            }
        }

        #endregion

        
    }
}
