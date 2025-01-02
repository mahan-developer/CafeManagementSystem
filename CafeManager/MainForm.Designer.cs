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
            this.rbBtnSales = new System.Windows.Forms.RibbonButton();
            this.rbnTabReports = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnSearchInvoice = new System.Windows.Forms.RibbonButton();
            this.rbnTabDefinition = new System.Windows.Forms.RibbonTab();
            this.rbnPanCustomer = new System.Windows.Forms.RibbonPanel();
            this.rbBtnCustomerManage = new System.Windows.Forms.RibbonButton();
            this.rbnPanMenuItem = new System.Windows.Forms.RibbonPanel();
            this.rbBtnMenuItemManage = new System.Windows.Forms.RibbonButton();
            this.rbnPanItemSize = new System.Windows.Forms.RibbonPanel();
            this.rbBtnItemSizeManage = new System.Windows.Forms.RibbonButton();
            this.rbnPanSizeCategory = new System.Windows.Forms.RibbonPanel();
            this.rbBtnSizeCategoryManage = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnMenuCategoryManage = new System.Windows.Forms.RibbonButton();
            this.rbnTabSettings = new System.Windows.Forms.RibbonTab();
            this.rbnPanDatabaseConnection = new System.Windows.Forms.RibbonPanel();
            this.rbBtnDatabaseManage = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnShopInformation = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnGeneralSetting = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnAbout = new System.Windows.Forms.RibbonButton();
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
            this.rbnMain.Tabs.Add(this.ribbonTab1);
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
            this.rbnPanSale.Items.Add(this.rbBtnSales);
            this.rbnPanSale.Name = "rbnPanSale";
            this.rbnPanSale.Text = "Sales";
            // 
            // rbBtnSales
            // 
            this.rbBtnSales.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnSales.Image")));
            this.rbBtnSales.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnSales.LargeImage")));
            this.rbBtnSales.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnSales.Name = "rbBtnSales";
            this.rbBtnSales.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnSales.SmallImage")));
            this.rbBtnSales.Text = "";
            this.rbBtnSales.Click += new System.EventHandler(this.rbBtnSales_Click);
            // 
            // rbnTabReports
            // 
            this.rbnTabReports.Name = "rbnTabReports";
            this.rbnTabReports.Panels.Add(this.ribbonPanel2);
            this.rbnTabReports.Text = "Reports";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.rbBtnSearchInvoice);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Search invoice";
            // 
            // rbBtnSearchInvoice
            // 
            this.rbBtnSearchInvoice.Image = global::CafeManager.Properties.Resources.search_70px;
            this.rbBtnSearchInvoice.LargeImage = global::CafeManager.Properties.Resources.search_70px;
            this.rbBtnSearchInvoice.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnSearchInvoice.Name = "rbBtnSearchInvoice";
            this.rbBtnSearchInvoice.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnSearchInvoice.SmallImage")));
            this.rbBtnSearchInvoice.Text = "";
            this.rbBtnSearchInvoice.Click += new System.EventHandler(this.rbBtnSearchInvoice_Click);
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
            this.rbnPanCustomer.Items.Add(this.rbBtnCustomerManage);
            this.rbnPanCustomer.Name = "rbnPanCustomer";
            this.rbnPanCustomer.Text = "Customer";
            // 
            // rbBtnCustomerManage
            // 
            this.rbBtnCustomerManage.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnCustomerManage.Image")));
            this.rbBtnCustomerManage.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnCustomerManage.LargeImage")));
            this.rbBtnCustomerManage.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnCustomerManage.Name = "rbBtnCustomerManage";
            this.rbBtnCustomerManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnCustomerManage.SmallImage")));
            this.rbBtnCustomerManage.Text = "";
            this.rbBtnCustomerManage.Click += new System.EventHandler(this.rbBtnCustomerManage_Click);
            // 
            // rbnPanMenuItem
            // 
            this.rbnPanMenuItem.ButtonMoreVisible = false;
            this.rbnPanMenuItem.Items.Add(this.rbBtnMenuItemManage);
            this.rbnPanMenuItem.Name = "rbnPanMenuItem";
            this.rbnPanMenuItem.Text = "Menu Items";
            // 
            // rbBtnMenuItemManage
            // 
            this.rbBtnMenuItemManage.Image = global::CafeManager.Properties.Resources.menu;
            this.rbBtnMenuItemManage.LargeImage = global::CafeManager.Properties.Resources.menu;
            this.rbBtnMenuItemManage.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnMenuItemManage.Name = "rbBtnMenuItemManage";
            this.rbBtnMenuItemManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnMenuItemManage.SmallImage")));
            this.rbBtnMenuItemManage.Text = "";
            this.rbBtnMenuItemManage.Click += new System.EventHandler(this.rbBtnMenuItemManage_Click);
            // 
            // rbnPanItemSize
            // 
            this.rbnPanItemSize.ButtonMoreVisible = false;
            this.rbnPanItemSize.Items.Add(this.rbBtnItemSizeManage);
            this.rbnPanItemSize.Name = "rbnPanItemSize";
            this.rbnPanItemSize.Text = "Items Size";
            // 
            // rbBtnItemSizeManage
            // 
            this.rbBtnItemSizeManage.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnItemSizeManage.Image")));
            this.rbBtnItemSizeManage.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnItemSizeManage.LargeImage")));
            this.rbBtnItemSizeManage.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnItemSizeManage.Name = "rbBtnItemSizeManage";
            this.rbBtnItemSizeManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnItemSizeManage.SmallImage")));
            this.rbBtnItemSizeManage.Text = "";
            this.rbBtnItemSizeManage.Click += new System.EventHandler(this.rbBtnItemSizeManage_Click);
            // 
            // rbnPanSizeCategory
            // 
            this.rbnPanSizeCategory.ButtonMoreVisible = false;
            this.rbnPanSizeCategory.Items.Add(this.rbBtnSizeCategoryManage);
            this.rbnPanSizeCategory.Name = "rbnPanSizeCategory";
            this.rbnPanSizeCategory.Text = "Size Category";
            // 
            // rbBtnSizeCategoryManage
            // 
            this.rbBtnSizeCategoryManage.Image = global::CafeManager.Properties.Resources.sizecategory;
            this.rbBtnSizeCategoryManage.LargeImage = global::CafeManager.Properties.Resources.sizecategory;
            this.rbBtnSizeCategoryManage.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnSizeCategoryManage.Name = "rbBtnSizeCategoryManage";
            this.rbBtnSizeCategoryManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnSizeCategoryManage.SmallImage")));
            this.rbBtnSizeCategoryManage.Text = "";
            this.rbBtnSizeCategoryManage.Click += new System.EventHandler(this.rbBtnSizeCategoryManage_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbBtnMenuCategoryManage);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Menu Category";
            // 
            // rbBtnMenuCategoryManage
            // 
            this.rbBtnMenuCategoryManage.Image = global::CafeManager.Properties.Resources.menuItemCategory_70px;
            this.rbBtnMenuCategoryManage.LargeImage = global::CafeManager.Properties.Resources.menuItemCategory_70px;
            this.rbBtnMenuCategoryManage.Name = "rbBtnMenuCategoryManage";
            this.rbBtnMenuCategoryManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnMenuCategoryManage.SmallImage")));
            this.rbBtnMenuCategoryManage.Text = "";
            this.rbBtnMenuCategoryManage.Click += new System.EventHandler(this.rbBtnMenuCategoryManage_Click);
            // 
            // rbnTabSettings
            // 
            this.rbnTabSettings.Name = "rbnTabSettings";
            this.rbnTabSettings.Panels.Add(this.rbnPanDatabaseConnection);
            this.rbnTabSettings.Panels.Add(this.ribbonPanel3);
            this.rbnTabSettings.Panels.Add(this.ribbonPanel4);
            this.rbnTabSettings.Text = "Settings";
            // 
            // rbnPanDatabaseConnection
            // 
            this.rbnPanDatabaseConnection.ButtonMoreVisible = false;
            this.rbnPanDatabaseConnection.Items.Add(this.rbBtnDatabaseManage);
            this.rbnPanDatabaseConnection.Name = "rbnPanDatabaseConnection";
            this.rbnPanDatabaseConnection.Text = "Database Connection";
            // 
            // rbBtnDatabaseManage
            // 
            this.rbBtnDatabaseManage.Image = global::CafeManager.Properties.Resources.ManageDB_70px;
            this.rbBtnDatabaseManage.LargeImage = global::CafeManager.Properties.Resources.ManageDB_70px;
            this.rbBtnDatabaseManage.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnDatabaseManage.Name = "rbBtnDatabaseManage";
            this.rbBtnDatabaseManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnDatabaseManage.SmallImage")));
            this.rbBtnDatabaseManage.Text = "";
            this.rbBtnDatabaseManage.Click += new System.EventHandler(this.rbBtnDatabaseManage_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.rbBtnShopInformation);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Shop Information";
            // 
            // rbBtnShopInformation
            // 
            this.rbBtnShopInformation.Image = global::CafeManager.Properties.Resources.shop_70px;
            this.rbBtnShopInformation.LargeImage = global::CafeManager.Properties.Resources.shop_70px;
            this.rbBtnShopInformation.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnShopInformation.Name = "rbBtnShopInformation";
            this.rbBtnShopInformation.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnShopInformation.SmallImage")));
            this.rbBtnShopInformation.Text = "sdfjnsnjdf";
            this.rbBtnShopInformation.Click += new System.EventHandler(this.rbBtnShopInformation_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ButtonMoreVisible = false;
            this.ribbonPanel4.Items.Add(this.rbBtnGeneralSetting);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "General";
            // 
            // rbBtnGeneralSetting
            // 
            this.rbBtnGeneralSetting.Image = global::CafeManager.Properties.Resources.setting_70px;
            this.rbBtnGeneralSetting.LargeImage = global::CafeManager.Properties.Resources.setting_70px;
            this.rbBtnGeneralSetting.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnGeneralSetting.Name = "rbBtnGeneralSetting";
            this.rbBtnGeneralSetting.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnGeneralSetting.SmallImage")));
            this.rbBtnGeneralSetting.Text = "";
            this.rbBtnGeneralSetting.Click += new System.EventHandler(this.rbBtnGeneralSetting_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel5);
            this.ribbonTab1.Text = "Help";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ButtonMoreVisible = false;
            this.ribbonPanel5.Items.Add(this.rbBtnAbout);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "About";
            // 
            // rbBtnAbout
            // 
            this.rbBtnAbout.Image = global::CafeManager.Properties.Resources.about_70px;
            this.rbBtnAbout.LargeImage = global::CafeManager.Properties.Resources.about_70px;
            this.rbBtnAbout.MinimumSize = new System.Drawing.Size(120, 70);
            this.rbBtnAbout.Name = "rbBtnAbout";
            this.rbBtnAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAbout.SmallImage")));
            this.rbBtnAbout.Text = "";
            this.rbBtnAbout.Click += new System.EventHandler(this.rbBtnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1462, 786);
            this.Controls.Add(this.rbnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.RibbonButton rbBtnSales;
        private System.Windows.Forms.Ribbon rbnMain;
        private System.Windows.Forms.RibbonButton rbBtnCustomerManage;
        private System.Windows.Forms.RibbonPanel rbnPanMenuItem;
        private System.Windows.Forms.RibbonButton rbBtnMenuItemManage;
        private System.Windows.Forms.RibbonPanel rbnPanItemSize;
        private System.Windows.Forms.RibbonButton rbBtnItemSizeManage;
        private System.Windows.Forms.RibbonPanel rbnPanSizeCategory;
        private System.Windows.Forms.RibbonButton rbBtnSizeCategoryManage;
        private System.Windows.Forms.RibbonButton rbBtnDatabaseManage;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton rbBtnMenuCategoryManage;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton rbBtnShopInformation;
        private System.Windows.Forms.RibbonButton rbBtnSearchInvoice;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton rbBtnGeneralSetting;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton rbBtnAbout;
    }
}

