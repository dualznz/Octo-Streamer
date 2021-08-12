
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
            this.groupApplicationAddons = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdateDisplayLayerProgress = new DevExpress.XtraEditors.SimpleButton();
            this.chkDisplayLayerProgress = new System.Windows.Forms.CheckBox();
            this.lblDisplayLayerProgressLink = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupApplicationAddons)).BeginInit();
            this.groupApplicationAddons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupApplicationAddons
            // 
            this.groupApplicationAddons.Controls.Add(this.btnUpdateDisplayLayerProgress);
            this.groupApplicationAddons.Controls.Add(this.chkDisplayLayerProgress);
            this.groupApplicationAddons.Controls.Add(this.lblDisplayLayerProgressLink);
            this.groupApplicationAddons.Location = new System.Drawing.Point(31, 38);
            this.groupApplicationAddons.Name = "groupApplicationAddons";
            this.groupApplicationAddons.Size = new System.Drawing.Size(348, 133);
            this.groupApplicationAddons.TabIndex = 0;
            this.groupApplicationAddons.Text = "Application Addons";
            // 
            // btnUpdateDisplayLayerProgress
            // 
            this.btnUpdateDisplayLayerProgress.Location = new System.Drawing.Point(243, 89);
            this.btnUpdateDisplayLayerProgress.Name = "btnUpdateDisplayLayerProgress";
            this.btnUpdateDisplayLayerProgress.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateDisplayLayerProgress.TabIndex = 10;
            this.btnUpdateDisplayLayerProgress.Text = "Update";
            this.btnUpdateDisplayLayerProgress.Click += new System.EventHandler(this.btnUpdateDisplayLayerProgress_Click);
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
            this.groupControl2.Location = new System.Drawing.Point(31, 209);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(348, 114);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Stream Files";
            // 
            // frmAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 367);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupApplicationAddons);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAppSettings";
            this.Load += new System.EventHandler(this.frmAppSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupApplicationAddons)).EndInit();
            this.groupApplicationAddons.ResumeLayout(false);
            this.groupApplicationAddons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupApplicationAddons;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblDisplayLayerProgressLink;
        private System.Windows.Forms.CheckBox chkDisplayLayerProgress;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDisplayLayerProgress;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}