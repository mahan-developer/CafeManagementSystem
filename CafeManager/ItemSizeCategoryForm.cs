using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using CommonUtilities;
using System;
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
    public partial class ItemSizeCategoryForm : Form
    {
        private readonly CafeMenuItemSizeCategoryService _cafeMenuItemSizeCategoryService;

        public ItemSizeCategoryForm(CafeMenuItemSizeCategoryService cafeMenuItemSizeCategoryService)
        {
            InitializeComponent();
            _cafeMenuItemSizeCategoryService = cafeMenuItemSizeCategoryService ?? throw new ArgumentNullException(nameof(cafeMenuItemSizeCategoryService));
        }

        private void InitializeDataGridView()
        {
            if (dgvMenuItemSizeCategory.Rows.Count != 0)
            {
                if (!dgvMenuItemSizeCategory.Columns.Contains("Delete"))
                {
                    DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Delete",
                        Name = "Delete",
                        Image = Properties.Resources.deletedgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvMenuItemSizeCategory.Columns.Add(deleteImageColumn);
                }

                if (!dgvMenuItemSizeCategory.Columns.Contains("Edit"))
                {
                    DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Edit",
                        Name = "Edit",
                        Image = Properties.Resources.editdgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvMenuItemSizeCategory.Columns.Add(editImageColumn);
                }

                if (dgvMenuItemSizeCategory.Columns.Contains("CafeMenuItemSizeCategoryID"))
                {

                    dgvMenuItemSizeCategory.Columns["CafeMenuItemSizeCategoryID"].ReadOnly = true;

                }
            }
        }


        private async Task LoadMenuItemSizeCategoryDataAsync()
        {
            try
            {
                // Fetch data from the service
                var searchParameters = new Dictionary<string, object>();
                List<CafeMenuItemSizeCategory> cafeMenuItemSizeCategories = await Task.Run(() => _cafeMenuItemSizeCategoryService.GetCafeMenuItemSizeCategories(searchParameters));

                if (cafeMenuItemSizeCategories != null && cafeMenuItemSizeCategories.Any())
                {


                    // Bind data to the DataGridView
                    dgvMenuItemSizeCategory.DataSource = cafeMenuItemSizeCategories;

                    // Adjust column widths (modify based on actual fields in MenuItemSizeCategory)
                    dgvMenuItemSizeCategory.Columns["CafeMenuItemSizeCategoryID"].Width = 50;
                    dgvMenuItemSizeCategory.Columns["CafeMenuItemSizeCategoryID"].HeaderText = "ID";
                    dgvMenuItemSizeCategory.Columns["CafeMenuItemSizeCategoryName"].Width = 180;
                    dgvMenuItemSizeCategory.Columns["CafeMenuItemSizeCategoryName"].HeaderText = "Category name";

                    InitializeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in retrieving Menu Item Size Categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SearchAndDisplayCategory()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();

                if (!string.IsNullOrWhiteSpace(txtSearchCategory.Text))
                {
                    searchParameters.Add("CafeMenuItemSizeCategoryName", txtSearchCategory.Text);
                }


                var category = await Task.Run(() => _cafeMenuItemSizeCategoryService.GetCafeMenuItemSizeCategories(searchParameters));

                dgvMenuItemSizeCategory.DataSource = category;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ItemSizeCategoryForm_Load(object sender, EventArgs e)
        {
            // Load data on form load            
            await LoadMenuItemSizeCategoryDataAsync();
            InitializeDataGridView();
        }

        private async void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlHelper.AreControlsFilled(txtAddCategoryName))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var initialCategory = new CafeMenuItemSizeCategory
                    {
                        CafeMenuItemSizeCategoryName = txtAddCategoryName.Text
                    };

                    bool isAdded = await Task.Run(() => _cafeMenuItemSizeCategoryService.AddCafeMenuItemSizeCategory(initialCategory));

                    if (isAdded)
                    {
                        MessageBox.Show("New item size category is added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadMenuItemSizeCategoryDataAsync();
                        ControlHelper.ClearControlsInContainer(grpMenuItemSizeCategoryAdd);

                    }
                    else
                    {
                        MessageBox.Show("Error during add item size category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("New customer is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtSearchCategory_KeyUp(object sender, KeyEventArgs e)
        {
            await SearchAndDisplayCategory();
        }

        private async void dgvMenuItemSizeCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;


            if (dgvMenuItemSizeCategory.Columns[e.ColumnIndex].Name == "Delete")
            {
                int cafeMenuItemSizeCategoryID = Convert.ToInt32(dgvMenuItemSizeCategory.Rows[e.RowIndex].Cells["CafeMenuItemSizeCategoryID"].Value);


                var confirmResult = MessageBox.Show("Are you sure you want to delete this size category? \n This may cause program disruption.",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await Task.Run(() => _cafeMenuItemSizeCategoryService.DeleteCafeMenuItemSizeCategory(cafeMenuItemSizeCategoryID));
                    MessageBox.Show("Size category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadMenuItemSizeCategoryDataAsync();
                    ControlHelper.ClearControlsInContainer(grpMenuItemSizeCategorySearch);
                }

            }


            if (dgvMenuItemSizeCategory.Columns[e.ColumnIndex].Name == "Edit")
            {
                int cafeMenuItemSizeCategoryID = Convert.ToInt32(dgvMenuItemSizeCategory.Rows[e.RowIndex].Cells["CafeMenuItemSizeCategoryID"].Value);
                
                    var selectedRow = dgvMenuItemSizeCategory.Rows[e.RowIndex];
                    var cafeMenuItemSizeCategory = new CafeMenuItemSizeCategory
                    {
                        CafeMenuItemSizeCategoryID = cafeMenuItemSizeCategoryID,
                        CafeMenuItemSizeCategoryName = selectedRow.Cells["CafeMenuItemSizeCategoryName"].Value.ToString()
                    };

                    var confirmResult = MessageBox.Show("Are you sure you want to Edit this size category? \n This may cause program disruption.",
                                                        "Confirm Edit",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        await Task.Run(() => _cafeMenuItemSizeCategoryService.EditCafeMenuItemSizeCategory(cafeMenuItemSizeCategory));
                        MessageBox.Show("Size category edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadMenuItemSizeCategoryDataAsync();
                        ControlHelper.ClearControlsInContainer(grpMenuItemSizeCategorySearch);
                    }

            }


        }
    }
}
