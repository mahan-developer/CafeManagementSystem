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
    public partial class ItemSizeForm : Form
    {
        private readonly CafeMenuItemSizeCategoryService _cafeMenuItemCategoryService;
        private readonly CafeMenuItemSizeService _cafeMenuItemSizeService;
        public ItemSizeForm(CafeMenuItemSizeCategoryService cafeMenuItemSizeCategoryService, CafeMenuItemSizeService cafeMenuItemSizeService)
        {
            InitializeComponent();
            _cafeMenuItemCategoryService= cafeMenuItemSizeCategoryService;
            _cafeMenuItemSizeService= cafeMenuItemSizeService;

        }

        private void InitializeDataGridView()
        {
            if (dgvCafeMenuItemSizeList.Rows.Count != 0)
            {
                if (!dgvCafeMenuItemSizeList.Columns.Contains("Delete"))
                {
                    DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Delete",
                        Name = "Delete",
                        Image = Properties.Resources.deletedgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvCafeMenuItemSizeList.Columns.Add(deleteImageColumn);
                }

                if (!dgvCafeMenuItemSizeList.Columns.Contains("Edit"))
                {
                    DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Edit",
                        Name = "Edit",
                        Image = Properties.Resources.editdgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvCafeMenuItemSizeList.Columns.Add(editImageColumn);
                }

                if (dgvCafeMenuItemSizeList.Columns.Contains("CafeMenuItemSizeID"))
                {

                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeID"].ReadOnly = true;

                }
            }


        }


        private async Task LoadCafeMenuItemSizeDataAsync()
        {
            try
            {
                // Fetch data from the service
                var searchParameters = new Dictionary<string, object>();
                List<CafeMenuItemSize> cafeMenuItemSize = await Task.Run(() => _cafeMenuItemSizeService.GetCafeMenuItemSize(searchParameters));

                if (cafeMenuItemSize != null && cafeMenuItemSize.Any())
                {
                    // Bind data to the DataGridView
                    dgvCafeMenuItemSizeList.DataSource = cafeMenuItemSize;

                    // Adjust column widths (modify based on actual fields in MenuItemSizeCategory)
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeID"].Width = 80;
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeID"].HeaderText = "ID";
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeCategoryID"].Width = 70;
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeCategoryID"].HeaderText = "Category Id";
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeCategoryID"].Visible = false;
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeCategoryName"].Width = 277;
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeCategoryName"].HeaderText = "Category name";
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeName"].Width = 277;
                    dgvCafeMenuItemSizeList.Columns["CafeMenuItemSizeName"].HeaderText = "Size name";
                                       

                    InitializeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in retrieving Menu Item Size Categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception)
            {
                MessageBox.Show("Error in geting Customers information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async Task SearchAndDisplayCategory()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();

                if (!string.IsNullOrWhiteSpace(txtSearchCafeMenuItemSizeName.Text))
                {
                    searchParameters.Add("CafeMenuItemSizeName", txtSearchCafeMenuItemSizeName.Text);
                }


                var cafeMenuItemSizeList = await Task.Run(() => _cafeMenuItemSizeService.GetCafeMenuItemSize(searchParameters));

                dgvCafeMenuItemSizeList.DataSource = cafeMenuItemSizeList;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private async void ItemSizeForm_Load(object sender, EventArgs e)
        {
            await LoadCafeMenuItemSizeCategoryAsync();
            await LoadCafeMenuItemSizeDataAsync();
            InitializeDataGridView();
        }

        private async void btnAddCafeMenuItemSize_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlHelper.AreControlsFilled(cmbMenuItemSizeCategory, txtMenuItemSize))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var initialcafeMenuItemSize = new CafeMenuItemSize
                    {
                        CafeMenuItemSizeCategoryID = (int)cmbMenuItemSizeCategory.SelectedValue,
                        CafeMenuItemSizeCategoryName = cmbMenuItemSizeCategory.Text,
                        CafeMenuItemSizeName = txtMenuItemSize.Text
                    };

                    bool isAdded = await Task.Run(() => _cafeMenuItemSizeService.AddMenuItemSize(initialcafeMenuItemSize));

                    if (isAdded)
                    {
                        MessageBox.Show("New menu item size is added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadCafeMenuItemSizeDataAsync();
                        ControlHelper.ClearControlsInContainer(grpCafeMenuItemSizeAdd);
                    }
                    else
                    {
                        MessageBox.Show("Error during add  menu item size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Menu item size is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtSearchCafeMenuItemSizeName_KeyUp(object sender, KeyEventArgs e)
        {
            await SearchAndDisplayCategory();
        }

        private async void dgvCafeMenuItemSizeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (dgvCafeMenuItemSizeList.Columns[e.ColumnIndex].Name == "Delete")
            {
                int cafeMenuItemSizeID = Convert.ToInt32(dgvCafeMenuItemSizeList.Rows[e.RowIndex].Cells["CafeMenuItemSizeID"].Value);


                var confirmResult = MessageBox.Show("Are you sure you want to delete this size? \n This may cause program disruption.",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await Task.Run(() => _cafeMenuItemSizeService.DeleteCafeMenuItemSize(cafeMenuItemSizeID));
                    MessageBox.Show("Menu item size deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCafeMenuItemSizeDataAsync();
                    ControlHelper.ClearControlsInContainer(grpCafeMenuItemSizeSearch);
                }

            }


            if (dgvCafeMenuItemSizeList.Columns[e.ColumnIndex].Name == "Edit")
            {
                int cafeMenuItemSizeID = Convert.ToInt32(dgvCafeMenuItemSizeList.Rows[e.RowIndex].Cells["CafeMenuItemSizeID"].Value);

                var selectedRow = dgvCafeMenuItemSizeList.Rows[e.RowIndex];
                var cafeMenuItemSize = new CafeMenuItemSize
                {
                    CafeMenuItemSizeID = cafeMenuItemSizeID,
                    CafeMenuItemSizeCategoryID = Convert.ToInt32(selectedRow.Cells["CafeMenuItemSizeCategoryID"].Value.ToString()),
                    CafeMenuItemSizeCategoryName = selectedRow.Cells["CafeMenuItemSizeCategoryName"].Value.ToString(),
                    CafeMenuItemSizeName = selectedRow.Cells["CafeMenuItemSizeName"].Value.ToString(),
                };

                var confirmResult = MessageBox.Show("Are you sure you want to Edit this size? \n This may cause program disruption.",
                                                    "Confirm Edit",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    await Task.Run(() => _cafeMenuItemSizeService.EditCafeMenuItemSize(cafeMenuItemSize));
                    MessageBox.Show("Menu item size Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCafeMenuItemSizeDataAsync();
                    ControlHelper.ClearControlsInContainer(grpCafeMenuItemSizeSearch);
                }

            }
        }
    }
}
