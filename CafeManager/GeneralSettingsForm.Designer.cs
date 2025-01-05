namespace CafeManager
{
    partial class GeneralSettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectBackgroundImage = new System.Windows.Forms.Button();
            this.btnImageEdit = new System.Windows.Forms.Button();
            this.cmbPictureMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPasswordUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrinterUpdate = new System.Windows.Forms.Button();
            this.chkShowPrintPreview = new System.Windows.Forms.CheckBox();
            this.cmbPrinterListForBar = new System.Windows.Forms.ComboBox();
            this.cmbPrinterListForCustomer = new System.Windows.Forms.ComboBox();
            this.chkSetBarDefault = new System.Windows.Forms.CheckBox();
            this.chkSetCustomerDefault = new System.Windows.Forms.CheckBox();
            this.lblPrinterCustomer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 393);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Background image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picPreview);
            this.groupBox3.Location = new System.Drawing.Point(13, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 209);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // picPreview
            // 
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(3, 16);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(496, 190);
            this.picPreview.TabIndex = 3;
            this.picPreview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectBackgroundImage);
            this.groupBox2.Controls.Add(this.btnImageEdit);
            this.groupBox2.Controls.Add(this.cmbPictureMode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 108);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set wallpaper";
            // 
            // btnSelectBackgroundImage
            // 
            this.btnSelectBackgroundImage.Location = new System.Drawing.Point(22, 47);
            this.btnSelectBackgroundImage.Name = "btnSelectBackgroundImage";
            this.btnSelectBackgroundImage.Size = new System.Drawing.Size(108, 23);
            this.btnSelectBackgroundImage.TabIndex = 1;
            this.btnSelectBackgroundImage.Text = "Select image";
            this.btnSelectBackgroundImage.UseVisualStyleBackColor = true;
            this.btnSelectBackgroundImage.Click += new System.EventHandler(this.btnSelectBackgroundImage_Click);
            // 
            // btnImageEdit
            // 
            this.btnImageEdit.BackgroundImage = global::CafeManager.Properties.Resources.edit;
            this.btnImageEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImageEdit.Location = new System.Drawing.Point(406, 25);
            this.btnImageEdit.Name = "btnImageEdit";
            this.btnImageEdit.Size = new System.Drawing.Size(66, 66);
            this.btnImageEdit.TabIndex = 16;
            this.btnImageEdit.UseVisualStyleBackColor = true;
            this.btnImageEdit.Click += new System.EventHandler(this.btnImageEdit_Click);
            // 
            // cmbPictureMode
            // 
            this.cmbPictureMode.FormattingEnabled = true;
            this.cmbPictureMode.Items.AddRange(new object[] {
            "Normal",
            "Tile",
            "Center",
            "Stretch",
            "Zoom"});
            this.cmbPictureMode.Location = new System.Drawing.Point(247, 49);
            this.cmbPictureMode.Name = "cmbPictureMode";
            this.cmbPictureMode.Size = new System.Drawing.Size(121, 21);
            this.cmbPictureMode.TabIndex = 3;
            this.cmbPictureMode.Text = "Center";
            this.cmbPictureMode.SelectedValueChanged += new System.EventHandler(this.cmbPictureMode_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Picture mode";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnPasswordUpdate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtRepeatPassword);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNewPassword);
            this.groupBox4.Controls.Add(this.txtOldPassword);
            this.groupBox4.Location = new System.Drawing.Point(13, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 195);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set new password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password";
            // 
            // btnPasswordUpdate
            // 
            this.btnPasswordUpdate.BackgroundImage = global::CafeManager.Properties.Resources.edit;
            this.btnPasswordUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasswordUpdate.Location = new System.Drawing.Point(409, 89);
            this.btnPasswordUpdate.Name = "btnPasswordUpdate";
            this.btnPasswordUpdate.Size = new System.Drawing.Size(66, 66);
            this.btnPasswordUpdate.TabIndex = 17;
            this.btnPasswordUpdate.UseVisualStyleBackColor = true;
            this.btnPasswordUpdate.Click += new System.EventHandler(this.btnPasswordUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(119, 135);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(188, 20);
            this.txtRepeatPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "New password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(119, 89);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(188, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(119, 37);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(188, 20);
            this.txtOldPassword.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(529, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Printer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrinterUpdate);
            this.groupBox1.Controls.Add(this.chkShowPrintPreview);
            this.groupBox1.Controls.Add(this.cmbPrinterListForBar);
            this.groupBox1.Controls.Add(this.cmbPrinterListForCustomer);
            this.groupBox1.Controls.Add(this.chkSetBarDefault);
            this.groupBox1.Controls.Add(this.chkSetCustomerDefault);
            this.groupBox1.Controls.Add(this.lblPrinterCustomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer Name";
            // 
            // btnPrinterUpdate
            // 
            this.btnPrinterUpdate.BackgroundImage = global::CafeManager.Properties.Resources.edit;
            this.btnPrinterUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrinterUpdate.Location = new System.Drawing.Point(412, 92);
            this.btnPrinterUpdate.Name = "btnPrinterUpdate";
            this.btnPrinterUpdate.Size = new System.Drawing.Size(66, 66);
            this.btnPrinterUpdate.TabIndex = 18;
            this.btnPrinterUpdate.UseVisualStyleBackColor = true;
            this.btnPrinterUpdate.Click += new System.EventHandler(this.btnPrinterUpdate_Click);
            // 
            // chkShowPrintPreview
            // 
            this.chkShowPrintPreview.AutoSize = true;
            this.chkShowPrintPreview.Location = new System.Drawing.Point(22, 143);
            this.chkShowPrintPreview.Name = "chkShowPrintPreview";
            this.chkShowPrintPreview.Size = new System.Drawing.Size(116, 17);
            this.chkShowPrintPreview.TabIndex = 8;
            this.chkShowPrintPreview.Text = "Show print preview";
            this.chkShowPrintPreview.UseVisualStyleBackColor = true;
            // 
            // cmbPrinterListForBar
            // 
            this.cmbPrinterListForBar.FormattingEnabled = true;
            this.cmbPrinterListForBar.Location = new System.Drawing.Point(137, 56);
            this.cmbPrinterListForBar.Name = "cmbPrinterListForBar";
            this.cmbPrinterListForBar.Size = new System.Drawing.Size(251, 21);
            this.cmbPrinterListForBar.TabIndex = 7;
            // 
            // cmbPrinterListForCustomer
            // 
            this.cmbPrinterListForCustomer.FormattingEnabled = true;
            this.cmbPrinterListForCustomer.Location = new System.Drawing.Point(137, 29);
            this.cmbPrinterListForCustomer.Name = "cmbPrinterListForCustomer";
            this.cmbPrinterListForCustomer.Size = new System.Drawing.Size(251, 21);
            this.cmbPrinterListForCustomer.TabIndex = 6;
            // 
            // chkSetBarDefault
            // 
            this.chkSetBarDefault.AutoSize = true;
            this.chkSetBarDefault.Location = new System.Drawing.Point(22, 120);
            this.chkSetBarDefault.Name = "chkSetBarDefault";
            this.chkSetBarDefault.Size = new System.Drawing.Size(338, 17);
            this.chkSetBarDefault.TabIndex = 5;
            this.chkSetBarDefault.Text = "Set the check box for bar receipt printing to \"Checked\"  by default";
            this.chkSetBarDefault.UseVisualStyleBackColor = true;
            // 
            // chkSetCustomerDefault
            // 
            this.chkSetCustomerDefault.AutoSize = true;
            this.chkSetCustomerDefault.Location = new System.Drawing.Point(22, 97);
            this.chkSetCustomerDefault.Name = "chkSetCustomerDefault";
            this.chkSetCustomerDefault.Size = new System.Drawing.Size(366, 17);
            this.chkSetCustomerDefault.TabIndex = 4;
            this.chkSetCustomerDefault.Text = "Set the check box for customer receipt printing to \"Checked\"  by default";
            this.chkSetCustomerDefault.UseVisualStyleBackColor = true;
            // 
            // lblPrinterCustomer
            // 
            this.lblPrinterCustomer.AutoSize = true;
            this.lblPrinterCustomer.Location = new System.Drawing.Point(19, 29);
            this.lblPrinterCustomer.Name = "lblPrinterCustomer";
            this.lblPrinterCustomer.Size = new System.Drawing.Size(112, 13);
            this.lblPrinterCustomer.TabIndex = 0;
            this.lblPrinterCustomer.Text = "Customer printer name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bar printer name";
            // 
            // GeneralSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(561, 420);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GeneralSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "General settings";
            this.Load += new System.EventHandler(this.GeneralSettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSelectBackgroundImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPictureMode;
        private System.Windows.Forms.Button btnImageEdit;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPasswordUpdate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblPrinterCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSetCustomerDefault;
        private System.Windows.Forms.CheckBox chkSetBarDefault;
        private System.Windows.Forms.ComboBox cmbPrinterListForBar;
        private System.Windows.Forms.ComboBox cmbPrinterListForCustomer;
        private System.Windows.Forms.CheckBox chkShowPrintPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrinterUpdate;
    }
}