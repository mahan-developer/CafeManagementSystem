namespace CafeManager
{
    partial class ShopInformationForm
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
            this.btnInfoEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtInvoiceDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtShopAddress = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInfoEdit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.txtInvoiceDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtShopAddress);
            this.groupBox1.Controls.Add(this.txtShopName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnInfoEdit
            // 
            this.btnInfoEdit.BackgroundImage = global::CafeManager.Properties.Resources.edit;
            this.btnInfoEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfoEdit.Location = new System.Drawing.Point(542, 166);
            this.btnInfoEdit.Name = "btnInfoEdit";
            this.btnInfoEdit.Size = new System.Drawing.Size(66, 66);
            this.btnInfoEdit.TabIndex = 15;
            this.btnInfoEdit.UseVisualStyleBackColor = true;
            this.btnInfoEdit.Click += new System.EventHandler(this.btnInfoEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Logo";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Location = new System.Drawing.Point(122, 166);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(66, 66);
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtInvoiceDescription
            // 
            this.txtInvoiceDescription.Location = new System.Drawing.Point(418, 27);
            this.txtInvoiceDescription.Multiline = true;
            this.txtInvoiceDescription.Name = "txtInvoiceDescription";
            this.txtInvoiceDescription.Size = new System.Drawing.Size(190, 72);
            this.txtInvoiceDescription.TabIndex = 11;
            this.txtInvoiceDescription.TextChanged += new System.EventHandler(this.txtInvoiceDescription_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Invoice Descripton";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(418, 123);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(190, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtShopAddress
            // 
            this.txtShopAddress.Location = new System.Drawing.Point(122, 67);
            this.txtShopAddress.Multiline = true;
            this.txtShopAddress.Name = "txtShopAddress";
            this.txtShopAddress.Size = new System.Drawing.Size(156, 72);
            this.txtShopAddress.TabIndex = 4;
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(122, 24);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(156, 20);
            this.txtShopName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop name";
            // 
            // ShopInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 297);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShopInformationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Shop information";
            this.Load += new System.EventHandler(this.ShopInformationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtShopAddress;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.TextBox txtInvoiceDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnInfoEdit;
    }
}