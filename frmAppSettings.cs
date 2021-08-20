using Microsoft.Win32;
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

        #region Form Load
        private void frmAppSettings_Load(object sender, EventArgs e)
        {
            #region Application addons

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
            if (csSettings.displayLayerProgress == 1)
            {
                // Setting is enabled, check the box
                chkDisplayLayerProgress.Checked = true;
            }
            else
            {
                // Setting is disabled, dont check the box
                chkDisplayLayerProgress.Checked = false;
            }

            #endregion

            #region Stream Settings

            // Check if toolTempTarget is enabled in application settings
            if (csSettings.toolTempTargetSwitch == 1)
            {
                // Setting is enabled, check the box
                chkToolTempTarget.Checked = true;
            }
            else
            {
                // Setting is disabled, dont check the box
                chkToolTempTarget.Checked = false;
            }

            // Check if bedTempTarget is enabled in application settings
            if (csSettings.bedTempTargetSwitch == 1)
            {
                // Setting is enabled, check the box
                chkBedTempTarget.Checked = true;
            }
            else
            {
                // Setting is disabled, dont check the box
                chkBedTempTarget.Checked = false;
            }

            #endregion

        }
        #endregion

        #region DisplayLayerProgress Plugin Link
        private void lblDisplayLayerProgressLink_Click(object sender, EventArgs e)
        {
            // Open octoprint plugin repository and navigate to DisplayLayerProgress plugin
            System.Diagnostics.Process.Start("https://plugins.octoprint.org/plugins/DisplayLayerProgress/");
        }
        #endregion

        #region Update Addons
        private void btnUpdateAddons_Click(object sender, EventArgs e)
        {
            // Define registry scope
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Octo-Streamer", true);

            // Check to see if registry folder exists in the context
            if (key != null)
            {
                // Check to see if displayLayerProgress checkbox has been checked
                if (chkDisplayLayerProgress.Checked == true)
                {
                    // Checkbox is checked, store setting
                    csSettings.displayLayerProgress = 1;
                    key.SetValue("displayLayerProgress", "1");
                }
                else
                {
                    // Checkbox is not checked, store setting
                    csSettings.displayLayerProgress = 0;
                    key.SetValue("displayLayerProgress", "0");
                }

                // Close key
                key.Close();
                
            }

            // Update connection state
            csSettings.updateDataSignal = 2;

            // Show saved tag and start delay
            lblUpdatedAddons.Visible = true;
            btnUpdateAddons.Enabled = false;
            tmrSaveApplicationAddons.Enabled = true;
            tmrSaveApplicationAddons.Start();
        }

        private void tmrSaveApplicationAddons_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            tmrSaveApplicationAddons.Stop();
            tmrSaveApplicationAddons.Enabled = false;

            // Hide saved tag
            lblUpdatedAddons.Visible = false;

            // Enable update button
            btnUpdateAddons.Enabled = true;
        }
        #endregion

        #region Update Stream Settings
        private void btnUpdateStreamSettings_Click(object sender, EventArgs e)
        {
            // Define registry scope
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Octo-Streamer", true);

            // Check to see if registry folder exists in the context
            if (key != null)
            {
                // Check to see if ToolTempTarget checkbox has been checked
                if (chkToolTempTarget.Checked == true)
                {
                    // Checkbox is checked, store setting
                    csSettings.toolTempTargetSwitch = 1;
                    key.SetValue("toolTempTarget", "1");
                }
                else
                {
                    // Checkbox is not checked, store setting
                    csSettings.toolTempTargetSwitch = 0;
                    key.SetValue("toolTempTarget", "0");
                }

                // Check to see if BedTempTarget checkbox has been checked
                if (chkBedTempTarget.Checked == true)
                {
                    // Checkbox is checked, store setting
                    csSettings.bedTempTargetSwitch = 1;
                    key.SetValue("bedTempTarget", "1");
                }
                else
                {
                    // Checkbox is not checked, store setting
                    csSettings.bedTempTargetSwitch = 0;
                    key.SetValue("bedTempTarget", "0");
                }

                // Close key
                key.Close();
            }

            // Show saved tag and start delay
            lblUpdatedStreamSettings.Visible = true;
            btnUpdateStreamSettings.Enabled = false;
            tmrSaveStreamSettings.Enabled = true;
            tmrSaveStreamSettings.Start();
        }

        private void tmrSaveStreamSettings_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            tmrSaveStreamSettings.Stop();
            tmrSaveStreamSettings.Enabled = false;

            // Hide saved tag
            lblUpdatedStreamSettings.Visible = false;

            // Enable update button
            btnUpdateStreamSettings.Enabled = true;
        }

        #endregion

        #region Open Stream Directory

        private void btnOpenStreamDirectory_Click(object sender, EventArgs e)
        {
            // Open stream directory
            System.Diagnostics.Process.Start(Application.StartupPath + "/stream");
        }

        #endregion

        #region Stream Setup Guide

        private void linkStreamSetupGuide_Click(object sender, EventArgs e)
        {
            // Navigate to github wiki for setting up stream
            System.Diagnostics.Process.Start("https://github.com/dualznz/Octo-Streamer");
        }

        #endregion

        #region Camera Feed

        private void btnCameraStream_Click(object sender, EventArgs e)
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

            // Open camera stream (OctoPrint)
            System.Diagnostics.Process.Start(csSettings.connectionAddress + portCheck + "/webcam/?action=stream");

        }

        #endregion

    }
}
