namespace CafeManager
{
    partial class CustomerForm
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
            this.grpCustomerAdd = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAddCustomerCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtAddCustomerEmailAddress = new System.Windows.Forms.TextBox();
            this.txtAddCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtAddCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblcustomeraddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.grpCustomerSearch = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpCustomerAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.grpCustomerSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerAdd
            // 
            this.grpCustomerAdd.Controls.Add(this.button1);
            this.grpCustomerAdd.Controls.Add(this.txtAddCustomerCustomerAddress);
            this.grpCustomerAdd.Controls.Add(this.txtAddCustomerEmailAddress);
            this.grpCustomerAdd.Controls.Add(this.txtAddCustomerPhoneNumber);
            this.grpCustomerAdd.Controls.Add(this.txtAddCustomerLastName);
            this.grpCustomerAdd.Controls.Add(this.txtAddCustomerFirstName);
            this.grpCustomerAdd.Controls.Add(this.lblcustomeraddress);
            this.grpCustomerAdd.Controls.Add(this.lblEmail);
            this.grpCustomerAdd.Controls.Add(this.lbl);
            this.grpCustomerAdd.Controls.Add(this.label2);
            this.grpCustomerAdd.Controls.Add(this.label1);
            this.grpCustomerAdd.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerAdd.Name = "grpCustomerAdd";
            this.grpCustomerAdd.Size = new System.Drawing.Size(889, 88);
            this.grpCustomerAdd.TabIndex = 0;
            this.grpCustomerAdd.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::CafeManager.Properties.Resources.add_50px;
            this.button1.Location = new System.Drawing.Point(817, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAddCustomerCustomerAddress
            // 
            this.txtAddCustomerCustomerAddress.Location = new System.Drawing.Point(666, 45);
            this.txtAddCustomerCustomerAddress.Name = "txtAddCustomerCustomerAddress";
            this.txtAddCustomerCustomerAddress.Size = new System.Drawing.Size(145, 20);
            this.txtAddCustomerCustomerAddress.TabIndex = 9;
            // 
            // txtAddCustomerEmailAddress
            // 
            this.txtAddCustomerEmailAddress.Location = new System.Drawing.Point(506, 45);
            this.txtAddCustomerEmailAddress.Name = "txtAddCustomerEmailAddress";
            this.txtAddCustomerEmailAddress.Size = new System.Drawing.Size(145, 20);
            this.txtAddCustomerEmailAddress.TabIndex = 8;
            // 
            // txtAddCustomerPhoneNumber
            // 
            this.txtAddCustomerPhoneNumber.Location = new System.Drawing.Point(346, 45);
            this.txtAddCustomerPhoneNumber.Name = "txtAddCustomerPhoneNumber";
            this.txtAddCustomerPhoneNumber.Size = new System.Drawing.Size(145, 20);
            this.txtAddCustomerPhoneNumber.TabIndex = 7;
            this.txtAddCustomerPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddCustomerPhoneNumber_KeyPress);
            // 
            // txtAddCustomerLastName
            // 
            this.txtAddCustomerLastName.Location = new System.Drawing.Point(185, 45);
            this.txtAddCustomerLastName.Name = "txtAddCustomerLastName";
            this.txtAddCustomerLastName.Size = new System.Drawing.Size(145, 20);
            this.txtAddCustomerLastName.TabIndex = 6;
            // 
            // txtAddCustomerFirstName
            // 
            this.txtAddCustomerFirstName.Location = new System.Drawing.Point(26, 45);
            this.txtAddCustomerFirstName.Name = "txtAddCustomerFirstName";
            this.txtAddCustomerFirstName.Size = new System.Drawing.Size(145, 20);
            this.txtAddCustomerFirstName.TabIndex = 5;
            // 
            // lblcustomeraddress
            // 
            this.lblcustomeraddress.AutoSize = true;
            this.lblcustomeraddress.Location = new System.Drawing.Point(663, 27);
            this.lblcustomeraddress.Name = "lblcustomeraddress";
            this.lblcustomeraddress.Size = new System.Drawing.Size(45, 13);
            this.lblcustomeraddress.TabIndex = 4;
            this.lblcustomeraddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(503, 27);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(343, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(78, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.grpCustomerSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCustomerList);
            this.groupBox4.Location = new System.Drawing.Point(23, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(849, 294);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerList.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.Size = new System.Drawing.Size(843, 275);
            this.dgvCustomerList.TabIndex = 11;
            this.dgvCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReadCustomerList_CellClick);
            // 
            // grpCustomerSearch
            // 
            this.grpCustomerSearch.Controls.Add(this.label6);
            this.grpCustomerSearch.Controls.Add(this.txtSearchLastName);
            this.grpCustomerSearch.Controls.Add(this.txtSearchPhoneNumber);
            this.grpCustomerSearch.Controls.Add(this.label7);
            this.grpCustomerSearch.Location = new System.Drawing.Point(23, 19);
            this.grpCustomerSearch.Name = "grpCustomerSearch";
            this.grpCustomerSearch.Size = new System.Drawing.Size(849, 61);
            this.grpCustomerSearch.TabIndex = 11;
            this.grpCustomerSearch.TabStop = false;
            this.grpCustomerSearch.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search by Last Name";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(130, 23);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(149, 20);
            this.txtSearchLastName.TabIndex = 7;
            this.txtSearchLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyUp);
            // 
            // txtSearchPhoneNumber
            // 
            this.txtSearchPhoneNumber.Location = new System.Drawing.Point(448, 23);
            this.txtSearchPhoneNumber.Name = "txtSearchPhoneNumber";
            this.txtSearchPhoneNumber.Size = new System.Drawing.Size(149, 20);
            this.txtSearchPhoneNumber.TabIndex = 9;
            this.txtSearchPhoneNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchPhoneNumber_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Search by Phone Number";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCustomerAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.grpCustomerAdd.ResumeLayout(false);
            this.grpCustomerAdd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.grpCustomerSearch.ResumeLayout(false);
            this.grpCustomerSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerAdd;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcustomeraddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddCustomerCustomerAddress;
        private System.Windows.Forms.TextBox txtAddCustomerEmailAddress;
        private System.Windows.Forms.TextBox txtAddCustomerPhoneNumber;
        private System.Windows.Forms.TextBox txtAddCustomerLastName;
        private System.Windows.Forms.TextBox txtAddCustomerFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.GroupBox grpCustomerSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchPhoneNumber;
        private System.Windows.Forms.Label label7;
    }
}