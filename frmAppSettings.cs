using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octo_Streamer
{
    public partial class frmAppSettings : Form
    {
        public frmAppSettings()
        {
            InitializeComponent();
        }

        private void frmAppSettings_Load(object sender, EventArgs e)
        {
            // check to see if there is currently a connection active to the remote server
            if (csSettings.connectionActive == 1)
            {
                // there is currently an active connection to the remote server so we cannot allow changes to be made
                groupApplicationAddons.Text = "Application Addons (please disconnect from server first!)";
                groupApplicationAddons.Enabled = false;
            }
            else
            {
                // there is currently no connection to the remote server
                groupApplicationAddons.Text = "Application Addons";
                groupApplicationAddons.Enabled = true;
            }

            // Check if displayLayerProgress is enabled in application settings
            if (Properties.Settings.Default.DisplayLayerProgress == 1)
            {
                chkDisplayLayerProgress.Checked = true;
            }
            else
            {
                chkDisplayLayerProgress.Checked = false;
            }

        }

        private void lblDisplayLayerProgressLink_Click(object sender, EventArgs e)
        {
            // Open octoprint plugin repository and navigate to DisplayLayerProgress plugin
            System.Diagnostics.Process.Start("https://plugins.octoprint.org/plugins/DisplayLayerProgress/");
        }

        private void btnUpdateDisplayLayerProgress_Click(object sender, EventArgs e)
        {
            if (chkDisplayLayerProgress.Checked == true)
            {
                Properties.Settings.Default.DisplayLayerProgress = 1;
                csSettings.displayLayerProgress = 1;
            }
            else
            {
                Properties.Settings.Default.DisplayLayerProgress = 0;
                csSettings.displayLayerProgress = 0;
            }

            Properties.Settings.Default.Save();

            // Update connection state
            csSettings.updateDataSignal = 2;
        }
    }
}
