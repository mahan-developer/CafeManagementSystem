using BusinessApplicationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CafeManager
{
    public partial class MainForm : Form
    {
        private readonly List<string> tableNames = new List<string> { "CafeMenuItem", "Customer", "Invoice", "InvoiceItem", "CafeMenuItemSize", "CafeMenuItemSizeCategory", "CafeMenuCategory" };
        private readonly DatabaseInitializerService _dbService;
        private readonly SettingsService _settingsService;
        private readonly CustomerService _customerService;
        private readonly CafeMenuItemSizeCategoryService _cafeMenuItemSizeCategoryService;
        private readonly CafeMenuItemSizeService _cafeMenuItemSizeService;
        private readonly InvoiceService _invoiceService;
        private readonly InvoiceItemService _invoiceItemService;
        private readonly CafeMenuItemService _cafeMenuItemService;
        private readonly CafeMenuCategoryService _cafeMenuCategoryService;

        public string isLogin = "";

        public MainForm(DatabaseInitializerService dbService, SettingsService settingsService,
            CustomerService customerService, CafeMenuItemSizeCategoryService cafeMenuItemSizeCategoryService, CafeMenuItemSizeService cafeMenuItemSizeService,
            InvoiceService invoiceService, InvoiceItemService invoiceItemService, CafeMenuItemService cafeMenuItemService, CafeMenuCategoryService cafeMenuCategoryService)
        {
            InitializeComponent();
            
            _dbService = dbService;
            _settingsService = settingsService;
            _customerService = customerService;
            _cafeMenuItemSizeCategoryService = cafeMenuItemSizeCategoryService;
            _cafeMenuItemSizeService = cafeMenuItemSizeService;
            _invoiceService = invoiceService;
            _invoiceItemService = invoiceItemService;
            _cafeMenuItemService = cafeMenuItemService;
            _cafeMenuCategoryService = cafeMenuCategoryService;
        }

        public void DeactiveRBN()
        {

            if (_dbService.CheckDatabaseExists())
            {
                if (!_dbService.CheckTablesExist(tableNames))
                {
                    rbnMain.Tabs[0].Enabled = false;
                    rbnMain.Tabs[1].Enabled = false;
                    rbnMain.Tabs[2].Enabled = false;
                    rbnMain.ActiveTab = rbnTabSettings;
                }
            }
            else
            {
                rbnMain.Tabs[0].Enabled = false;
                rbnMain.Tabs[1].Enabled = false;
                rbnMain.Tabs[2].Enabled = false;
                rbnMain.ActiveTab = rbnTabSettings;
            }

        }
        public void ActiveRBN()
        {
            rbnMain.Tabs[0].Enabled = true;
            rbnMain.Tabs[1].Enabled = true;
            rbnMain.Tabs[2].Enabled = true;
            rbnMain.ActiveTab = rbnTabSales;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(isLogin=="")
            {
                LoginForm loginForm = new LoginForm(_settingsService);
                loginForm.Show();
                this.Visible = false;
            }
           
                
            string backgroundImagePath = GetSettingValueAsync(4);
            if (backgroundImagePath == "null")
            {
                this.BackgroundImage = Properties.Resources.HMK190;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                if (File.Exists(backgroundImagePath))
                {
                    this.BackgroundImage = Image.FromFile(backgroundImagePath);
                    ImageLayout layout = (ImageLayout)Enum.Parse(typeof(ImageLayout), GetSettingValueAsync(10), true);
                    this.BackgroundImageLayout = layout;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.HMK190;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(_customerService);
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            DatabaseForm databaseForm = new DatabaseForm(_dbService, _settingsService, _customerService);
            databaseForm.MdiParent = this;
            databaseForm.Show();
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            ItemSizeCategoryForm databaseForm = new ItemSizeCategoryForm(_cafeMenuItemSizeCategoryService);
            databaseForm.MdiParent = this;
            databaseForm.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            DeactiveRBN();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            ItemSizeForm itemSizeForm = new ItemSizeForm(_cafeMenuItemSizeCategoryService, _cafeMenuItemSizeService);
            itemSizeForm.MdiParent = this;
            itemSizeForm.Show();
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            MenuCategoryForm menuCategoryForm = new MenuCategoryForm(_cafeMenuCategoryService);
            menuCategoryForm.MdiParent = this;
            menuCategoryForm.Show();
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            MenuItemForm menuItemForm = new MenuItemForm(_cafeMenuItemService, _cafeMenuCategoryService, _cafeMenuItemSizeCategoryService, _cafeMenuItemSizeService);
            menuItemForm.MdiParent = this;
            menuItemForm.Show();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm(_cafeMenuItemService, _cafeMenuCategoryService, _invoiceService, _invoiceItemService,_customerService,_settingsService);
            salesForm.MdiParent = this;
            salesForm.Width = Screen.FromControl(this).WorkingArea.Width - 15;
            salesForm.Height = Screen.FromControl(this).WorkingArea.Height - 160;
            salesForm.Show();
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            ShopInformationForm shopInformationForm = new ShopInformationForm(_settingsService);
            shopInformationForm.MdiParent = this;
            shopInformationForm.Show();
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            SalesForm saleForm = new SalesForm(_cafeMenuItemService, _cafeMenuCategoryService, _invoiceService, _invoiceItemService, _customerService, _settingsService);
            SaleReportForm saleReportForm = new SaleReportForm(_invoiceService, saleForm, this);
            saleReportForm.MdiParent = this;
            saleReportForm.Show();
        }


        public void ShowSaleFormForEdit(DataGridViewRow selectedRow)
        {
            SalesForm salesForm = new SalesForm(_cafeMenuItemService, _cafeMenuCategoryService, _invoiceService, _invoiceItemService, _customerService, _settingsService);
            salesForm.reportGrid = selectedRow;
            salesForm.ShowDialog();
        }

       

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            GeneralSettingsForm generalSettingsForm = new GeneralSettingsForm(_settingsService);
            generalSettingsForm.MdiParent= this;
            generalSettingsForm.Show();
            
        }






        private string GetSettingValueAsync(int settingsId)
        {
            var searchParameters = new Dictionary<string, object> { { "SettingsID", settingsId } };

            var settings = _settingsService.GetSettingByField(searchParameters);

            return settings.FirstOrDefault()?.SettingsValue;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(GetSettingValueAsync(3) == "true")
            {
                string folderPath = GetSettingValueAsync(2);
                if (Directory.Exists(folderPath))
                {
                    string backupFileName = $"DatabaseBackup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                    string backupPath = System.IO.Path.Combine(folderPath, backupFileName);

                    try
                    {
                        if (_dbService.BackupDatabase(backupPath))
                        {
                            MessageBox.Show($"Backup created successfully.\nPath: {backupPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Directory for save auto backup is not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
                
        }

        
    }
}
