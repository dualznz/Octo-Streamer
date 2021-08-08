
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
            this.pnlMainDisplay = new System.Windows.Forms.Panel();
            this.pnlActivePrint = new System.Windows.Forms.Panel();
            this.lblBedTarget = new DevExpress.XtraEditors.LabelControl();
            this.lblBedActual = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblToolTarget = new DevExpress.XtraEditors.LabelControl();
            this.lblToolActual = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblTimeLeft = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblTimeElapsed = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblDateStartedValue = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCompletedValue = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblCurrentFileName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.rtbPrinterStatus = new System.Windows.Forms.RichTextBox();
            this.tmrApi = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlMainDisplay.SuspendLayout();
            this.pnlActivePrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrHandshake
            // 
            this.tmrHandshake.Interval = 3000;
            this.tmrHandshake.Tick += new System.EventHandler(this.tmrHandshake_Tick);
            // 
            // tmrLifeline
            // 
            this.tmrLifeline.Interval = 30000;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(421, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnFlash
            // 
            this.btnFlash.Location = new System.Drawing.Point(1014, 333);
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
            this.tmrUpdateConnectionData.Interval = 1000;
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
            this.toolStrip1.Size = new System.Drawing.Size(421, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsFile
            // 
            this.tsFile.AutoToolTip = false;
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
            this.tsExitApplication.Size = new System.Drawing.Size(180, 22);
            this.tsExitApplication.Text = "Exit";
            this.tsExitApplication.Click += new System.EventHandler(this.tsExitApplication_Click);
            // 
            // tsTools
            // 
            this.tsTools.AutoToolTip = false;
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
            this.connectionSettingsToolStripMenuItem.Click += new System.EventHandler(this.connectionSettingsToolStripMenuItem_Click);
            // 
            // applicationSettingsToolStripMenuItem
            // 
            this.applicationSettingsToolStripMenuItem.Name = "applicationSettingsToolStripMenuItem";
            this.applicationSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.applicationSettingsToolStripMenuItem.Text = "Application Settings";
            // 
            // tsHelp
            // 
            this.tsHelp.AutoToolTip = false;
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
            this.labelControl1.Location = new System.Drawing.Point(290, 402);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Developed By:";
            // 
            // linkDualznzGithub
            // 
            this.linkDualznzGithub.Location = new System.Drawing.Point(366, 402);
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
            this.lblPrinterStatusValue.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lblPrinterStatusValue.Appearance.Options.UseFont = true;
            this.lblPrinterStatusValue.Location = new System.Drawing.Point(85, 15);
            this.lblPrinterStatusValue.Name = "lblPrinterStatusValue";
            this.lblPrinterStatusValue.Size = new System.Drawing.Size(120, 13);
            this.lblPrinterStatusValue.TabIndex = 6;
            this.lblPrinterStatusValue.Text = "lblPrinterStatusValue";
            // 
            // pnlMainDisplay
            // 
            this.pnlMainDisplay.Controls.Add(this.pnlActivePrint);
            this.pnlMainDisplay.Controls.Add(this.lblPrinterStatusTitle);
            this.pnlMainDisplay.Controls.Add(this.lblPrinterStatusValue);
            this.pnlMainDisplay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainDisplay.Location = new System.Drawing.Point(12, 98);
            this.pnlMainDisplay.Name = "pnlMainDisplay";
            this.pnlMainDisplay.Size = new System.Drawing.Size(392, 298);
            this.pnlMainDisplay.TabIndex = 10;
            this.pnlMainDisplay.Visible = false;
            // 
            // pnlActivePrint
            // 
            this.pnlActivePrint.Controls.Add(this.lblBedTarget);
            this.pnlActivePrint.Controls.Add(this.labelControl8);
            this.pnlActivePrint.Controls.Add(this.lblTimeLeft);
            this.pnlActivePrint.Controls.Add(this.lblBedActual);
            this.pnlActivePrint.Controls.Add(this.labelControl7);
            this.pnlActivePrint.Controls.Add(this.lblTimeElapsed);
            this.pnlActivePrint.Controls.Add(this.labelControl13);
            this.pnlActivePrint.Controls.Add(this.labelControl6);
            this.pnlActivePrint.Controls.Add(this.lblDateStartedValue);
            this.pnlActivePrint.Controls.Add(this.separatorControl5);
            this.pnlActivePrint.Controls.Add(this.labelControl3);
            this.pnlActivePrint.Controls.Add(this.lblCompletedValue);
            this.pnlActivePrint.Controls.Add(this.lblToolTarget);
            this.pnlActivePrint.Controls.Add(this.labelControl2);
            this.pnlActivePrint.Controls.Add(this.lblCurrentFileName);
            this.pnlActivePrint.Controls.Add(this.lblToolActual);
            this.pnlActivePrint.Controls.Add(this.labelControl5);
            this.pnlActivePrint.Controls.Add(this.separatorControl2);
            this.pnlActivePrint.Controls.Add(this.labelControl10);
            this.pnlActivePrint.Controls.Add(this.labelControl4);
            this.pnlActivePrint.Controls.Add(this.separatorControl1);
            this.pnlActivePrint.Controls.Add(this.separatorControl4);
            this.pnlActivePrint.Controls.Add(this.labelControl9);
            this.pnlActivePrint.Controls.Add(this.separatorControl3);
            this.pnlActivePrint.Location = new System.Drawing.Point(3, 36);
            this.pnlActivePrint.Name = "pnlActivePrint";
            this.pnlActivePrint.Size = new System.Drawing.Size(386, 254);
            this.pnlActivePrint.TabIndex = 13;
            // 
            // lblBedTarget
            // 
            this.lblBedTarget.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBedTarget.Appearance.Options.UseFont = true;
            this.lblBedTarget.Location = new System.Drawing.Point(215, 156);
            this.lblBedTarget.Name = "lblBedTarget";
            this.lblBedTarget.Size = new System.Drawing.Size(72, 13);
            this.lblBedTarget.TabIndex = 34;
            this.lblBedTarget.Text = "lblBedTarget";
            // 
            // lblBedActual
            // 
            this.lblBedActual.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBedActual.Appearance.Options.UseFont = true;
            this.lblBedActual.Location = new System.Drawing.Point(215, 140);
            this.lblBedActual.Name = "lblBedActual";
            this.lblBedActual.Size = new System.Drawing.Size(70, 13);
            this.lblBedActual.TabIndex = 33;
            this.lblBedActual.Text = "lblBedActual";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(215, 111);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(21, 14);
            this.labelControl13.TabIndex = 31;
            this.labelControl13.Text = "Bed";
            // 
            // separatorControl5
            // 
            this.separatorControl5.BackColor = System.Drawing.SystemColors.Control;
            this.separatorControl5.LineColor = System.Drawing.Color.Gold;
            this.separatorControl5.Location = new System.Drawing.Point(205, 117);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(153, 28);
            this.separatorControl5.TabIndex = 32;
            // 
            // lblToolTarget
            // 
            this.lblToolTarget.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblToolTarget.Appearance.Options.UseFont = true;
            this.lblToolTarget.Location = new System.Drawing.Point(10, 156);
            this.lblToolTarget.Name = "lblToolTarget";
            this.lblToolTarget.Size = new System.Drawing.Size(75, 13);
            this.lblToolTarget.TabIndex = 30;
            this.lblToolTarget.Text = "lblToolTarget";
            // 
            // lblToolActual
            // 
            this.lblToolActual.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblToolActual.Appearance.Options.UseFont = true;
            this.lblToolActual.Location = new System.Drawing.Point(10, 140);
            this.lblToolActual.Name = "lblToolActual";
            this.lblToolActual.Size = new System.Drawing.Size(73, 13);
            this.lblToolActual.TabIndex = 29;
            this.lblToolActual.Text = "lblToolActual";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(10, 111);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 14);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "Hotend";
            // 
            // separatorControl4
            // 
            this.separatorControl4.BackColor = System.Drawing.SystemColors.Control;
            this.separatorControl4.LineColor = System.Drawing.Color.Gold;
            this.separatorControl4.Location = new System.Drawing.Point(0, 117);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(153, 28);
            this.separatorControl4.TabIndex = 28;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(10, 80);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 16);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "Printer";
            // 
            // separatorControl3
            // 
            this.separatorControl3.BackColor = System.Drawing.SystemColors.Control;
            this.separatorControl3.LineColor = System.Drawing.Color.Gold;
            this.separatorControl3.Location = new System.Drawing.Point(0, 85);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(362, 28);
            this.separatorControl3.TabIndex = 26;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(176, 229);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(23, 13);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Left:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeLeft.Appearance.Options.UseFont = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(205, 229);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(63, 13);
            this.lblTimeLeft.TabIndex = 24;
            this.lblTimeLeft.Text = "lblTimeLeft";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 229);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Elapsed:";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeElapsed.Appearance.Options.UseFont = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(56, 229);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(84, 13);
            this.lblTimeElapsed.TabIndex = 22;
            this.lblTimeElapsed.Text = "lblTimeElapsed";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Date Started:";
            // 
            // lblDateStartedValue
            // 
            this.lblDateStartedValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDateStartedValue.Appearance.Options.UseFont = true;
            this.lblDateStartedValue.Location = new System.Drawing.Point(82, 56);
            this.lblDateStartedValue.Name = "lblDateStartedValue";
            this.lblDateStartedValue.Size = new System.Drawing.Size(114, 13);
            this.lblDateStartedValue.TabIndex = 20;
            this.lblDateStartedValue.Text = "lblDateStartedValue";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 210);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Completed:";
            // 
            // lblCompletedValue
            // 
            this.lblCompletedValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCompletedValue.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCompletedValue.Appearance.Options.UseFont = true;
            this.lblCompletedValue.Appearance.Options.UseForeColor = true;
            this.lblCompletedValue.Location = new System.Drawing.Point(71, 210);
            this.lblCompletedValue.Name = "lblCompletedValue";
            this.lblCompletedValue.Size = new System.Drawing.Size(105, 13);
            this.lblCompletedValue.TabIndex = 10;
            this.lblCompletedValue.Text = "lblCompletedValue";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "File:";
            // 
            // lblCurrentFileName
            // 
            this.lblCurrentFileName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCurrentFileName.Appearance.Options.UseFont = true;
            this.lblCurrentFileName.Location = new System.Drawing.Point(36, 37);
            this.lblCurrentFileName.Name = "lblCurrentFileName";
            this.lblCurrentFileName.Size = new System.Drawing.Size(107, 13);
            this.lblCurrentFileName.TabIndex = 8;
            this.lblCurrentFileName.Text = "lblCurrentFileName";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 7);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 16);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Info";
            // 
            // separatorControl2
            // 
            this.separatorControl2.BackColor = System.Drawing.SystemColors.Control;
            this.separatorControl2.LineColor = System.Drawing.Color.Gold;
            this.separatorControl2.Location = new System.Drawing.Point(0, 12);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(362, 28);
            this.separatorControl2.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 182);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 16);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Progress";
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.SystemColors.Control;
            this.separatorControl1.LineColor = System.Drawing.Color.Gold;
            this.separatorControl1.Location = new System.Drawing.Point(-1, 187);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(362, 28);
            this.separatorControl1.TabIndex = 16;
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
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 69);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect To Server";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 444);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtbPrinterStatus);
            this.Controls.Add(this.pnlMainDisplay);
            this.Controls.Add(this.linkDualznzGithub);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlMainDisplay.ResumeLayout(false);
            this.pnlMainDisplay.PerformLayout();
            this.pnlActivePrint.ResumeLayout(false);
            this.pnlActivePrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
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
        private System.Windows.Forms.Panel pnlMainDisplay;
        private System.Windows.Forms.RichTextBox rtbPrinterStatus;
        private System.Windows.Forms.Timer tmrApi;
        private System.Windows.Forms.Panel pnlActivePrint;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblCurrentFileName;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblCompletedValue;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblDateStartedValue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblTimeElapsed;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblTimeLeft;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.LabelControl lblToolActual;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.LabelControl lblToolTarget;
        private DevExpress.XtraEditors.LabelControl lblBedTarget;
        private DevExpress.XtraEditors.LabelControl lblBedActual;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
    }
}

