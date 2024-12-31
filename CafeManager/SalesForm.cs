using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using CommonUtilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CafeManager.ControlLoader;

namespace CafeManager
{
    public partial class SalesForm : Form
    {
        private readonly DataLoader _dataLoader;
        private readonly CommonUtilities.ControlHelper _controlHelper;
        private readonly CafeMenuItemService _cafeMenuItemService;
        private readonly CafeMenuCategoryService _cafeMenuCategoryService;
        private readonly InvoiceService _cafeMenuInvoiceService;
        private readonly InvoiceItemService _cafeMenuInvoiceItemService;
        private readonly CustomerService _customerService;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblDescription;
        private Label lblAmount;
        private Label lblTodayInvoice;
        private Label lblCustomer;
        private DataGridView grid1;
        private TextBox txtTotalPrice;
        private TextBox textCustomer;
        private TextBox txtTodayInvoice;
        private Panel pnlDropdown;
        private Panel pnlDropdown2;
        private DataGridView dgvCustomer;
        private DataGridView dgvTodayInvoice;
        private RadioButton rdbCasch;
        private RadioButton rdbCard;
        private CheckBox chkToGo;
        private CheckBox chkPrintCustomer;
        private CheckBox chkPrintBar;
        private TextBox textDescription;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnNew;
        private Button btn;
        private TableLayoutPanel innerTable5;
        private DateTime invoiceDate;
        private int invoiceID;
        private int customerID;

        public SalesForm(CafeMenuItemService cafeMenuItemService, CafeMenuCategoryService cafeMenuCategoryService, InvoiceService cafeMenuInvoiceService, InvoiceItemService cafeMenuInvoiceItemService, CustomerService customerService)
        {
            _cafeMenuCategoryService = cafeMenuCategoryService;
            _cafeMenuItemService = cafeMenuItemService;
            _cafeMenuInvoiceService = cafeMenuInvoiceService;
            _cafeMenuInvoiceItemService = cafeMenuInvoiceItemService;
            _customerService = customerService;
            _dataLoader = new DataLoader(cafeMenuItemService, cafeMenuCategoryService, cafeMenuInvoiceService, cafeMenuInvoiceItemService, customerService);
            InitializeComponent();            
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!pnlDropdown.Bounds.Contains(PointToClient(Cursor.Position)) && !pnlDropdown2.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                pnlDropdown.Visible = false;
                pnlDropdown2.Visible = false;
            }
        }
        private void EnableFormClickOnAllControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                control.MouseDown += (s, e) => OnMouseDown(e);

                if (control.HasChildren)
                {
                    EnableFormClickOnAllControls(control);
                }
            }
        }



        public static CafeMenuItem ShowItemSizeDialog(List<CafeMenuItem> cafeMenuItems)
        {
            CafeMenuItem selectItem = null; 

         
            Form dialog = new Form
            {
                Text = "Select Item Size",
                Size = new System.Drawing.Size(400, 300),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle=FormBorderStyle.FixedSingle,
                MaximizeBox=false,
                MinimizeBox=false
                
            };
            int buttonX = 20;
            int buttonY = 20;
            int buttonWidth = 100;
            int buttonHeight = 40;
            int padding = 10;

           
     
            foreach (var item in cafeMenuItems)
            {         
                Button button = new Button
                {
                    Text = item.CafeMenuItemSizeName,
                    Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                    Location = new System.Drawing.Point(buttonX, buttonY)
                };                           
                buttonY += buttonHeight + padding;                           
                button.Click += (sender, e) =>
                {
                    selectItem = item;
                    dialog.Close();        
                };
                dialog.Controls.Add(button);
            }            

            dialog.ShowDialog();
            if (selectItem != null)
                return selectItem;
            else
                return null;
        }


        private void SetSelectedInvoice(DataGridViewRow selectedRow)
        {
            invoiceDate = DateTime.Parse(selectedRow.Cells["InvoiceDate"].Value.ToString());
            invoiceID = int.Parse(selectedRow.Cells["InvoiceID"].Value.ToString());
            customerID = int.Parse(selectedRow.Cells["CustomerID"].Value.ToString());

            textCustomer.Text = selectedRow.Cells["CustomerName"].Value.ToString();
            txtTotalPrice.Text = selectedRow.Cells["InvoicePrice"].Value.ToString();
            textDescription.Text = selectedRow.Cells["InvoiceDescripton"].Value.ToString();

            if (selectedRow.Cells["PaymentMethod"].Value.ToString() == "Cash")
                rdbCasch.Checked = true;
            else
                rdbCard.Checked = true;

            chkToGo.Checked = selectedRow.Cells["OrderMode"].Value.ToString() == "ToGo";

            txtTodayInvoice.Text = $"{invoiceDate:yyyy-MM-dd} - {textCustomer.Text} - {txtTotalPrice.Text}";
        }

        private void ConfigureFormForEdit()
        {
            btnAdd.Visible = false;
            innerTable5.Visible = true;
            pnlDropdown2.Visible = false;
            txtTodayInvoice.ReadOnly = true;
        }



        private void ConfigureGroup1Events()
        {
            textCustomer.Click += (s, e) =>
            {
                ControlLoader.SetDropdownPosition(pnlDropdown, textCustomer);
                pnlDropdown.Visible = true;
                var customerList = _dataLoader.LoadCustomers("");
                dgvCustomer.DataSource = customerList;
            };

            textCustomer.TextChanged += (s, e) =>
            {
                dgvCustomer.DataSource = _dataLoader.LoadCustomers(textCustomer.Text);
            };

            dgvCustomer.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dgvCustomer.Rows[e.RowIndex];
                    textCustomer.Text = selectedRow.Cells["LastName"].Value.ToString();
                    pnlDropdown.Visible = false;
                }
            };


            txtTodayInvoice.Click += (s, e) =>
            {
                ControlLoader.SetDropdownPosition(pnlDropdown2, txtTodayInvoice);
                pnlDropdown2.Visible = true;
                var todayInvoiceList = _dataLoader.LoadInvoices(DateTime.Now);
                dgvTodayInvoice.DataSource = todayInvoiceList;
            };


            dgvTodayInvoice.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvTodayInvoice.Rows[e.RowIndex];

                    SetSelectedInvoice(selectedRow);


                    var invoiceItems = _dataLoader.GetInvoiceItemsForGrid(invoiceID);

                    grid1.Rows.Clear();
                    foreach (var rowData in invoiceItems)
                    {
                        grid1.Rows.Add(rowData);
                    }

                    ConfigureFormForEdit();
                }
            };
        }




        private void ConfigureGroup2Events(CafeMenuItem item)
        {
            btn.Click += (s, e) =>
            {
                var itemsSizeList = _dataLoader.LoadCafeMenuItems()
                   .Where(i => i.CafeMenuItemName == item.CafeMenuItemName && i.CafeMenuItemSizeCategoryName == item.CafeMenuItemSizeCategoryName)
                   .GroupBy(i => i.CafeMenuItemSizeName)
                   .Select(group => group.First())
                   .ToList();

                CafeMenuItem selectedItem = ShowItemSizeDialog(itemsSizeList);
                if (selectedItem != null)
                {
                    foreach (DataGridViewRow dataRow in grid1.Rows)
                    {
                        if (dataRow.Cells["CafeMenuItemCategory"].Value.ToString() == selectedItem.CafeMenuCategoryName &&
                            dataRow.Cells["CafeMenuItemName"].Value.ToString() == selectedItem.CafeMenuItemName &&
                            dataRow.Cells["CafeMenuItemSizeName"].Value.ToString() == selectedItem.CafeMenuItemSizeName)
                        {
                            dataRow.Cells["Quantity"].Value = int.Parse(dataRow.Cells["Quantity"].Value.ToString()) + 1;
                            dataRow.Cells["ItemTotalPrice"].Value = decimal.Parse(dataRow.Cells["ItemTotalPrice"].Value.ToString()) + selectedItem.CafeMenuItemPrice;
                            return;
                        }
                    }

                    grid1.Rows.Add(grid1.Rows.Count + 1, 0, 0, selectedItem.CafeMenuItemID, selectedItem.CafeMenuCategoryName,
                                   selectedItem.CafeMenuItemName, selectedItem.CafeMenuItemSizeName, selectedItem.CafeMenuItemPrice, "1",
                                   selectedItem.CafeMenuItemPrice, DateTime.Now);
                }
            };
        }


        private void ConfigureGroup3Events(DataGridView grid)
        {
            grid.RowsRemoved += (s, e) =>
            {
                for (int i = 0; i < grid.Rows.Count; i++)
                    grid.Rows[i].Cells["RowID"].Value = i + 1;
            };

            grid.CellEndEdit += (s, e) =>
            {
                for (int i = 0; i < grid.Rows.Count; i++)
                    grid.Rows[i].Cells["ItemTotalPrice"].Value =
                        int.Parse(grid.Rows[i].Cells["Quantity"].Value.ToString()) *
                        decimal.Parse(grid.Rows[i].Cells["CafeMenuItemPrice"].Value.ToString());
            };

            grid.CellValueChanged += (s, e) =>
            {
                decimal totalPrice = 0;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    totalPrice += decimal.Parse(grid.Rows[i].Cells["ItemTotalPrice"].Value.ToString());
                }
                txtTotalPrice.Text = totalPrice.ToString();
            };

            grid.RowsAdded += (s, e) =>
            {
                decimal totalPrice = 0;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    totalPrice += decimal.Parse(grid.Rows[i].Cells["ItemTotalPrice"].Value.ToString());
                }
                txtTotalPrice.Text = totalPrice.ToString();
            };
        }


        private void ConfigureGroup4Events()
        {
            btnNew.Click += (sender, e) =>
            {
                CommonUtilities.ControlHelper.ClearControlsInContainer(groupBox3, groupBox4);
                txtTodayInvoice.Text = "New";
                textCustomer.Text = "Global";
                customerID = 1;
                rdbCasch.Checked = true;
                chkToGo.Checked = true;
                chkPrintCustomer.Checked = true;
                chkPrintBar.Checked = true;
                txtTotalPrice.Text = "0";
                textDescription.Text = string.Empty;
                innerTable5.Visible = false;
                btnAdd.Visible = true;
            };

            btnEdit.Click += async (sender, e) =>
            {
                try
                {
                    if (!CommonUtilities.ControlHelper.AreControlsFilled(grid1))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string iscach = "";
                        if (rdbCasch.Checked)
                            iscach = "Cash";
                        if (rdbCard.Checked)
                            iscach = "Card";

                        string orderMode = "";
                        if (chkToGo.Checked)
                            orderMode = "ToGo";
                        else
                            orderMode = "DineIn";

                        var initialInvoice = new Invoice
                        {
                            InvoiceID = invoiceID,
                            CustomerID = customerID,
                            CustomerName = textCustomer.Text,
                            InvoiceDate = invoiceDate,
                            InvoiceUpdateDate = DateTime.Now,
                            InvoicePrice = decimal.Parse(txtTotalPrice.Text),
                            PaymentMethod = iscach,
                            OrderMode = orderMode,
                            InvoiceDescripton = textDescription.Text
                        };
                        bool isUpdate = await Task.Run(() => _cafeMenuInvoiceService.EditInvoice(initialInvoice));


                        var oldItem = _dataLoader.LoadInvoiceItems(invoiceID);

                        for (int i = 0; i < oldItem.Count; i++)
                        {
                            bool isDelete = await Task.Run(() => _cafeMenuInvoiceItemService.DeleteInvoiceItem(oldItem[i].InvoiceItemID));
                        }


                        for (int i = 0; i < grid1.Rows.Count; i++)
                        {

                            var initialInvoiceItem = new InvoiceItem
                            {
                                InvoiceItemID = int.Parse(grid1.Rows[i].Cells["InvoiceItemID"].Value.ToString()),
                                InvoiceID = invoiceID,
                                CafeMenuItemID = int.Parse(grid1.Rows[i].Cells["CafeMenuItemID"].Value.ToString()),
                                CafeMenuItemCategory = grid1.Rows[i].Cells["CafeMenuItemCategory"].Value.ToString(),
                                CafeMenuItemName = grid1.Rows[i].Cells["CafeMenuItemName"].Value.ToString(),
                                CafeMenuItemSize = grid1.Rows[i].Cells["CafeMenuItemSizeName"].Value.ToString(),
                                Quantity = int.Parse(grid1.Rows[i].Cells["Quantity"].Value.ToString()),
                                CafeMenuItemPrice = decimal.Parse(grid1.Rows[i].Cells["CafeMenuItemPrice"].Value.ToString()),
                                ItemUpdateDate = DateTime.Now
                            };
                            bool isUpdate2 = await Task.Run(() => _cafeMenuInvoiceItemService.AddInvoiceItem(initialInvoiceItem));
                        }


                        if (isUpdate)
                        {
                            MessageBox.Show("Invoice is added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error during add invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        CommonUtilities.ControlHelper.ClearControlsInContainer(groupBox3, groupBox4);
                        txtTodayInvoice.Text = "New";
                        textCustomer.Text = "Global";
                        customerID = 1;
                        rdbCasch.Checked = true;
                        chkToGo.Checked = true;
                        chkPrintCustomer.Checked = true;
                        chkPrintBar.Checked = true;
                        txtTotalPrice.Text = "0";
                        textDescription.Text = string.Empty;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invoice is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnAdd.Click += async (sender, e) =>
            {
                if (txtTodayInvoice.Text == "New")
                {
                    try
                    {
                        if (!CommonUtilities.ControlHelper.AreControlsFilled(grid1))
                        {
                            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            string iscach = "";
                            if (rdbCasch.Checked)
                                iscach = "Cash";
                            if (rdbCard.Checked)
                                iscach = "Card";

                            string orderMode = "";
                            if (chkToGo.Checked)
                                orderMode = "ToGo";
                            else
                                orderMode = "DineIn";

                            var initialInvoice = new Invoice
                            {
                                CustomerID = customerID,
                                CustomerName = textCustomer.Text,
                                InvoiceDate = DateTime.Now,
                                InvoiceUpdateDate = DateTime.Now,
                                InvoicePrice = decimal.Parse(txtTotalPrice.Text),
                                PaymentMethod = iscach,
                                OrderMode = orderMode,
                                InvoiceDescripton = textDescription.Text
                            };
                            bool isAdded = await Task.Run(() => _cafeMenuInvoiceService.AddInvoice(initialInvoice));


                            for (int i = 0; i < grid1.Rows.Count; i++)
                            {
                                int maxID = _dataLoader.LoadInvoices(DateTime.Now.Date).Max(j => j.InvoiceID);
                                var initialInvoiceItem = new InvoiceItem
                                {
                                    InvoiceID = maxID,
                                    CafeMenuItemID = int.Parse(grid1.Rows[i].Cells["CafeMenuItemID"].Value.ToString()),
                                    CafeMenuItemCategory = grid1.Rows[i].Cells["CafeMenuItemCategory"].Value.ToString(),
                                    CafeMenuItemName = grid1.Rows[i].Cells["CafeMenuItemName"].Value.ToString(),
                                    CafeMenuItemSize = grid1.Rows[i].Cells["CafeMenuItemSizeName"].Value.ToString(),
                                    Quantity = int.Parse(grid1.Rows[i].Cells["Quantity"].Value.ToString()),
                                    CafeMenuItemPrice = decimal.Parse(grid1.Rows[i].Cells["CafeMenuItemPrice"].Value.ToString()),
                                    ItemUpdateDate = DateTime.Now
                                };
                                bool isAdded2 = await Task.Run(() => _cafeMenuInvoiceItemService.AddInvoiceItem(initialInvoiceItem));
                            }


                            if (isAdded)
                            {
                                MessageBox.Show("Invoice is added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error during add invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            CommonUtilities.ControlHelper.ClearControlsInContainer(groupBox3, groupBox4);
                            txtTodayInvoice.Text = "New";
                            textCustomer.Text = "Global";
                            customerID = 1;
                            rdbCasch.Checked = true;
                            chkToGo.Checked = true;
                            chkPrintCustomer.Checked = true;
                            chkPrintBar.Checked = true;
                            txtTotalPrice.Text = "0";
                            textDescription.Text = string.Empty;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invoice is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };
        }

      

        private Control CreateGroup1()
        {
            groupBox1 = ControlLoader.CreateGroupBox("groupBox1", DockStyle.Fill);
            TableLayoutPanel innerTable = ControlLoader.CreateTableLayoutPanel(4, 1, DockStyle.Fill, 0);

            innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            lblTodayInvoice = ControlLoader.CreateLabel("Today's orders", DockStyle.Fill, new Padding(0, 6, 0, 0), ContentAlignment.MiddleCenter, 8, FontStyle.Regular);
            txtTodayInvoice = ControlLoader.CreateTextBox("txtTodayInvoice", DockStyle.Fill, "New", true);
            lblCustomer = ControlLoader.CreateLabel("Customer", DockStyle.Fill, new Padding(20, 6, 0, 0), ContentAlignment.MiddleCenter, 8, FontStyle.Regular);
            textCustomer = ControlLoader.CreateTextBox("txtCustomer", DockStyle.Fill, "Global", false);

            pnlDropdown = ControlLoader.CreatePanel(BorderStyle.FixedSingle, false);

            dgvCustomer = ControlLoader.CreateDataGridView(true, DataGridViewAutoSizeColumnsMode.Fill);

            pnlDropdown2 = ControlLoader.CreatePanel(BorderStyle.FixedSingle, false);

            dgvTodayInvoice = ControlLoader.CreateDataGridView(true, DataGridViewAutoSizeColumnsMode.Fill);

            ConfigureGroup1Events();

            pnlDropdown.Controls.Add(dgvCustomer);
            pnlDropdown2.Controls.Add(dgvTodayInvoice);

            innerTable.Controls.Add(lblTodayInvoice, 0, 0);
            innerTable.Controls.Add(txtTodayInvoice, 1, 0);
            innerTable.Controls.Add(lblCustomer, 2, 0);
            innerTable.Controls.Add(textCustomer, 3, 0);

            groupBox1.Controls.Add(innerTable);

            this.Controls.Add(pnlDropdown);
            this.Controls.Add(pnlDropdown2);
            return groupBox1;
        }



        private Control CreateGroup2()
        {
            var cafeMenuCategories = _dataLoader.LoadCafeMenuCategories();

            groupBox2 = ControlLoader.CreateGroupBox("groupBox2", DockStyle.Fill);
            TableLayoutPanel innerTable2 = ControlLoader.CreateTableLayoutPanel(1, 1, DockStyle.Fill, 0);
            innerTable2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            TabControl tabControl = ControlLoader.CreateTabControl("tabCtr1", DockStyle.Fill, TabSizeMode.Fixed, new Size(100, 30));

            foreach (var category in cafeMenuCategories)
            {
                TabPage tabPage = ControlLoader.CreateTabPage($"tabPage{category.CafeMenuCategoryID}", category.CafeMenuCategoryName);
                TableLayoutPanel innerTab = ControlLoader.CreateTableLayoutPanel(10, 4, DockStyle.Fill, 0);
                innerTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
                innerTab.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                innerTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
                innerTab.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

                tabControl.TabPages.Add(tabPage);

                var cafeMenuItems = _dataLoader.LoadCafeMenuItems()
                    .Where(item => item.CafeMenuCategoryID == category.CafeMenuCategoryID)
                    .GroupBy(item => item.CafeMenuItemName)
                    .Select(group => group.First())
                    .ToList();

                for (var i = 0; i < 10; i++)
                {
                    innerTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                }

                int row = 0, col = 0;
                foreach (var item in cafeMenuItems)
                {
                    Label lbl = ControlLoader.CreateLabel(item.CafeMenuItemName, DockStyle.Fill, new Padding(0, 6, 0, 0), ContentAlignment.MiddleCenter, 8, FontStyle.Bold);

                    Image BackgroundImage = Properties.Resources.ResourceManager.GetObject(item.CafeMenuItemImage) as Image;
                    btn = ControlLoader.CreateButton($"btn_{item.CafeMenuItemID}", "", BackgroundImage, new Size(0, 0), new Padding(0), DockStyle.Fill);

                    btn.BackgroundImageLayout = ImageLayout.Center;

                    ConfigureGroup2Events(item);

                    innerTab.Controls.Add(lbl, col, row);
                    innerTab.Controls.Add(btn, col, row + 1);

                    col++;
                    if (col >= 10)
                    {
                        col = 0;
                        row += 2;
                    }
                }

                tabPage.Controls.Add(innerTab);
            }

            groupBox2.Controls.Add(tabControl);

            return groupBox2;
        }


        private Control CreateGroup3()
        {
            groupBox3 = ControlLoader.CreateGroupBox("groupBox3", DockStyle.Fill);

            TableLayoutPanel innerTable3 = ControlLoader.CreateTableLayoutPanel(1, 1, DockStyle.Fill, 0);

            var columns = new[]
            {
                ControlLoader.CreateGridColumn("RowID", "Row", 60, true),
                ControlLoader.CreateGridColumn("InvoiceItemID", "Row", 60, true, false),
                ControlLoader.CreateGridColumn("InvoiceID", "ItemID", 60, true, false),
                ControlLoader.CreateGridColumn("CafeMenuItemID", "ItemID", 60, true, false),
                ControlLoader.CreateGridColumn("CafeMenuItemCategory", "Category", (this.Width - 240) / 5, true),
                ControlLoader.CreateGridColumn("CafeMenuItemName", "Item Name", (this.Width - 240) / 5, true),
                ControlLoader.CreateGridColumn("CafeMenuItemSizeName", "Item Size", (this.Width - 240) / 5, true),
                ControlLoader.CreateGridColumn("CafeMenuItemPrice", "Price", (this.Width - 240) / 5, false, true),
                ControlLoader.CreateGridColumn("Quantity", "Quantity", 80, false , true),
                ControlLoader.CreateGridColumn("ItemTotalPrice", "Total Price", (this.Width - 240) / 5, false, true),
                ControlLoader.CreateGridColumn("ItemUpdateDate", "UpdateDate", 80, true, false)
            };
            grid1 = ControlLoader.CreateConfiguredDataGridView(columns, ConfigureGroup3Events);

            innerTable3.Controls.Add(grid1, 0, 0);

            groupBox3.Controls.Add(innerTable3);

            return groupBox3;
        }


        private Control CreateGroup4()
        {
            GroupBox groupBox4 = ControlLoader.CreateGroupBox("groupBox4", DockStyle.Fill);
            TableLayoutPanel innerTable4 = ControlLoader.CreateTableLayoutPanel(10, 1, DockStyle.Fill, 0);
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70));
            innerTable4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));

            lblDescription = ControlLoader.CreateLabel("Description", DockStyle.Fill, new Padding(0, 6, 0, 0), ContentAlignment.MiddleLeft, 10, FontStyle.Regular);
            textDescription = ControlLoader.CreateTextBox("txtInvoiceDescription", DockStyle.Fill, "", false);

            lblAmount = ControlLoader.CreateLabel("Total amount", DockStyle.Fill, new Padding(0, 6, 0, 0), ContentAlignment.MiddleLeft, 10, FontStyle.Regular);
            txtTotalPrice = ControlLoader.CreateTextBox("txtTotalInvoiceAamount", DockStyle.Fill, "0", false);

            rdbCasch = ControlLoader.CreateRadioButton("Casch", "rdbCach", true);
            rdbCard = ControlLoader.CreateRadioButton("Card", "rdbCard", false);

            chkToGo = ControlLoader.CreateCheckBox("To-Go", "chkToGo", true, DockStyle.Fill);
            chkPrintCustomer = ControlLoader.CreateCheckBox("Print customer invoice", "chkPrintCustomer", true, DockStyle.Fill);
            chkPrintBar = ControlLoader.CreateCheckBox("Print bar invoice", "chkPrintBar", true, DockStyle.Fill);

            btnAdd = ControlLoader.CreateButton("btnAddInvoice", "", Properties.Resources.add_lit, new Size(75, 28), new Padding(0, 0, 5, 0));

            innerTable5 = ControlLoader.CreateTableLayoutPanel(2, 1, DockStyle.Fill, 0);
            innerTable5.Width = 78;
            innerTable5.Height = 20;
            innerTable5.Visible = false;

            innerTable5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            innerTable5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            btnEdit = ControlLoader.CreateButton("btnEditInvoice", "", Properties.Resources.edit_20px, new Size(35, 28), new Padding(0, 0, 5, 0));
            btnNew = ControlLoader.CreateButton("btnNewInvoice", "", Properties.Resources.newForm_20px, new Size(35, 28), new Padding(0, 0, 5, 0));

            innerTable5.Controls.Add(btnEdit, 0, 0);
            innerTable5.Controls.Add(btnNew, 1, 0);

            ConfigureGroup4Events();

            innerTable4.Controls.Add(lblDescription, 0, 0);
            innerTable4.Controls.Add(textDescription, 1, 0);
            innerTable4.Controls.Add(lblAmount, 2, 0);
            innerTable4.Controls.Add(txtTotalPrice, 3, 0);
            innerTable4.Controls.Add(rdbCasch, 4, 0);
            innerTable4.Controls.Add(rdbCard, 5, 0);
            innerTable4.Controls.Add(chkToGo, 6, 0);
            innerTable4.Controls.Add(chkPrintCustomer, 7, 0);
            innerTable4.Controls.Add(chkPrintBar, 8, 0);
            innerTable4.Controls.Add(btnAdd, 9, 0);
            innerTable4.Controls.Add(innerTable5, 9, 0);
            groupBox4.Controls.Add(innerTable4);

            return groupBox4;
        }



        private void CreateLayout()
        {
            TableLayoutPanel mainTable = ControlLoader.CreateTableLayoutPanel(1, 4, DockStyle.Fill,10);

            if (this.Height>800)
            {
                mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 60));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            }
            if (this.Height < 800)
            {
                mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
                mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            }

            mainTable.Controls.Add(CreateGroup1(), 0, 0);
            mainTable.Controls.Add(CreateGroup2(), 0, 1);
            mainTable.Controls.Add(CreateGroup3(), 0, 2);
            mainTable.Controls.Add(CreateGroup4(), 0, 3);


            this.Controls.Add(mainTable);

            
        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            customerID = 1;
            CreateLayout();
            EnableFormClickOnAllControls(this);
        }

    }
}
