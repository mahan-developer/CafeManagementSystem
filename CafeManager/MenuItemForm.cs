using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using CommonUtilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public partial class MenuItemForm : Form
    {   
        private readonly CafeMenuItemService _cafeMenuItemService;
        private readonly CafeMenuCategoryService _cafeMenuCategoryService;
        private readonly CafeMenuItemSizeCategoryService _cafeMenuItemCategoryService;
        private readonly CafeMenuItemSizeService _cafeMenuItemSizeService;
        public MenuItemForm(CafeMenuItemService cafeMenuItemService, CafeMenuCategoryService cafeMenuCategoryService, CafeMenuItemSizeCategoryService cafeMenuItemSizeCategoryService, CafeMenuItemSizeService cafeMenuItemSizeService)
        {
            InitializeComponent();
            _cafeMenuItemService = cafeMenuItemService;
            _cafeMenuCategoryService = cafeMenuCategoryService;
            _cafeMenuItemCategoryService = cafeMenuItemSizeCategoryService;
            _cafeMenuItemSizeService = cafeMenuItemSizeService;
        }


        private void LoadImagesToListView(string categoryPrefix)
        {
            // پاک کردن موارد قبلی
            listViewImages.Clear();

            // تعریف ImageList برای ListView
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(44, 52) // اندازه تصاویر
            };

            listViewImages.LargeImageList = imageList;

            // دریافت منابع
            var resourceManager = Properties.Resources.ResourceManager;
            var resourceSet = resourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

            int index = 0;
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceName = entry.Key.ToString();
                if (resourceName.StartsWith(categoryPrefix)) // فیلتر براساس پیشوند
                {
                    Image resourceImage = entry.Value as Image;
                    if (resourceImage != null)
                    {
                        imageList.Images.Add(resourceName, resourceImage);
                        listViewImages.Items.Add(new ListViewItem(resourceName, index++));
                    }
                }
            }

        }

        private async Task LoadCafeMenuCategoryAsync()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();
                List<CafeMenuCategory> cafeMenuCategory = await Task.Run(() => _cafeMenuCategoryService.GetCafeMenuCategories(searchParameters));
                cmbMenuCategory.DataSource = cafeMenuCategory;
                cmbMenuCategory.DisplayMember = "CafeMenuCategoryName";
                cmbMenuCategory.ValueMember = "CafeMenuCategoryID";
            }
            catch (Exception)
            {
                MessageBox.Show("Error in geting menu category information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      


        private async Task LoadCafeMenuItemSizeCategoryAsync()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();
                List<CafeMenuItemSizeCategory> cafeMenuItemSizeCategory = await Task.Run(() => _cafeMenuItemCategoryService.GetCafeMenuItemSizeCategories(searchParameters));
                cmbMenuItemSizeCategory.DataSource = cafeMenuItemSizeCategory;
                cmbMenuItemSizeCategory.DisplayMember = "CafeMenuItemSizeCategoryName";
                cmbMenuItemSizeCategory.ValueMember = "CafeMenuItemSizeCategoryID";
                cmbMenuItemSizeCategory.Text = string.Empty;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in geting Customers information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCafeMenuItemSizeDataAsync()
        {
            if (cmbMenuItemSizeCategory.SelectedValue != null)
                try
                {
                    var searchParameters = new Dictionary<string, object>();
                    searchParameters.Add("CafeMenuItemSizeCategoryID", (int)cmbMenuItemSizeCategory.SelectedValue);
                    List<CafeMenuItemSize> cafeMenuItemSize = await Task.Run(() => _cafeMenuItemSizeService.GetCafeMenuItemSize(searchParameters));
                    cmbMenuItemSize.DataSource = cafeMenuItemSize;
                    cmbMenuItemSize.DisplayMember = "CafeMenuItemSizeName";
                    cmbMenuItemSize.ValueMember = "CafeMenuItemSizeID";
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in geting menu item size information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }



        private void InitializeDataGridView()
        {
            //dgvCafeMenuItemList.CellFormatting += DgvCafeMenuItemList_CellFormatting;

            if (dgvCafeMenuItemList.Rows.Count != 0)
            {
                if (!dgvCafeMenuItemList.Columns.Contains("Delete"))
                {
                    DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Delete",
                        Name = "Delete",
                        Image = Properties.Resources.deletedgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvCafeMenuItemList.Columns.Add(deleteImageColumn);
                }

                if (!dgvCafeMenuItemList.Columns.Contains("Edit"))
                {
                    DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Edit",
                        Name = "Edit",
                        Image = Properties.Resources.editdgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvCafeMenuItemList.Columns.Add(editImageColumn);
                }

                if (dgvCafeMenuItemList.Columns.Contains("CafeMenuItemID"))
                {

                    dgvCafeMenuItemList.Columns["CafeMenuItemID"].ReadOnly = true;
                    dgvCafeMenuItemList.Columns["CafeMenuCategoryName"].ReadOnly = true;
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeName"].ReadOnly = true;
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeCategoryName"].ReadOnly = true;

                }
            }


        }


        private async Task LoadCafeMenuItemDataAsync()
        {
            try
            {

                // Fetch data from the service
                var searchParameters = new Dictionary<string, object>();
                List<CafeMenuItem> cafeMenuItem = await Task.Run(() => _cafeMenuItemService.GetCafeMenuItem(searchParameters));

                if (cafeMenuItem != null && cafeMenuItem.Any())
                {
                    dgvCafeMenuItemList.DataSource = null; // پاک کردن منبع داده
                    dgvCafeMenuItemList.Rows.Clear(); // پاک کردن ردیف‌ها
                    dgvCafeMenuItemList.Columns.Clear(); // پاک کردن ستون‌ها
                    // Bind data to the DataGridView
                    dgvCafeMenuItemList.DataSource = cafeMenuItem;

                    // Adjust column widths (modify based on actual fields in MenuItemSizeCategory)
                    dgvCafeMenuItemList.Columns["CafeMenuItemID"].Width = 50;
                    dgvCafeMenuItemList.Columns["CafeMenuItemID"].HeaderText = "ID";

                    dgvCafeMenuItemList.Columns["CafeMenuCategoryID"].Width = 50;
                    dgvCafeMenuItemList.Columns["CafeMenuCategoryID"].HeaderText = "Category ID";
                    dgvCafeMenuItemList.Columns["CafeMenuCategoryID"].Visible = false;

                    dgvCafeMenuItemList.Columns["CafeMenuCategoryName"].Width = 102;
                    dgvCafeMenuItemList.Columns["CafeMenuCategoryName"].HeaderText = "Category name";  
                    
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeCategoryID"].Width = 50;
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeCategoryID"].HeaderText = "Size Category Id";
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeCategoryID"].Visible=false;

                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeCategoryName"].Width = 100;
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeCategoryName"].HeaderText = "Category size";

                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeID"].Width = 50;
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeID"].HeaderText = "Item size ID";
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeID"].Visible = false;

                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeName"].Width = 90;
                    dgvCafeMenuItemList.Columns["CafeMenuItemSizeName"].HeaderText = "Item size";
                    dgvCafeMenuItemList.Columns["CafeMenuItemName"].Width = 90;
                    dgvCafeMenuItemList.Columns["CafeMenuItemName"].HeaderText = "Item name";
                    dgvCafeMenuItemList.Columns["CafeMenuItemPrice"].Width = 60;
                    dgvCafeMenuItemList.Columns["CafeMenuItemPrice"].HeaderText = "Price";
                    dgvCafeMenuItemList.Columns["CafeMenuItemIsAvailable"].Width = 54;
                    dgvCafeMenuItemList.Columns["CafeMenuItemIsAvailable"].HeaderText = "Available";
                    dgvCafeMenuItemList.Columns["CafeMenuItemDescripton"].Width = 125;
                    dgvCafeMenuItemList.Columns["CafeMenuItemDescripton"].HeaderText = "Descripton";
                    dgvCafeMenuItemList.Columns["CafeMenuItemImage"].Width = 50;
                    dgvCafeMenuItemList.Columns["CafeMenuItemImage"].HeaderText = "Image";
                    dgvCafeMenuItemList.Columns["CafeMenuItemImage"].Visible = false;


                    //if (dgvCafeMenuItemList.Columns.Contains("CafeMenuItemImage"))
                    //{
                    //    dgvCafeMenuItemList.Columns.Remove("CafeMenuItemImage");
                    //}

                    // اضافه کردن ستون تصویر
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                    {
                        Name = "CafeMenuItemImage2",
                        HeaderText = "Image",
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvCafeMenuItemList.Columns.Add(imageColumn);

                    // تبدیل نام تصویر به خود تصویر
                    foreach (DataGridViewRow row in dgvCafeMenuItemList.Rows)
                    {
                        var menuItem = row.DataBoundItem as CafeMenuItem;
                        if (menuItem != null)
                        {
                            var image = Properties.Resources.ResourceManager.GetObject(menuItem.CafeMenuItemImage) as Image;
                            row.Cells["CafeMenuItemImage2"].Value = image;
                        }
                    }


                    InitializeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in retrieving Menu Item Size Categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task SearchAndDisplayItem()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();

                if (!string.IsNullOrWhiteSpace(txtSearchCafeMenuItemName.Text))
                {
                    searchParameters.Add("CafeMenuItemName", txtSearchCafeMenuItemName.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtSearchCafeMenuItemCategory.Text))
                {
                    searchParameters.Add("CafeMenuCategoryName", txtSearchCafeMenuItemCategory.Text);
                }


                var cafeMenuItemList = await Task.Run(() => _cafeMenuItemService.GetCafeMenuItem(searchParameters));

                dgvCafeMenuItemList.DataSource = cafeMenuItemList;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //private string ShowImageSelectionDialog(string currentImage)
        //{
        //    using (Form imageDialog = new Form())
        //    {
        //        imageDialog.Text = "Select Image";
        //        imageDialog.Size = new Size(400, 300);

        //        // ListBox برای نمایش تصاویر
        //        ListBox imageListBox = new ListBox
        //        {
        //            Dock = DockStyle.Fill
        //        };

        //        // گرفتن لیست تصاویر از منابع
        //        var resourceManager = Properties.Resources.ResourceManager;
        //        var resourceSet = resourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

        //        foreach (DictionaryEntry entry in resourceSet)
        //        {
        //            string resourceName = entry.Key.ToString();
        //            if (!string.IsNullOrEmpty(resourceName) && resourceName.StartsWith("cat_"))
        //            {
        //                imageListBox.Items.Add(resourceName);
        //            }
        //        }

        //        // انتخاب پیش‌فرض
        //        if (!string.IsNullOrEmpty(currentImage))
        //        {
        //            imageListBox.SelectedItem = currentImage;
        //        }

        //        // دکمه OK
        //        Button btnOk = new Button
        //        {
        //            Text = "OK",
        //            Dock = DockStyle.Bottom
        //        };
        //        btnOk.Click += (s, e) => { imageDialog.DialogResult = DialogResult.OK; imageDialog.Close(); };

        //        // اضافه کردن کنترل‌ها به دیالوگ
        //        imageDialog.Controls.Add(imageListBox);
        //        imageDialog.Controls.Add(btnOk);

        //        // نمایش دیالوگ
        //        if (imageDialog.ShowDialog() == DialogResult.OK && imageListBox.SelectedItem != null)
        //        {
        //            return imageListBox.SelectedItem.ToString();
        //        }
        //    }

        //    return currentImage; // اگر تغییری اعمال نشد، مقدار قبلی را برگردانید
        //}


        private string ShowImageSelectionDialog(string currentImage)
        {
            using (Form imageDialog = new Form())
            {
                imageDialog.Text = "Select Image";
                imageDialog.Size = new Size(400, 300);

                

                // ListBox برای نمایش تصاویر
                ListView imageListMain = new ListView
                {
                    View = View.LargeIcon,
                    Dock = DockStyle.Fill
                };

                ImageList imageList = new ImageList
                {
                    ImageSize = new Size(44, 52) // اندازه تصاویر
                };

                imageListMain.LargeImageList = imageList;

                // گرفتن لیست تصاویر از منابع
                var resourceManager = Properties.Resources.ResourceManager;
                var resourceSet = resourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

                int index = 0;
                
                foreach (DictionaryEntry entry in resourceSet)
                {
                    string resourceName = entry.Key.ToString();
                    if (resourceName.StartsWith("cat_")) // فیلتر براساس پیشوند
                    {
                        Image resourceImage = entry.Value as Image;
                        if (resourceImage != null)
                        {
                            imageList.Images.Add(resourceName, resourceImage);
                            imageListMain.Items.Add(new ListViewItem(resourceName, index++));
                        }
                    }
                }

                // تنظیم تصویر انتخاب‌شده فعلی
                if (!string.IsNullOrEmpty(currentImage))
                {
                    foreach (ListViewItem item in imageListMain.Items)
                    {
                        if (item.Text == currentImage)
                        {
                            item.Selected = true;
                            item.Focused = true;
                            imageListMain.EnsureVisible(item.Index);
                            break;
                        }
                    }
                }



                // دکمه OK
                Button btnOk = new Button
                {
                    Text = "OK",
                    Dock = DockStyle.Bottom
                };
                btnOk.Click += (s, e) => { imageDialog.DialogResult = DialogResult.OK; imageDialog.Close(); };

                // اضافه کردن کنترل‌ها به دیالوگ
                imageDialog.Controls.Add(imageListMain);
                imageDialog.Controls.Add(btnOk);

                if (imageDialog.ShowDialog() == DialogResult.OK && imageListMain.SelectedItems.Count > 0)
                {
                    return imageListMain.SelectedItems[0].Text; // نام تصویر انتخاب‌شده
                }
            }

            return currentImage; // اگر تغییری اعمال نشد، مقدار قبلی را برگردانید
        }






        private async void MenuItemForm_Load(object sender, EventArgs e)
        {
            
            await LoadCafeMenuCategoryAsync();
            await LoadCafeMenuItemSizeCategoryAsync();
            await LoadCafeMenuItemDataAsync();
            LoadImagesToListView("cat_");
            InitializeDataGridView();
        }

        private async void cmbMenuItemSizeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenuItemSizeCategory.SelectedValue is int selectedValue)
                await LoadCafeMenuItemSizeDataAsync();
        }

        private async void btnAddCafeMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlHelper.AreControlsFilled(cmbMenuCategory,cmbMenuItemSize,cmbMenuItemSizeCategory, txtCafeMenuItem))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var searchParameters = new Dictionary<string, object>();
                    searchParameters.Add("CafeMenuCategoryName", cmbMenuCategory.Text);

                    List<string> cafeMenuItem = await Task.Run(() => _cafeMenuItemService.GetCafeMenuItem(searchParameters).Select(item => item.CafeMenuItemName).Distinct().ToList());


                    if (cafeMenuItem.Count > 19)
                        MessageBox.Show("You allow to add just 20 items in each category", "Item register Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        bool isItemavailable = true;
                        if (rdbIsItemAvailable.Checked)
                            isItemavailable = true;
                        else isItemavailable = false;



                        var initialcafeMenuItem = new CafeMenuItem
                        {
                            CafeMenuCategoryID = (int)cmbMenuCategory.SelectedValue,
                            CafeMenuCategoryName = cmbMenuCategory.Text,
                            CafeMenuItemSizeCategoryID = (int)cmbMenuItemSizeCategory.SelectedValue,
                            CafeMenuItemSizeCategoryName = cmbMenuItemSizeCategory.Text,
                            CafeMenuItemSizeID = (int)cmbMenuItemSize.SelectedValue,
                            CafeMenuItemSizeName = cmbMenuItemSize.Text,
                            CafeMenuItemName = txtCafeMenuItem.Text,
                            CafeMenuItemPrice = decimal.Parse(txtCafeMenuItemPrice.Text),
                            CafeMenuItemIsAvailable = isItemavailable,
                            CafeMenuItemDescripton = txtCafeMenuItemDescripton.Text,
                            CafeMenuItemImage = listViewImages.SelectedItems[0].Text
                        };


                        bool isAdded = await Task.Run(() => _cafeMenuItemService.AddCafeMenuItem(initialcafeMenuItem));

                        if (isAdded)
                        {
                            MessageBox.Show("New menu item is added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadCafeMenuItemDataAsync();
                            ControlHelper.ClearControlsInContainer(grpCafeMenuItemAdd);
                        }
                        else
                        {
                            MessageBox.Show("Error during add menu item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Menu item is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvCafeMenuItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (dgvCafeMenuItemList.Columns[e.ColumnIndex].Name == "Delete")
            {
                int cafeMenuItemID = Convert.ToInt32(dgvCafeMenuItemList.Rows[e.RowIndex].Cells["CafeMenuItemID"].Value);


                var confirmResult = MessageBox.Show("Are you sure you want to delete this item? \n This may cause program disruption.",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await Task.Run(() => _cafeMenuItemService.DeleteCafeMenuItem(cafeMenuItemID));
                    MessageBox.Show("Menu item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCafeMenuItemDataAsync();
                    ControlHelper.ClearControlsInContainer(grpCafeMenuItemSearch);
                }

            }


            string selectedImageName;
            if (dgvCafeMenuItemList.Columns[e.ColumnIndex].Name == "Edit")
            {
                int cafeMenuItemID = Convert.ToInt32(dgvCafeMenuItemList.Rows[e.RowIndex].Cells["CafeMenuItemID"].Value);

                var selectedRow = dgvCafeMenuItemList.Rows[e.RowIndex];
                var cafeMenuItem = new CafeMenuItem
                {
                    CafeMenuItemID = cafeMenuItemID,
                    CafeMenuCategoryID = Convert.ToInt32(selectedRow.Cells["CafeMenuCategoryID"].Value.ToString()),
                    CafeMenuCategoryName = selectedRow.Cells["CafeMenuCategoryName"].Value.ToString(),
                    CafeMenuItemSizeCategoryID = Convert.ToInt32(selectedRow.Cells["CafeMenuItemSizeCategoryID"].Value.ToString()),
                    CafeMenuItemSizeCategoryName = selectedRow.Cells["CafeMenuItemSizeCategoryName"].Value.ToString(),
                    CafeMenuItemSizeID = Convert.ToInt32(selectedRow.Cells["CafeMenuItemSizeID"].Value.ToString()),
                    CafeMenuItemSizeName = selectedRow.Cells["CafeMenuItemSizeName"].Value.ToString(),
                    CafeMenuItemName = selectedRow.Cells["CafeMenuItemName"].Value.ToString(),
                    CafeMenuItemPrice = Convert.ToDecimal(selectedRow.Cells["CafeMenuItemPrice"].Value.ToString()),
                    CafeMenuItemIsAvailable = Convert.ToBoolean(selectedRow.Cells["CafeMenuItemIsAvailable"].Value.ToString()),
                    CafeMenuItemDescripton = selectedRow.Cells["CafeMenuItemDescripton"].Value.ToString(),
                    CafeMenuItemImage = selectedRow.Cells["CafeMenuItemImage"].Value.ToString()
                };
                var confirmResult = MessageBox.Show("Are you sure you want to Edit this item? \n This may cause program disruption.",
                                              "Confirm Edit",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await Task.Run(() => _cafeMenuItemService.EditCafeMenuItem(cafeMenuItem));
                    MessageBox.Show("Menu item edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCafeMenuItemDataAsync();
                    ControlHelper.ClearControlsInContainer(grpCafeMenuItemSearch);
                }

               
            }




            if (e.RowIndex >= 0 && dgvCafeMenuItemList.Columns[e.ColumnIndex].Name == "CafeMenuItemImage2")
            {
                // گرفتن نام تصویر فعلی
                string currentImage = dgvCafeMenuItemList.Rows[e.RowIndex].Cells["CafeMenuItemImage"].Value?.ToString();

                // باز کردن دیالوگ انتخاب تصویر
                selectedImageName  = ShowImageSelectionDialog(currentImage);

                if (!string.IsNullOrEmpty(selectedImageName))
                {
                    // به‌روزرسانی مقدار سلول
                    dgvCafeMenuItemList.Rows[e.RowIndex].Cells["CafeMenuItemImage"].Value = selectedImageName;
                    var image = Properties.Resources.ResourceManager.GetObject(selectedImageName) as Image;
                    dgvCafeMenuItemList.Rows[e.RowIndex].Cells["CafeMenuItemImage2"].Value = image;

                }
            }




        }



        
        private async void txtSearchCafeMenuItemName_KeyUp(object sender, KeyEventArgs e)
        {
            await SearchAndDisplayItem();
        }

        private async void txtSearchCafeMenuItemCategory_KeyUp(object sender, KeyEventArgs e)
        {
            await SearchAndDisplayItem();
        }

    }
}
