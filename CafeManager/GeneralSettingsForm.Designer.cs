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
            this.btnImageEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPictureMode = new System.Windows.Forms.ComboBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnSelectBackgroundImage = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImageEdit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbPictureMode);
            this.tabPage1.Controls.Add(this.picPreview);
            this.tabPage1.Controls.Add(this.btnSelectBackgroundImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Background image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImageEdit
            // 
            this.btnImageEdit.BackgroundImage = global::CafeManager.Properties.Resources.edit;
            this.btnImageEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImageEdit.Location = new System.Drawing.Point(449, 7);
            this.btnImageEdit.Name = "btnImageEdit";
            this.btnImageEdit.Size = new System.Drawing.Size(66, 66);
            this.btnImageEdit.TabIndex = 16;
            this.btnImageEdit.UseVisualStyleBackColor = true;
            this.btnImageEdit.Click += new System.EventHandler(this.btnImageEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Picture mode";
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
            this.cmbPictureMode.Location = new System.Drawing.Point(290, 35);
            this.cmbPictureMode.Name = "cmbPictureMode";
            this.cmbPictureMode.Size = new System.Drawing.Size(121, 21);
            this.cmbPictureMode.TabIndex = 3;
            this.cmbPictureMode.Text = "Normal";
            this.cmbPictureMode.SelectedValueChanged += new System.EventHandler(this.cmbPictureMode_SelectedValueChanged);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(35, 79);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(480, 257);
            this.picPreview.TabIndex = 2;
            this.picPreview.TabStop = false;
            // 
            // btnSelectBackgroundImage
            // 
            this.btnSelectBackgroundImage.Location = new System.Drawing.Point(35, 35);
            this.btnSelectBackgroundImage.Name = "btnSelectBackgroundImage";
            this.btnSelectBackgroundImage.Size = new System.Drawing.Size(108, 23);
            this.btnSelectBackgroundImage.TabIndex = 1;
            this.btnSelectBackgroundImage.Text = "Select image";
            this.btnSelectBackgroundImage.UseVisualStyleBackColor = true;
            this.btnSelectBackgroundImage.Click += new System.EventHandler(this.btnSelectBackgroundImage_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtRepeatPassword);
            this.tabPage2.Controls.Add(this.txtNewPassword);
            this.tabPage2.Controls.Add(this.txtOldPassword);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "New password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(152, 42);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(188, 20);
            this.txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(152, 94);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(188, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(152, 140);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(188, 20);
            this.txtRepeatPassword.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CafeManager.Properties.Resources.edit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(423, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 66);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSelectBackgroundImage;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPictureMode;
        private System.Windows.Forms.Button btnImageEdit;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}