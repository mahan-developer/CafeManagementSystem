namespace CafeManager
{
    partial class MenuCategoryForm
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
            this.dgvMenuCategory = new System.Windows.Forms.DataGridView();
            this.grpMenuCategorySearch = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchMenuCategory = new System.Windows.Forms.TextBox();
            this.grpMenuCategoryAdd = new System.Windows.Forms.GroupBox();
            this.btnAddMenuCategory = new System.Windows.Forms.Button();
            this.txtAddMenuCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuCategory)).BeginInit();
            this.grpMenuCategorySearch.SuspendLayout();
            this.grpMenuCategoryAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.grpMenuCategorySearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 320);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMenuCategory);
            this.groupBox4.Location = new System.Drawing.Point(23, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 223);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // dgvMenuCategory
            // 
            this.dgvMenuCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuCategory.Location = new System.Drawing.Point(3, 16);
            this.dgvMenuCategory.Name = "dgvMenuCategory";
            this.dgvMenuCategory.RowHeadersVisible = false;
            this.dgvMenuCategory.Size = new System.Drawing.Size(334, 204);
            this.dgvMenuCategory.TabIndex = 11;
            this.dgvMenuCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuCategory_CellClick);
            // 
            // grpMenuCategorySearch
            // 
            this.grpMenuCategorySearch.Controls.Add(this.label6);
            this.grpMenuCategorySearch.Controls.Add(this.txtSearchMenuCategory);
            this.grpMenuCategorySearch.Location = new System.Drawing.Point(23, 19);
            this.grpMenuCategorySearch.Name = "grpMenuCategorySearch";
            this.grpMenuCategorySearch.Size = new System.Drawing.Size(340, 61);
            this.grpMenuCategorySearch.TabIndex = 11;
            this.grpMenuCategorySearch.TabStop = false;
            this.grpMenuCategorySearch.Text = "Search";
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
            // txtSearchMenuCategory
            // 
            this.txtSearchMenuCategory.Location = new System.Drawing.Point(155, 23);
            this.txtSearchMenuCategory.Name = "txtSearchMenuCategory";
            this.txtSearchMenuCategory.Size = new System.Drawing.Size(149, 20);
            this.txtSearchMenuCategory.TabIndex = 7;
            this.txtSearchMenuCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchMenuCategory_KeyUp);
            // 
            // grpMenuCategoryAdd
            // 
            this.grpMenuCategoryAdd.Controls.Add(this.btnAddMenuCategory);
            this.grpMenuCategoryAdd.Controls.Add(this.txtAddMenuCategoryName);
            this.grpMenuCategoryAdd.Controls.Add(this.label1);
            this.grpMenuCategoryAdd.Location = new System.Drawing.Point(12, 12);
            this.grpMenuCategoryAdd.Name = "grpMenuCategoryAdd";
            this.grpMenuCategoryAdd.Size = new System.Drawing.Size(387, 102);
            this.grpMenuCategoryAdd.TabIndex = 4;
            this.grpMenuCategoryAdd.TabStop = false;
            // 
            // btnAddMenuCategory
            // 
            this.btnAddMenuCategory.Image = global::CafeManager.Properties.Resources.add_50px;
            this.btnAddMenuCategory.Location = new System.Drawing.Point(305, 27);
            this.btnAddMenuCategory.Name = "btnAddMenuCategory";
            this.btnAddMenuCategory.Size = new System.Drawing.Size(55, 55);
            this.btnAddMenuCategory.TabIndex = 10;
            this.btnAddMenuCategory.UseVisualStyleBackColor = true;
            this.btnAddMenuCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtAddMenuCategoryName
            // 
            this.txtAddMenuCategoryName.Location = new System.Drawing.Point(23, 59);
            this.txtAddMenuCategoryName.Name = "txtAddMenuCategoryName";
            this.txtAddMenuCategoryName.Size = new System.Drawing.Size(239, 20);
            this.txtAddMenuCategoryName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Category Name";
            // 
            // MenuCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpMenuCategoryAdd);
            this.Name = "MenuCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Menu Category";
            this.Load += new System.EventHandler(this.MenuCategoryForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuCategory)).EndInit();
            this.grpMenuCategorySearch.ResumeLayout(false);
            this.grpMenuCategorySearch.PerformLayout();
            this.grpMenuCategoryAdd.ResumeLayout(false);
            this.grpMenuCategoryAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvMenuCategory;
        private System.Windows.Forms.GroupBox grpMenuCategorySearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchMenuCategory;
        private System.Windows.Forms.GroupBox grpMenuCategoryAdd;
        private System.Windows.Forms.Button btnAddMenuCategory;
        private System.Windows.Forms.TextBox txtAddMenuCategoryName;
        private System.Windows.Forms.Label label1;
    }
}