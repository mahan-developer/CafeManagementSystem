using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonUtilities;

namespace CafeManager
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService;
        //private readonly DatabaseInitializerService _dbService;

        public CustomerForm(CustomerService customerService)
        {
            InitializeComponent();
           // _dbService = dbService;
            _customerService = customerService;
        }

        private async Task LoadCustomerDataAsync()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();
                List<Customer> customers = await Task.Run(() => _customerService.GetCustomersByField(searchParameters));
                dgvCustomerList.DataSource = customers;
                dgvCustomerList.Columns["CustomerID"].Width = 50;
                dgvCustomerList.Columns["CustomerID"].HeaderText = "ID";

                dgvCustomerList.Columns["FirstName"].Width = 125;
                dgvCustomerList.Columns["LastName"].Width = 125;
                dgvCustomerList.Columns["PhoneNumber"].Width = 100;
                dgvCustomerList.Columns["EmailAddress"].Width = 150;
                dgvCustomerList.Columns["CustomerAddress"].Width = 190;
                dgvCustomerList.Columns["CustomerAddress"].HeaderText= "Address";

            }
            catch (Exception)
            {
                MessageBox.Show("Error in geting Customers information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeDataGridView()
        {            

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Delete",
                Name = "Delete",
                Image = Properties.Resources.deletedgw, 
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
            };


            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Edit",
                Name = "Edit",
                Image = Properties.Resources.editdgw,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
            };

       
            dgvCustomerList.Columns.Add(deleteImageColumn);
            dgvCustomerList.Columns.Add(editImageColumn);
            dgvCustomerList.Columns["CustomerID"].ReadOnly = true;
        }

        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            await LoadCustomerDataAsync();
            InitializeDataGridView();            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ControlHelper.AreControlsFilled(txtAddCustomerFirstName, txtAddCustomerLastName, txtAddCustomerPhoneNumber))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var initialCustomer = new Customer
                    {
                        FirstName = txtAddCustomerFirstName.Text,
                        LastName = txtAddCustomerLastName.Text,
                        PhoneNumber = txtAddCustomerPhoneNumber.Text,
                        EmailAddress = txtAddCustomerEmailAddress.Text,
                        CustomerAddress = txtAddCustomerCustomerAddress.Text
                    };

                    bool isAdded = await Task.Run(() => _customerService.AddCustomer(initialCustomer));

                    if (isAdded)
                    {
                        MessageBox.Show("New customer is added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadCustomerDataAsync();
                        ControlHelper.ClearControlsInContainer(grpCustomerAdd);
                    }
                    else
                    {
                        MessageBox.Show("Error during add customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("New customer is not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void dgvReadCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0)
                return;

           
            if (dgvCustomerList.Columns[e.ColumnIndex].Name == "Delete")
            {
                int customerId = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["CustomerID"].Value);

                if (customerId == 1)
                {
                    MessageBox.Show("You can't Delete Global user", "Information", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?",
                                                   "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        await Task.Run(() => _customerService.DeleteCustomer(customerId));
                        MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadCustomerDataAsync();
                        ControlHelper.ClearControlsInContainer(grpCustomerSearch);
                    }
                }
               
            }


            if (dgvCustomerList.Columns[e.ColumnIndex].Name == "Edit")
            {
                int customerId = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells["CustomerID"].Value);
                if (customerId == 1)
                {
                    MessageBox.Show("You can't Edit Global user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var selectedRow = dgvCustomerList.Rows[e.RowIndex];
                    var customer = new Customer
                    {
                        CustomerID = customerId,
                        FirstName = selectedRow.Cells["FirstName"].Value.ToString(),
                        LastName = selectedRow.Cells["LastName"].Value.ToString(),
                        PhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString(),
                        EmailAddress = selectedRow.Cells["EmailAddress"].Value.ToString(),
                        CustomerAddress = selectedRow.Cells["CustomerAddress"].Value.ToString()
                    };

                    var confirmResult = MessageBox.Show("Are you sure you want to Edit this customer?",
                                                        "Confirm Edit",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        await Task.Run(() => _customerService.EditCustomer(customer));
                        MessageBox.Show("Customer Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadCustomerDataAsync();
                        ControlHelper.ClearControlsInContainer(grpCustomerSearch);
                    }

                }                            
                
            }

        }

        private void txtAddCustomerPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }



        private async Task SearchAndDisplayCustomers()
        {
            try
            {
                var searchParameters = new Dictionary<string, object>();

                if (!string.IsNullOrWhiteSpace(txtSearchLastName.Text))
                {
                    searchParameters.Add("LastName", txtSearchLastName.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtSearchPhoneNumber.Text))
                {
                    searchParameters.Add("PhoneNumber", txtSearchPhoneNumber.Text);
                }

                var customers = await Task.Run(() => _customerService.GetCustomersByField(searchParameters));

                dgvCustomerList.DataSource = customers;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            await SearchAndDisplayCustomers();
        }

        private async void txtSearchPhoneNumber_KeyUp(object sender, KeyEventArgs e)
        {
            await SearchAndDisplayCustomers();
        }
    }
}
