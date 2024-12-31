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
    public partial class MenuCategoryForm : Form
    {
        private readonly CafeMenuCategoryService _cafeMenuCategoryService;
        public MenuCategoryForm(CafeMenuCategoryService cafeMenuCategoryService)
        {
            InitializeComponent();
            _cafeMenuCategoryService = cafeMenuCategoryService;
        }

        private void InitializeDataGridView()
        {
            if (dgvMenuCategory.Rows.Count != 0)
            {
                if (!dgvMenuCategory.Columns.Contains("Delete"))
                {
                    DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Delete",
                        Name = "Delete",
                        Image = Properties.Resources.deletedgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvMenuCategory.Columns.Add(deleteImageColumn);
                }

                if (!dgvMenuCategory.Columns.Contains("Edit"))
                {
                    DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Edit",
                        Name = "Edit",
                        Image = Properties.Resources.editdgw,
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Width = 50
                    };
                    dgvMenuCategory.Columns.Add(editImageColumn);
                }

                if (dgvMenuCategory.Columns.Contains("CafeMenuCategoryID"))
                {

                    dgvMenuCategory.Columns["CafeMenuCategoryID"].ReadOnly = true;

                }
            }
        }

        private async Task LoadMenuCategoryDataAsync()
        {
            try
            {
                // Fetch data from the service
                var searchParameters = new Dictionary<string, object>();
                List<CafeMenuCategory> cafeMenuCategories = await Task.Run(() => _cafeMenuCategoryService.GetCafeMenuCategories(searchParameters));

                if (cafeMenuCategories != null && cafeMenuCategories.Any())
                {


                    // Bind data to the DataGridView
                    dgvMenuCategory.DataSource = cafeMenuCategories;

                    // Adjust column widths (modify based on actual fields in MenuCategory)
                    dgvMenuCategory.Columns["CafeMenuCategoryID"].Width = 50;
                    dgvMenuCategory.Columns["CafeMenuCategoryID"].HeaderText = "ID";
                    dgvMenuCategory.Columns["CafeMenuCategoryName"].Width = 180;
                    dgvMenuCategory.Columns["CafeMenuCategoryName"].HeaderText = "Menu Category name";

                    InitializeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in retrieving Menu Item Size Categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SearchAndDisplayMenuCategory()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();

                if (!string.IsNullOrWhiteSpace(txtSearchMenuCategory.Text))
                {
                    searchParameters.Add("CafeMenuCategoryName", txtSearchMenuCategory.Text);
                }


                var category = await Task.Run(() => _cafeMenuCategoryService.GetCafeMenuCategories(searchParameters));

                dgvMenuCategory.DataSource = category;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void MenuCategoryForm_Load(object sender, EventArgs e)
        {
            await LoadMenuCategoryDataAsync();
            InitializeDataGridView();
        }

        private async void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlHelper.AreControlsFilled(txtAddMenuCategoryName))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var initialCategory = new CafeMenuCategory
                    {
                        CafeMenuCategoryName = txtAddMenuCategoryName.Text
                    };

                    bool isAdded = await Task.Run(() => _cafeMenuCategoryService.AddCafeMenuCategory(initialCategory));

                    if (isAdded)
                    {
                        MessageBox.Show("New Menu Category is added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadMenuCategoryDataAsync();
                        ControlHelper.ClearControlsInContainer(grpMenuCategoryAdd);

                    }
                    else
                    {
                        MessageBox.Show("Error during add Menu Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("New Menu Category is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtSearchMenuCategory_KeyUp(object sender, KeyEventArgs e)
        {
            await SearchAndDisplayMenuCategory();
        }

        private async void dgvMenuCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (dgvMenuCategory.Columns[e.ColumnIndex].Name == "Delete")
            {
                int cafeMenuCategoryID = Convert.ToInt32(dgvMenuCategory.Rows[e.RowIndex].Cells["CafeMenuCategoryID"].Value);


                var confirmResult = MessageBox.Show("Are you sure you want to delete this Menu category? \n This may cause program disruption.",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await Task.Run(() => _cafeMenuCategoryService.DeleteCafeMenuCategory(cafeMenuCategoryID));
                    MessageBox.Show("Menu category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadMenuCategoryDataAsync();
                    ControlHelper.ClearControlsInContainer(grpMenuCategorySearch);
                }

            }


            if (dgvMenuCategory.Columns[e.ColumnIndex].Name == "Edit")
            {
                int cafeMenuCategoryID = Convert.ToInt32(dgvMenuCategory.Rows[e.RowIndex].Cells["CafeMenuCategoryID"].Value);

                var selectedRow = dgvMenuCategory.Rows[e.RowIndex];
                var cafeMenuCategory = new CafeMenuCategory
                {
                    CafeMenuCategoryID = cafeMenuCategoryID,
                    CafeMenuCategoryName = selectedRow.Cells["CafeMenuCategoryName"].Value.ToString()
                };

                var confirmResult = MessageBox.Show("Are you sure you want to Edit this menu category? \n This may cause program disruption.",
                                                    "Confirm Edit",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    await Task.Run(() => _cafeMenuCategoryService.EditCafeMenuCategory(cafeMenuCategory));
                    MessageBox.Show("Menu category edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadMenuCategoryDataAsync();
                    ControlHelper.ClearControlsInContainer(grpMenuCategorySearch);
                }
            }
        }
    }
}
