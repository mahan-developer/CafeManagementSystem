namespace CafeManager
{
    partial class SaleReportForm
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
            this.btnInvoceSearch = new System.Windows.Forms.Button();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvInvoicesList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoicesList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInvoceSearch);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnInvoceSearch
            // 
            this.btnInvoceSearch.BackgroundImage = global::CafeManager.Properties.Resources.search_70px;
            this.btnInvoceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoceSearch.Location = new System.Drawing.Point(884, 16);
            this.btnInvoceSearch.Name = "btnInvoceSearch";
            this.btnInvoceSearch.Size = new System.Drawing.Size(90, 90);
            this.btnInvoceSearch.TabIndex = 2;
            this.btnInvoceSearch.UseVisualStyleBackColor = true;
            this.btnInvoceSearch.Click += new System.EventHandler(this.btnInvoceSearch_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(385, 52);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(198, 20);
            this.txtEndDate.TabIndex = 4;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(65, 52);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(198, 20);
            this.txtStartDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvInvoicesList);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvInvoicesList
            // 
            this.dgvInvoicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoicesList.Location = new System.Drawing.Point(3, 16);
            this.dgvInvoicesList.Name = "dgvInvoicesList";
            this.dgvInvoicesList.Size = new System.Drawing.Size(980, 351);
            this.dgvInvoicesList.TabIndex = 0;
            this.dgvInvoicesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoicesList_CellDoubleClick);
            // 
            // SaleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaleReportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sale report";
            this.Load += new System.EventHandler(this.SaleReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoicesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInvoceSearch;
        private System.Windows.Forms.DataGridView dgvInvoicesList;
    }
}