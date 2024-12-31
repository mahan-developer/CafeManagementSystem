namespace CafeManager
{
    partial class ItemSizeForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCafeMenuItemSizeList = new System.Windows.Forms.DataGridView();
            this.grpCafeMenuItemSizeSearch = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchCafeMenuItemSizeName = new System.Windows.Forms.TextBox();
            this.grpCafeMenuItemSizeAdd = new System.Windows.Forms.GroupBox();
            this.btnAddCafeMenuItemSize = new System.Windows.Forms.Button();
            this.txtMenuItemSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMenuItemSizeCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCafeMenuItemSizeList)).BeginInit();
            this.grpCafeMenuItemSizeSearch.SuspendLayout();
            this.grpCafeMenuItemSizeAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.grpCafeMenuItemSizeSearch);
            this.groupBox1.Controls.Add(this.grpCafeMenuItemSizeAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCafeMenuItemSizeList);
            this.groupBox4.Location = new System.Drawing.Point(17, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 264);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // dgvCafeMenuItemSizeList
            // 
            this.dgvCafeMenuItemSizeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCafeMenuItemSizeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCafeMenuItemSizeList.Location = new System.Drawing.Point(3, 16);
            this.dgvCafeMenuItemSizeList.Name = "dgvCafeMenuItemSizeList";
            this.dgvCafeMenuItemSizeList.RowHeadersVisible = false;
            this.dgvCafeMenuItemSizeList.Size = new System.Drawing.Size(737, 245);
            this.dgvCafeMenuItemSizeList.TabIndex = 11;
            this.dgvCafeMenuItemSizeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCafeMenuItemSizeList_CellClick);
            // 
            // grpCafeMenuItemSizeSearch
            // 
            this.grpCafeMenuItemSizeSearch.Controls.Add(this.label6);
            this.grpCafeMenuItemSizeSearch.Controls.Add(this.txtSearchCafeMenuItemSizeName);
            this.grpCafeMenuItemSizeSearch.Location = new System.Drawing.Point(17, 112);
            this.grpCafeMenuItemSizeSearch.Name = "grpCafeMenuItemSizeSearch";
            this.grpCafeMenuItemSizeSearch.Size = new System.Drawing.Size(743, 51);
            this.grpCafeMenuItemSizeSearch.TabIndex = 13;
            this.grpCafeMenuItemSizeSearch.TabStop = false;
            this.grpCafeMenuItemSizeSearch.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search by size name";
            // 
            // txtSearchCafeMenuItemSizeName
            // 
            this.txtSearchCafeMenuItemSizeName.Location = new System.Drawing.Point(130, 19);
            this.txtSearchCafeMenuItemSizeName.Name = "txtSearchCafeMenuItemSizeName";
            this.txtSearchCafeMenuItemSizeName.Size = new System.Drawing.Size(187, 20);
            this.txtSearchCafeMenuItemSizeName.TabIndex = 7;
            this.txtSearchCafeMenuItemSizeName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCafeMenuItemSizeName_KeyUp);
            // 
            // grpCafeMenuItemSizeAdd
            // 
            this.grpCafeMenuItemSizeAdd.Controls.Add(this.btnAddCafeMenuItemSize);
            this.grpCafeMenuItemSizeAdd.Controls.Add(this.txtMenuItemSize);
            this.grpCafeMenuItemSizeAdd.Controls.Add(this.label2);
            this.grpCafeMenuItemSizeAdd.Controls.Add(this.cmbMenuItemSizeCategory);
            this.grpCafeMenuItemSizeAdd.Controls.Add(this.label1);
            this.grpCafeMenuItemSizeAdd.Location = new System.Drawing.Point(17, 19);
            this.grpCafeMenuItemSizeAdd.Name = "grpCafeMenuItemSizeAdd";
            this.grpCafeMenuItemSizeAdd.Size = new System.Drawing.Size(743, 87);
            this.grpCafeMenuItemSizeAdd.TabIndex = 4;
            this.grpCafeMenuItemSizeAdd.TabStop = false;
            this.grpCafeMenuItemSizeAdd.Text = "Add Size";
            // 
            // btnAddCafeMenuItemSize
            // 
            this.btnAddCafeMenuItemSize.Image = global::CafeManager.Properties.Resources.add_50px;
            this.btnAddCafeMenuItemSize.Location = new System.Drawing.Point(667, 19);
            this.btnAddCafeMenuItemSize.Name = "btnAddCafeMenuItemSize";
            this.btnAddCafeMenuItemSize.Size = new System.Drawing.Size(55, 55);
            this.btnAddCafeMenuItemSize.TabIndex = 11;
            this.btnAddCafeMenuItemSize.UseVisualStyleBackColor = true;
            this.btnAddCafeMenuItemSize.Click += new System.EventHandler(this.btnAddCafeMenuItemSize_Click);
            // 
            // txtMenuItemSize
            // 
            this.txtMenuItemSize.Location = new System.Drawing.Point(387, 35);
            this.txtMenuItemSize.Name = "txtMenuItemSize";
            this.txtMenuItemSize.Size = new System.Drawing.Size(151, 20);
            this.txtMenuItemSize.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Size";
            // 
            // cmbMenuItemSizeCategory
            // 
            this.cmbMenuItemSizeCategory.FormattingEnabled = true;
            this.cmbMenuItemSizeCategory.Location = new System.Drawing.Point(110, 35);
            this.cmbMenuItemSizeCategory.Name = "cmbMenuItemSizeCategory";
            this.cmbMenuItemSizeCategory.Size = new System.Drawing.Size(151, 21);
            this.cmbMenuItemSizeCategory.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item size category";
            // 
            // ItemSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 472);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ItemSizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Item size ";
            this.Load += new System.EventHandler(this.ItemSizeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCafeMenuItemSizeList)).EndInit();
            this.grpCafeMenuItemSizeSearch.ResumeLayout(false);
            this.grpCafeMenuItemSizeSearch.PerformLayout();
            this.grpCafeMenuItemSizeAdd.ResumeLayout(false);
            this.grpCafeMenuItemSizeAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpCafeMenuItemSizeAdd;
        private System.Windows.Forms.TextBox txtMenuItemSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMenuItemSizeCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCafeMenuItemSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCafeMenuItemSizeList;
        private System.Windows.Forms.GroupBox grpCafeMenuItemSizeSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCafeMenuItemSizeName;
    }
}