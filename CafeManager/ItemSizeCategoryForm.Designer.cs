namespace CafeManager
{
    partial class ItemSizeCategoryForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMenuItemSizeCategory = new System.Windows.Forms.DataGridView();
            this.grpMenuItemSizeCategorySearch = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.grpMenuItemSizeCategoryAdd = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtAddCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItemSizeCategory)).BeginInit();
            this.grpMenuItemSizeCategorySearch.SuspendLayout();
            this.grpMenuItemSizeCategoryAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.grpMenuItemSizeCategorySearch);
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 312);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMenuItemSizeCategory);
            this.groupBox4.Location = new System.Drawing.Point(23, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 212);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // dgvMenuItemSizeCategory
            // 
            this.dgvMenuItemSizeCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItemSizeCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuItemSizeCategory.Location = new System.Drawing.Point(3, 16);
            this.dgvMenuItemSizeCategory.Name = "dgvMenuItemSizeCategory";
            this.dgvMenuItemSizeCategory.RowHeadersVisible = false;
            this.dgvMenuItemSizeCategory.Size = new System.Drawing.Size(334, 193);
            this.dgvMenuItemSizeCategory.TabIndex = 11;
            this.dgvMenuItemSizeCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuItemSizeCategory_CellClick);
            // 
            // grpMenuItemSizeCategorySearch
            // 
            this.grpMenuItemSizeCategorySearch.Controls.Add(this.label6);
            this.grpMenuItemSizeCategorySearch.Controls.Add(this.txtSearchCategory);
            this.grpMenuItemSizeCategorySearch.Location = new System.Drawing.Point(23, 19);
            this.grpMenuItemSizeCategorySearch.Name = "grpMenuItemSizeCategorySearch";
            this.grpMenuItemSizeCategorySearch.Size = new System.Drawing.Size(340, 61);
            this.grpMenuItemSizeCategorySearch.TabIndex = 11;
            this.grpMenuItemSizeCategorySearch.TabStop = false;
            this.grpMenuItemSizeCategorySearch.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search by Name";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(155, 23);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(149, 20);
            this.txtSearchCategory.TabIndex = 7;
            this.txtSearchCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCategory_KeyUp);
            // 
            // grpMenuItemSizeCategoryAdd
            // 
            this.grpMenuItemSizeCategoryAdd.Controls.Add(this.btnAddCategory);
            this.grpMenuItemSizeCategoryAdd.Controls.Add(this.txtAddCategoryName);
            this.grpMenuItemSizeCategoryAdd.Controls.Add(this.label1);
            this.grpMenuItemSizeCategoryAdd.Location = new System.Drawing.Point(13, 8);
            this.grpMenuItemSizeCategoryAdd.Name = "grpMenuItemSizeCategoryAdd";
            this.grpMenuItemSizeCategoryAdd.Size = new System.Drawing.Size(387, 102);
            this.grpMenuItemSizeCategoryAdd.TabIndex = 2;
            this.grpMenuItemSizeCategoryAdd.TabStop = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = global::CafeManager.Properties.Resources.add_50px;
            this.btnAddCategory.Location = new System.Drawing.Point(305, 27);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(55, 55);
            this.btnAddCategory.TabIndex = 10;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtAddCategoryName
            // 
            this.txtAddCategoryName.Location = new System.Drawing.Point(23, 59);
            this.txtAddCategoryName.Name = "txtAddCategoryName";
            this.txtAddCategoryName.Size = new System.Drawing.Size(239, 20);
            this.txtAddCategoryName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size Category Name";
            // 
            // ItemSizeCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpMenuItemSizeCategoryAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ItemSizeCategoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item size Category";
            this.Load += new System.EventHandler(this.ItemSizeCategoryForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItemSizeCategory)).EndInit();
            this.grpMenuItemSizeCategorySearch.ResumeLayout(false);
            this.grpMenuItemSizeCategorySearch.PerformLayout();
            this.grpMenuItemSizeCategoryAdd.ResumeLayout(false);
            this.grpMenuItemSizeCategoryAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvMenuItemSizeCategory;
        private System.Windows.Forms.GroupBox grpMenuItemSizeCategorySearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.GroupBox grpMenuItemSizeCategoryAdd;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtAddCategoryName;
        private System.Windows.Forms.Label label1;
    }
}