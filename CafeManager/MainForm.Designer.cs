namespace CafeManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rbnMain = new System.Windows.Forms.Ribbon();
            this.rbnTabSales = new System.Windows.Forms.RibbonTab();
            this.rbnPanSale = new System.Windows.Forms.RibbonPanel();
            this.rbnTabReports = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbnTabDefinition = new System.Windows.Forms.RibbonTab();
            this.rbnPanCustomer = new System.Windows.Forms.RibbonPanel();
            this.rbnPanMenuItem = new System.Windows.Forms.RibbonPanel();
            this.rbnPanItemSize = new System.Windows.Forms.RibbonPanel();
            this.rbnPanSizeCategory = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbnTabSettings = new System.Windows.Forms.RibbonTab();
            this.rbnPanDatabaseConnection = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // rbnMain
            // 
            this.rbnMain.CaptionBarVisible = false;
            this.rbnMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbnMain.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.Minimized = false;
            this.rbnMain.Name = "rbnMain";
            // 
            // 
            // 
            this.rbnMain.OrbDropDown.BorderRoundness = 8;
            this.rbnMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.OrbDropDown.Name = "";
            this.rbnMain.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.rbnMain.OrbDropDown.TabIndex = 0;
            this.rbnMain.OrbVisible = false;
            // 
            // 
            // 
            this.rbnMain.QuickAccessToolbar.DropDownButtonVisible = false;
            this.rbnMain.QuickAccessToolbar.Value = "null";
            this.rbnMain.QuickAccessToolbar.Visible = false;
            this.rbnMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rbnMain.Size = new System.Drawing.Size(1462, 124);
            this.rbnMain.TabIndex = 0;
            this.rbnMain.Tabs.Add(this.rbnTabSales);
            this.rbnMain.Tabs.Add(this.rbnTabReports);
            this.rbnMain.Tabs.Add(this.rbnTabDefinition);
            this.rbnMain.Tabs.Add(this.rbnTabSettings);
            // 
            // rbnTabSales
            // 
            this.rbnTabSales.Name = "rbnTabSales";
            this.rbnTabSales.Panels.Add(this.rbnPanSale);
            this.rbnTabSales.Text = "Sales";
            // 
            // rbnPanSale
            // 
            this.rbnPanSale.ButtonMoreVisible = false;
            this.rbnPanSale.Items.Add(this.ribbonButton1);
            this.rbnPanSale.Name = "rbnPanSale";
            this.rbnPanSale.Text = "Sales";
            // 
            // rbnTabReports
            // 
            this.rbnTabReports.Name = "rbnTabReports";
            this.rbnTabReports.Panels.Add(this.ribbonPanel2);
            this.rbnTabReports.Text = "Reports";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // rbnTabDefinition
            // 
            this.rbnTabDefinition.Name = "rbnTabDefinition";
            this.rbnTabDefinition.Panels.Add(this.rbnPanCustomer);
            this.rbnTabDefinition.Panels.Add(this.rbnPanMenuItem);
            this.rbnTabDefinition.Panels.Add(this.rbnPanItemSize);
            this.rbnTabDefinition.Panels.Add(this.rbnPanSizeCategory);
            this.rbnTabDefinition.Panels.Add(this.ribbonPanel1);
            this.rbnTabDefinition.Text = "Definitions";
            // 
            // rbnPanCustomer
            // 
            this.rbnPanCustomer.ButtonMoreVisible = false;
            this.rbnPanCustomer.Items.Add(this.ribbonButton2);
            this.rbnPanCustomer.Name = "rbnPanCustomer";
            this.rbnPanCustomer.Text = "Customer";
            // 
            // rbnPanMenuItem
            // 
            this.rbnPanMenuItem.ButtonMoreVisible = false;
            this.rbnPanMenuItem.Items.Add(this.ribbonButton3);
            this.rbnPanMenuItem.Name = "rbnPanMenuItem";
            this.rbnPanMenuItem.Text = "Menu Items";
            // 
            // rbnPanItemSize
            // 
            this.rbnPanItemSize.ButtonMoreVisible = false;
            this.rbnPanItemSize.Items.Add(this.ribbonButton4);
            this.rbnPanItemSize.Name = "rbnPanItemSize";
            this.rbnPanItemSize.Text = "Items Size";
            // 
            // rbnPanSizeCategory
            // 
            this.rbnPanSizeCategory.ButtonMoreVisible = false;
            this.rbnPanSizeCategory.Items.Add(this.ribbonButton5);
            this.rbnPanSizeCategory.Name = "rbnPanSizeCategory";
            this.rbnPanSizeCategory.Text = "Size Category";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton7);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Menu Category";
            // 
            // rbnTabSettings
            // 
            this.rbnTabSettings.Name = "rbnTabSettings";
            this.rbnTabSettings.Panels.Add(this.rbnPanDatabaseConnection);
            this.rbnTabSettings.Panels.Add(this.ribbonPanel3);
            this.rbnTabSettings.Text = "Settings";
            // 
            // rbnPanDatabaseConnection
            // 
            this.rbnPanDatabaseConnection.ButtonMoreVisible = false;
            this.rbnPanDatabaseConnection.Items.Add(this.ribbonButton6);
            this.rbnPanDatabaseConnection.Name = "rbnPanDatabaseConnection";
            this.rbnPanDatabaseConnection.Text = "Database Connection";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.ribbonButton8);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Shop Information";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MinimumSize = new System.Drawing.Size(120, 70);
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.MinimumSize = new System.Drawing.Size(120, 70);
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::CafeManager.Properties.Resources.menu;
            this.ribbonButton3.LargeImage = global::CafeManager.Properties.Resources.menu;
            this.ribbonButton3.MinimumSize = new System.Drawing.Size(120, 70);
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.MinimumSize = new System.Drawing.Size(120, 70);
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "";
            this.ribbonButton4.Click += new System.EventHandler(this.ribbonButton4_Click);
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = global::CafeManager.Properties.Resources.sizecategory;
            this.ribbonButton5.LargeImage = global::CafeManager.Properties.Resources.sizecategory;
            this.ribbonButton5.MinimumSize = new System.Drawing.Size(120, 70);
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "";
            this.ribbonButton5.Click += new System.EventHandler(this.ribbonButton5_Click);
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = global::CafeManager.Properties.Resources.menuItemCategory_70px;
            this.ribbonButton7.LargeImage = global::CafeManager.Properties.Resources.menuItemCategory_70px;
            this.ribbonButton7.Name = "ribbonButton7";
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "";
            this.ribbonButton7.Click += new System.EventHandler(this.ribbonButton7_Click);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = global::CafeManager.Properties.Resources.ManageDB_70px;
            this.ribbonButton6.LargeImage = global::CafeManager.Properties.Resources.ManageDB_70px;
            this.ribbonButton6.MinimumSize = new System.Drawing.Size(120, 70);
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "";
            this.ribbonButton6.Click += new System.EventHandler(this.ribbonButton6_Click);
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = global::CafeManager.Properties.Resources.shop_70px;
            this.ribbonButton8.LargeImage = global::CafeManager.Properties.Resources.shop_70px;
            this.ribbonButton8.MinimumSize = new System.Drawing.Size(120, 70);
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "sdfjnsnjdf";
            this.ribbonButton8.Click += new System.EventHandler(this.ribbonButton8_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 786);
            this.Controls.Add(this.rbnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab rbnTabSales;
        private System.Windows.Forms.RibbonTab rbnTabReports;
        private System.Windows.Forms.RibbonTab rbnTabDefinition;
        private System.Windows.Forms.RibbonPanel rbnPanSale;
        private System.Windows.Forms.RibbonTab rbnTabSettings;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel rbnPanCustomer;
        private System.Windows.Forms.RibbonPanel rbnPanDatabaseConnection;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.Ribbon rbnMain;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonPanel rbnPanMenuItem;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel rbnPanItemSize;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonPanel rbnPanSizeCategory;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton8;
    }
}

