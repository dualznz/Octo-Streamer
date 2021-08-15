
namespace Octo_Streamer
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.lblHost = new DevExpress.XtraEditors.LabelControl();
            this.txtHost = new DevExpress.XtraEditors.TextEdit();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.lblPort = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtApiKey = new DevExpress.XtraEditors.TextEdit();
            this.lblApiKey = new DevExpress.XtraEditors.LabelControl();
            this.linkApiKey = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.lblConnectionStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tmrConnect = new System.Windows.Forms.Timer(this.components);
            this.linkResetConnectionData = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApiKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHost.Appearance.Options.UseFont = true;
            this.lblHost.Location = new System.Drawing.Point(106, 51);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.EditValue = "";
            this.txtHost.Location = new System.Drawing.Point(145, 48);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(190, 20);
            this.txtHost.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.EditValue = "";
            this.txtPort.Location = new System.Drawing.Point(145, 79);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(190, 20);
            this.txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPort.Appearance.Options.UseFont = true;
            this.lblPort.Location = new System.Drawing.Point(98, 82);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port *:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(311, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "* = Optional Field";
            // 
            // txtApiKey
            // 
            this.txtApiKey.EditValue = "";
            this.txtApiKey.Location = new System.Drawing.Point(145, 110);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(190, 20);
            this.txtApiKey.TabIndex = 6;
            // 
            // lblApiKey
            // 
            this.lblApiKey.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApiKey.Appearance.Options.UseFont = true;
            this.lblApiKey.Location = new System.Drawing.Point(88, 113);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(47, 13);
            this.lblApiKey.TabIndex = 5;
            this.lblApiKey.Text = "API Key:";
            // 
            // linkApiKey
            // 
            this.linkApiKey.Location = new System.Drawing.Point(188, 136);
            this.linkApiKey.Name = "linkApiKey";
            this.linkApiKey.Size = new System.Drawing.Size(155, 13);
            this.linkApiKey.TabIndex = 7;
            this.linkApiKey.Text = "Find out how obtain API key...";
            this.linkApiKey.Click += new System.EventHandler(this.linkApiKey_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnConnect.Appearance.Options.UseBorderColor = true;
            this.btnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.ImageOptions.Image")));
            this.btnConnect.Location = new System.Drawing.Point(166, 164);
            this.btnConnect.LookAndFeel.SkinName = "The Bezier";
            this.btnConnect.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Appearance.Options.UseTextOptions = true;
            this.lblConnectionStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblConnectionStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblConnectionStatus.Location = new System.Drawing.Point(3, 197);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(403, 13);
            this.lblConnectionStatus.TabIndex = 9;
            this.lblConnectionStatus.Text = "lblConnectionStatus";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(70, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(280, 25);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "OctoPrint Connection Settings";
            // 
            // tmrConnect
            // 
            this.tmrConnect.Interval = 2000;
            this.tmrConnect.Tick += new System.EventHandler(this.tmrConnect_Tick);
            // 
            // linkResetConnectionData
            // 
            this.linkResetConnectionData.Appearance.ForeColor = System.Drawing.Color.Red;
            this.linkResetConnectionData.Appearance.LinkColor = System.Drawing.Color.Red;
            this.linkResetConnectionData.Appearance.Options.UseForeColor = true;
            this.linkResetConnectionData.Appearance.Options.UseLinkColor = true;
            this.linkResetConnectionData.Location = new System.Drawing.Point(3, 218);
            this.linkResetConnectionData.Name = "linkResetConnectionData";
            this.linkResetConnectionData.Size = new System.Drawing.Size(124, 13);
            this.linkResetConnectionData.TabIndex = 11;
            this.linkResetConnectionData.Text = "Reset connection data...";
            this.linkResetConnectionData.Click += new System.EventHandler(this.linkResetConnectionData_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 234);
            this.Controls.Add(this.linkResetConnectionData);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.linkApiKey);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblHost);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect To OctoPrint Server";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApiKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblHost;
        private DevExpress.XtraEditors.TextEdit txtHost;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.LabelControl lblPort;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtApiKey;
        private DevExpress.XtraEditors.LabelControl lblApiKey;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkApiKey;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.LabelControl lblConnectionStatus;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Timer tmrConnect;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkResetConnectionData;
    }
}