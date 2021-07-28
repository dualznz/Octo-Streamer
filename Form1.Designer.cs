
namespace Octo_Streamer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrHandshake = new System.Windows.Forms.Timer(this.components);
            this.tmrLifeline = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLblConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnFlash = new System.Windows.Forms.Button();
            this.tmrUpdateConnectionData = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.githubHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubIssuesRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.linkDualznzGithub = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblPrinterStatusTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblPrinterStatusValue = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbPrinterStatus = new System.Windows.Forms.RichTextBox();
            this.tmrApi = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHandshake
            // 
            this.tmrHandshake.Interval = 3000;
            this.tmrHandshake.Tick += new System.EventHandler(this.tmrHandshake_Tick);
            // 
            // tmrLifeline
            // 
            this.tmrLifeline.Interval = 60000;
            this.tmrLifeline.Tick += new System.EventHandler(this.tmrLifeline_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripLblConnectionStatus
            // 
            this.toolStripLblConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLblConnectionStatus.Name = "toolStripLblConnectionStatus";
            this.toolStripLblConnectionStatus.Size = new System.Drawing.Size(111, 17);
            this.toolStripLblConnectionStatus.Text = "Connection Status:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolServerStatus
            // 
            this.toolServerStatus.Name = "toolServerStatus";
            this.toolServerStatus.Size = new System.Drawing.Size(118, 17);
            this.toolServerStatus.Text = "toolStripStatusLabel3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripLblConnectionStatus,
            this.toolStripStatusLabel2,
            this.toolServerStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1044, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnFlash
            // 
            this.btnFlash.Location = new System.Drawing.Point(494, 28);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(18, 21);
            this.btnFlash.TabIndex = 1;
            this.btnFlash.Text = "button1";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // tmrUpdateConnectionData
            // 
            this.tmrUpdateConnectionData.Enabled = true;
            this.tmrUpdateConnectionData.Interval = 500;
            this.tmrUpdateConnectionData.Tick += new System.EventHandler(this.tmrUpdateConnectionData_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsTools,
            this.tsHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExitApplication});
            this.tsFile.Image = ((System.Drawing.Image)(resources.GetObject("tsFile.Image")));
            this.tsFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(38, 22);
            this.tsFile.Text = "File";
            // 
            // tsExitApplication
            // 
            this.tsExitApplication.Name = "tsExitApplication";
            this.tsExitApplication.Size = new System.Drawing.Size(93, 22);
            this.tsExitApplication.Text = "Exit";
            this.tsExitApplication.Click += new System.EventHandler(this.tsExitApplication_Click);
            // 
            // tsTools
            // 
            this.tsTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionSettingsToolStripMenuItem,
            this.applicationSettingsToolStripMenuItem});
            this.tsTools.Image = ((System.Drawing.Image)(resources.GetObject("tsTools.Image")));
            this.tsTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(47, 22);
            this.tsTools.Text = "Tools";
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.connectionSettingsToolStripMenuItem.Text = "Connection Settings";
            // 
            // applicationSettingsToolStripMenuItem
            // 
            this.applicationSettingsToolStripMenuItem.Name = "applicationSettingsToolStripMenuItem";
            this.applicationSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.applicationSettingsToolStripMenuItem.Text = "Application Settings";
            // 
            // tsHelp
            // 
            this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubHomepageToolStripMenuItem,
            this.githubIssuesRequestsToolStripMenuItem});
            this.tsHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsHelp.Image")));
            this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(45, 22);
            this.tsHelp.Text = "Help";
            // 
            // githubHomepageToolStripMenuItem
            // 
            this.githubHomepageToolStripMenuItem.Name = "githubHomepageToolStripMenuItem";
            this.githubHomepageToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.githubHomepageToolStripMenuItem.Text = "Github Homepage";
            // 
            // githubIssuesRequestsToolStripMenuItem
            // 
            this.githubIssuesRequestsToolStripMenuItem.Name = "githubIssuesRequestsToolStripMenuItem";
            this.githubIssuesRequestsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.githubIssuesRequestsToolStripMenuItem.Text = "Github Issues / Requests";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(376, 221);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Developed By:";
            // 
            // linkDualznzGithub
            // 
            this.linkDualznzGithub.Location = new System.Drawing.Point(452, 221);
            this.linkDualznzGithub.Name = "linkDualznzGithub";
            this.linkDualznzGithub.Size = new System.Drawing.Size(37, 13);
            this.linkDualznzGithub.TabIndex = 4;
            this.linkDualznzGithub.Text = "Dualznz";
            this.linkDualznzGithub.Click += new System.EventHandler(this.linkDualznzGithub_Click);
            // 
            // lblPrinterStatusTitle
            // 
            this.lblPrinterStatusTitle.Location = new System.Drawing.Point(9, 15);
            this.lblPrinterStatusTitle.Name = "lblPrinterStatusTitle";
            this.lblPrinterStatusTitle.Size = new System.Drawing.Size(70, 13);
            this.lblPrinterStatusTitle.TabIndex = 5;
            this.lblPrinterStatusTitle.Text = "Printer Status:";
            // 
            // lblPrinterStatusValue
            // 
            this.lblPrinterStatusValue.Location = new System.Drawing.Point(85, 15);
            this.lblPrinterStatusValue.Name = "lblPrinterStatusValue";
            this.lblPrinterStatusValue.Size = new System.Drawing.Size(99, 13);
            this.lblPrinterStatusValue.TabIndex = 6;
            this.lblPrinterStatusValue.Text = "lblPrinterStatusValue";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrinterStatusTitle);
            this.panel1.Controls.Add(this.lblPrinterStatusValue);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 149);
            this.panel1.TabIndex = 10;
            // 
            // rtbPrinterStatus
            // 
            this.rtbPrinterStatus.Location = new System.Drawing.Point(518, 28);
            this.rtbPrinterStatus.Name = "rtbPrinterStatus";
            this.rtbPrinterStatus.Size = new System.Drawing.Size(514, 299);
            this.rtbPrinterStatus.TabIndex = 12;
            this.rtbPrinterStatus.TabStop = false;
            this.rtbPrinterStatus.Text = "";
            // 
            // tmrApi
            // 
            this.tmrApi.Interval = 1000;
            this.tmrApi.Tick += new System.EventHandler(this.tmrApi_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 365);
            this.Controls.Add(this.rtbPrinterStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkDualznzGithub);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrHandshake;
        private System.Windows.Forms.Timer tmrLifeline;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolServerStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.Timer tmrUpdateConnectionData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsExitApplication;
        private System.Windows.Forms.ToolStripDropDownButton tsTools;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsHelp;
        private System.Windows.Forms.ToolStripMenuItem githubHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubIssuesRequestsToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkDualznzGithub;
        private DevExpress.XtraEditors.LabelControl lblPrinterStatusTitle;
        private DevExpress.XtraEditors.LabelControl lblPrinterStatusValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbPrinterStatus;
        private System.Windows.Forms.Timer tmrApi;
    }
}

