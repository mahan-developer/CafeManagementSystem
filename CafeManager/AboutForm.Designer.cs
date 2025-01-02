namespace CafeManager
{
    partial class AboutForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDeveloperName = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.lblDeveloperName);
            this.groupBox1.Controls.Add(this.lblAppVersion);
            this.groupBox1.Controls.Add(this.lblAppName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(21, 149);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(156, 13);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact: mahan@javaheri.work";
            // 
            // lblDeveloperName
            // 
            this.lblDeveloperName.AutoSize = true;
            this.lblDeveloperName.Location = new System.Drawing.Point(21, 109);
            this.lblDeveloperName.Name = "lblDeveloperName";
            this.lblDeveloperName.Size = new System.Drawing.Size(152, 13);
            this.lblDeveloperName.TabIndex = 2;
            this.lblDeveloperName.Text = "Developed by Mahan Javaheri";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Location = new System.Drawing.Point(21, 70);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(72, 13);
            this.lblAppVersion.TabIndex = 1;
            this.lblAppVersion.Text = "Version; 1.0.0";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(21, 31);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(103, 13);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "CAFE MANAGER";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 229);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblAppName;
    }
}