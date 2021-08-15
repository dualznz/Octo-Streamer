
namespace Octo_Streamer
{
    partial class frmAppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppSettings));
            this.groupApplicationAddons = new DevExpress.XtraEditors.GroupControl();
            this.lblUpdatedAddons = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdateAddons = new DevExpress.XtraEditors.SimpleButton();
            this.chkDisplayLayerProgress = new System.Windows.Forms.CheckBox();
            this.lblDisplayLayerProgressLink = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblUpdatedStreamSettings = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdateStreamSettings = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkBedTempTarget = new System.Windows.Forms.CheckBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.chkToolTempTarget = new System.Windows.Forms.CheckBox();
            this.tmrSaveApplicationAddons = new System.Windows.Forms.Timer(this.components);
            this.tmrSaveStreamSettings = new System.Windows.Forms.Timer(this.components);
            this.btnOpenStreamDirectory = new DevExpress.XtraEditors.SimpleButton();
            this.linkStreamSetupGuide = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupApplicationAddons)).BeginInit();
            this.groupApplicationAddons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupApplicationAddons
            // 
            this.groupApplicationAddons.Controls.Add(this.lblUpdatedAddons);
            this.groupApplicationAddons.Controls.Add(this.btnUpdateAddons);
            this.groupApplicationAddons.Controls.Add(this.chkDisplayLayerProgress);
            this.groupApplicationAddons.Controls.Add(this.lblDisplayLayerProgressLink);
            this.groupApplicationAddons.Location = new System.Drawing.Point(31, 38);
            this.groupApplicationAddons.Name = "groupApplicationAddons";
            this.groupApplicationAddons.Size = new System.Drawing.Size(348, 133);
            this.groupApplicationAddons.TabIndex = 0;
            this.groupApplicationAddons.Text = "Application Addons";
            // 
            // lblUpdatedAddons
            // 
            this.lblUpdatedAddons.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUpdatedAddons.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.lblUpdatedAddons.Appearance.Options.UseFont = true;
            this.lblUpdatedAddons.Appearance.Options.UseForeColor = true;
            this.lblUpdatedAddons.Location = new System.Drawing.Point(294, 5);
            this.lblUpdatedAddons.Name = "lblUpdatedAddons";
            this.lblUpdatedAddons.Size = new System.Drawing.Size(45, 13);
            this.lblUpdatedAddons.TabIndex = 13;
            this.lblUpdatedAddons.Text = "Updated";
            this.lblUpdatedAddons.Visible = false;
            // 
            // btnUpdateAddons
            // 
            this.btnUpdateAddons.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAddons.ImageOptions.Image")));
            this.btnUpdateAddons.Location = new System.Drawing.Point(243, 89);
            this.btnUpdateAddons.Name = "btnUpdateAddons";
            this.btnUpdateAddons.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateAddons.TabIndex = 12;
            this.btnUpdateAddons.Text = "Update";
            this.btnUpdateAddons.Click += new System.EventHandler(this.btnUpdateAddons_Click);
            // 
            // chkDisplayLayerProgress
            // 
            this.chkDisplayLayerProgress.AutoSize = true;
            this.chkDisplayLayerProgress.Location = new System.Drawing.Point(40, 37);
            this.chkDisplayLayerProgress.Name = "chkDisplayLayerProgress";
            this.chkDisplayLayerProgress.Size = new System.Drawing.Size(171, 17);
            this.chkDisplayLayerProgress.TabIndex = 9;
            this.chkDisplayLayerProgress.Text = "DisplayLayerProgress Addon";
            this.chkDisplayLayerProgress.UseVisualStyleBackColor = true;
            // 
            // lblDisplayLayerProgressLink
            // 
            this.lblDisplayLayerProgressLink.Location = new System.Drawing.Point(42, 65);
            this.lblDisplayLayerProgressLink.Name = "lblDisplayLayerProgressLink";
            this.lblDisplayLayerProgressLink.Size = new System.Drawing.Size(251, 13);
            this.lblDisplayLayerProgressLink.TabIndex = 8;
            this.lblDisplayLayerProgressLink.Text = "Requires DisplayLayerProgress plugin on server...";
            this.lblDisplayLayerProgressLink.Click += new System.EventHandler(this.lblDisplayLayerProgressLink_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.linkStreamSetupGuide);
            this.groupControl2.Controls.Add(this.btnOpenStreamDirectory);
            this.groupControl2.Controls.Add(this.lblUpdatedStreamSettings);
            this.groupControl2.Controls.Add(this.btnUpdateStreamSettings);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.chkBedTempTarget);
            this.groupControl2.Controls.Add(this.separatorControl1);
            this.groupControl2.Controls.Add(this.chkToolTempTarget);
            this.groupControl2.Location = new System.Drawing.Point(31, 209);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(348, 141);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Stream Settings";
            // 
            // lblUpdatedStreamSettings
            // 
            this.lblUpdatedStreamSettings.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUpdatedStreamSettings.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.lblUpdatedStreamSettings.Appearance.Options.UseFont = true;
            this.lblUpdatedStreamSettings.Appearance.Options.UseForeColor = true;
            this.lblUpdatedStreamSettings.Location = new System.Drawing.Point(294, 5);
            this.lblUpdatedStreamSettings.Name = "lblUpdatedStreamSettings";
            this.lblUpdatedStreamSettings.Size = new System.Drawing.Size(45, 13);
            this.lblUpdatedStreamSettings.TabIndex = 14;
            this.lblUpdatedStreamSettings.Text = "Updated";
            this.lblUpdatedStreamSettings.Visible = false;
            // 
            // btnUpdateStreamSettings
            // 
            this.btnUpdateStreamSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStreamSettings.ImageOptions.Image")));
            this.btnUpdateStreamSettings.Location = new System.Drawing.Point(239, 86);
            this.btnUpdateStreamSettings.Name = "btnUpdateStreamSettings";
            this.btnUpdateStreamSettings.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateStreamSettings.TabIndex = 11;
            this.btnUpdateStreamSettings.Text = "Update";
            this.btnUpdateStreamSettings.Click += new System.EventHandler(this.btnUpdateStreamSettings_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Temp Targets";
            // 
            // chkBedTempTarget
            // 
            this.chkBedTempTarget.AutoSize = true;
            this.chkBedTempTarget.Location = new System.Drawing.Point(17, 78);
            this.chkBedTempTarget.Name = "chkBedTempTarget";
            this.chkBedTempTarget.Size = new System.Drawing.Size(110, 17);
            this.chkBedTempTarget.TabIndex = 2;
            this.chkBedTempTarget.Text = "Bed Temp Target";
            this.chkBedTempTarget.UseVisualStyleBackColor = true;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(131, 26);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(22, 83);
            this.separatorControl1.TabIndex = 1;
            // 
            // chkToolTempTarget
            // 
            this.chkToolTempTarget.AutoSize = true;
            this.chkToolTempTarget.Location = new System.Drawing.Point(17, 55);
            this.chkToolTempTarget.Name = "chkToolTempTarget";
            this.chkToolTempTarget.Size = new System.Drawing.Size(113, 17);
            this.chkToolTempTarget.TabIndex = 0;
            this.chkToolTempTarget.Text = "Tool Temp Target";
            this.chkToolTempTarget.UseVisualStyleBackColor = true;
            // 
            // tmrSaveApplicationAddons
            // 
            this.tmrSaveApplicationAddons.Interval = 5000;
            this.tmrSaveApplicationAddons.Tick += new System.EventHandler(this.tmrSaveApplicationAddons_Tick);
            // 
            // tmrSaveStreamSettings
            // 
            this.tmrSaveStreamSettings.Interval = 5000;
            this.tmrSaveStreamSettings.Tick += new System.EventHandler(this.tmrSaveStreamSettings_Tick);
            // 
            // btnOpenStreamDirectory
            // 
            this.btnOpenStreamDirectory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnOpenStreamDirectory.Location = new System.Drawing.Point(206, 49);
            this.btnOpenStreamDirectory.Name = "btnOpenStreamDirectory";
            this.btnOpenStreamDirectory.Size = new System.Drawing.Size(133, 23);
            this.btnOpenStreamDirectory.TabIndex = 15;
            this.btnOpenStreamDirectory.Text = "Open Stream Folder";
            this.btnOpenStreamDirectory.Click += new System.EventHandler(this.btnOpenStreamDirectory_Click);
            // 
            // linkStreamSetupGuide
            // 
            this.linkStreamSetupGuide.Location = new System.Drawing.Point(40, 122);
            this.linkStreamSetupGuide.Name = "linkStreamSetupGuide";
            this.linkStreamSetupGuide.Size = new System.Drawing.Size(109, 13);
            this.linkStreamSetupGuide.TabIndex = 16;
            this.linkStreamSetupGuide.Text = "Stream setup guide...";
            this.linkStreamSetupGuide.Click += new System.EventHandler(this.linkStreamSetupGuide_Click);
            // 
            // frmAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 375);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupApplicationAddons);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.frmAppSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupApplicationAddons)).EndInit();
            this.groupApplicationAddons.ResumeLayout(false);
            this.groupApplicationAddons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupApplicationAddons;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblDisplayLayerProgressLink;
        private System.Windows.Forms.CheckBox chkDisplayLayerProgress;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnUpdateStreamSettings;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox chkBedTempTarget;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.CheckBox chkToolTempTarget;
        private DevExpress.XtraEditors.SimpleButton btnUpdateAddons;
        private DevExpress.XtraEditors.LabelControl lblUpdatedAddons;
        private System.Windows.Forms.Timer tmrSaveApplicationAddons;
        private System.Windows.Forms.Timer tmrSaveStreamSettings;
        private DevExpress.XtraEditors.LabelControl lblUpdatedStreamSettings;
        private DevExpress.XtraEditors.SimpleButton btnOpenStreamDirectory;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkStreamSetupGuide;
    }
}