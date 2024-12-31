namespace CafeManager
{
    partial class MenuItemForm
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
            this.dgvCafeMenuItemList = new System.Windows.Forms.DataGridView();
            this.grpCafeMenuItemSearch = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchCafeMenuItemCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchCafeMenuItemName = new System.Windows.Forms.TextBox();
            this.grpCafeMenuItemAdd = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.rdbIsItemAvailable = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCafeMenuItemDescripton = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCafeMenuItemPrice = new System.Windows.Forms.TextBox();
            this.cmbMenuCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMenuItemSize = new System.Windows.Forms.ComboBox();
            this.btnAddCafeMenuItem = new System.Windows.Forms.Button();
            this.txtCafeMenuItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMenuItemSizeCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCafeMenuItemList)).BeginInit();
            this.grpCafeMenuItemSearch.SuspendLayout();
            this.grpCafeMenuItemAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.grpCafeMenuItemSearch);
            this.groupBox1.Controls.Add(this.grpCafeMenuItemAdd);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 504);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCafeMenuItemList);
            this.groupBox4.Location = new System.Drawing.Point(13, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(847, 223);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // dgvCafeMenuItemList
            // 
            this.dgvCafeMenuItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCafeMenuItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCafeMenuItemList.Location = new System.Drawing.Point(3, 16);
            this.dgvCafeMenuItemList.Name = "dgvCafeMenuItemList";
            this.dgvCafeMenuItemList.RowHeadersVisible = false;
            this.dgvCafeMenuItemList.Size = new System.Drawing.Size(841, 204);
            this.dgvCafeMenuItemList.TabIndex = 11;
            this.dgvCafeMenuItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCafeMenuItemList_CellClick);
            // 
            // grpCafeMenuItemSearch
            // 
            this.grpCafeMenuItemSearch.Controls.Add(this.label5);
            this.grpCafeMenuItemSearch.Controls.Add(this.txtSearchCafeMenuItemCategory);
            this.grpCafeMenuItemSearch.Controls.Add(this.label6);
            this.grpCafeMenuItemSearch.Controls.Add(this.txtSearchCafeMenuItemName);
            this.grpCafeMenuItemSearch.Location = new System.Drawing.Point(16, 207);
            this.grpCafeMenuItemSearch.Name = "grpCafeMenuItemSearch";
            this.grpCafeMenuItemSearch.Size = new System.Drawing.Size(841, 51);
            this.grpCafeMenuItemSearch.TabIndex = 13;
            this.grpCafeMenuItemSearch.TabStop = false;
            this.grpCafeMenuItemSearch.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search by menu category";
            // 
            // txtSearchCafeMenuItemCategory
            // 
            this.txtSearchCafeMenuItemCategory.Location = new System.Drawing.Point(478, 18);
            this.txtSearchCafeMenuItemCategory.Name = "txtSearchCafeMenuItemCategory";
            this.txtSearchCafeMenuItemCategory.Size = new System.Drawing.Size(187, 20);
            this.txtSearchCafeMenuItemCategory.TabIndex = 9;
            this.txtSearchCafeMenuItemCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCafeMenuItemCategory_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search by Item Name";
            // 
            // txtSearchCafeMenuItemName
            // 
            this.txtSearchCafeMenuItemName.Location = new System.Drawing.Point(130, 18);
            this.txtSearchCafeMenuItemName.Name = "txtSearchCafeMenuItemName";
            this.txtSearchCafeMenuItemName.Size = new System.Drawing.Size(187, 20);
            this.txtSearchCafeMenuItemName.TabIndex = 7;
            this.txtSearchCafeMenuItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCafeMenuItemName_KeyUp);
            // 
            // grpCafeMenuItemAdd
            // 
            this.grpCafeMenuItemAdd.Controls.Add(this.label9);
            this.grpCafeMenuItemAdd.Controls.Add(this.listViewImages);
            this.grpCafeMenuItemAdd.Controls.Add(this.rdbIsItemAvailable);
            this.grpCafeMenuItemAdd.Controls.Add(this.label8);
            this.grpCafeMenuItemAdd.Controls.Add(this.txtCafeMenuItemDescripton);
            this.grpCafeMenuItemAdd.Controls.Add(this.label7);
            this.grpCafeMenuItemAdd.Controls.Add(this.txtCafeMenuItemPrice);
            this.grpCafeMenuItemAdd.Controls.Add(this.cmbMenuCategory);
            this.grpCafeMenuItemAdd.Controls.Add(this.label4);
            this.grpCafeMenuItemAdd.Controls.Add(this.label3);
            this.grpCafeMenuItemAdd.Controls.Add(this.cmbMenuItemSize);
            this.grpCafeMenuItemAdd.Controls.Add(this.btnAddCafeMenuItem);
            this.grpCafeMenuItemAdd.Controls.Add(this.txtCafeMenuItem);
            this.grpCafeMenuItemAdd.Controls.Add(this.label2);
            this.grpCafeMenuItemAdd.Controls.Add(this.cmbMenuItemSizeCategory);
            this.grpCafeMenuItemAdd.Controls.Add(this.label1);
            this.grpCafeMenuItemAdd.Location = new System.Drawing.Point(13, 15);
            this.grpCafeMenuItemAdd.Name = "grpCafeMenuItemAdd";
            this.grpCafeMenuItemAdd.Size = new System.Drawing.Size(844, 186);
            this.grpCafeMenuItemAdd.TabIndex = 4;
            this.grpCafeMenuItemAdd.TabStop = false;
            this.grpCafeMenuItemAdd.Text = "Add Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Item Icon";
            // 
            // listViewImages
            // 
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(100, 92);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(659, 77);
            this.listViewImages.TabIndex = 7;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            // 
            // rdbIsItemAvailable
            // 
            this.rdbIsItemAvailable.AutoSize = true;
            this.rdbIsItemAvailable.Checked = true;
            this.rdbIsItemAvailable.Location = new System.Drawing.Point(729, 29);
            this.rdbIsItemAvailable.Name = "rdbIsItemAvailable";
            this.rdbIsItemAvailable.Size = new System.Drawing.Size(91, 17);
            this.rdbIsItemAvailable.TabIndex = 3;
            this.rdbIsItemAvailable.TabStop = true;
            this.rdbIsItemAvailable.Text = "Item Available";
            this.rdbIsItemAvailable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "descripton";
            // 
            // txtCafeMenuItemDescripton
            // 
            this.txtCafeMenuItemDescripton.Location = new System.Drawing.Point(541, 61);
            this.txtCafeMenuItemDescripton.Name = "txtCafeMenuItemDescripton";
            this.txtCafeMenuItemDescripton.Size = new System.Drawing.Size(279, 20);
            this.txtCafeMenuItemDescripton.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item price";
            // 
            // txtCafeMenuItemPrice
            // 
            this.txtCafeMenuItemPrice.Location = new System.Drawing.Point(333, 61);
            this.txtCafeMenuItemPrice.Name = "txtCafeMenuItemPrice";
            this.txtCafeMenuItemPrice.Size = new System.Drawing.Size(130, 20);
            this.txtCafeMenuItemPrice.TabIndex = 5;
            // 
            // cmbMenuCategory
            // 
            this.cmbMenuCategory.FormattingEnabled = true;
            this.cmbMenuCategory.Location = new System.Drawing.Point(100, 29);
            this.cmbMenuCategory.Name = "cmbMenuCategory";
            this.cmbMenuCategory.Size = new System.Drawing.Size(130, 21);
            this.cmbMenuCategory.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Menu category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Item Name";
            // 
            // cmbMenuItemSize
            // 
            this.cmbMenuItemSize.FormattingEnabled = true;
            this.cmbMenuItemSize.Location = new System.Drawing.Point(541, 29);
            this.cmbMenuItemSize.Name = "cmbMenuItemSize";
            this.cmbMenuItemSize.Size = new System.Drawing.Size(130, 21);
            this.cmbMenuItemSize.TabIndex = 2;
            // 
            // btnAddCafeMenuItem
            // 
            this.btnAddCafeMenuItem.Image = global::CafeManager.Properties.Resources.add_50px;
            this.btnAddCafeMenuItem.Location = new System.Drawing.Point(765, 114);
            this.btnAddCafeMenuItem.Name = "btnAddCafeMenuItem";
            this.btnAddCafeMenuItem.Size = new System.Drawing.Size(55, 55);
            this.btnAddCafeMenuItem.TabIndex = 8;
            this.btnAddCafeMenuItem.UseVisualStyleBackColor = true;
            this.btnAddCafeMenuItem.Click += new System.EventHandler(this.btnAddCafeMenuItem_Click);
            // 
            // txtCafeMenuItem
            // 
            this.txtCafeMenuItem.Location = new System.Drawing.Point(100, 61);
            this.txtCafeMenuItem.Name = "txtCafeMenuItem";
            this.txtCafeMenuItem.Size = new System.Drawing.Size(130, 20);
            this.txtCafeMenuItem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Size";
            // 
            // cmbMenuItemSizeCategory
            // 
            this.cmbMenuItemSizeCategory.FormattingEnabled = true;
            this.cmbMenuItemSizeCategory.Location = new System.Drawing.Point(333, 28);
            this.cmbMenuItemSizeCategory.Name = "cmbMenuItemSizeCategory";
            this.cmbMenuItemSizeCategory.Size = new System.Drawing.Size(130, 21);
            this.cmbMenuItemSizeCategory.TabIndex = 1;
            this.cmbMenuItemSizeCategory.SelectedIndexChanged += new System.EventHandler(this.cmbMenuItemSizeCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size category";
            // 
            // MenuItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 522);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage menu Items";
            this.Load += new System.EventHandler(this.MenuItemForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCafeMenuItemList)).EndInit();
            this.grpCafeMenuItemSearch.ResumeLayout(false);
            this.grpCafeMenuItemSearch.PerformLayout();
            this.grpCafeMenuItemAdd.ResumeLayout(false);
            this.grpCafeMenuItemAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCafeMenuItemList;
        private System.Windows.Forms.GroupBox grpCafeMenuItemSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchCafeMenuItemName;
        private System.Windows.Forms.GroupBox grpCafeMenuItemAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMenuItemSize;
        private System.Windows.Forms.Button btnAddCafeMenuItem;
        private System.Windows.Forms.TextBox txtCafeMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMenuItemSizeCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenuCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchCafeMenuItemCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCafeMenuItemPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCafeMenuItemDescripton;
        private System.Windows.Forms.RadioButton rdbIsItemAvailable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewImages;
    }
}