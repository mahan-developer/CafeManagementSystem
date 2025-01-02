using System;
using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace CafeManager
{
    
    public partial class SaleReportForm : Form
    {
        private readonly DataLoader _dataLoader;
        private readonly InvoiceService _invoiceService;
        private SalesForm _salesForm;
        private MainForm _mainform;
        public SaleReportForm(InvoiceService invoiceService, SalesForm salesForm, MainForm mainform)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _salesForm = salesForm;
            _mainform = mainform;
        }

        private void SearchInvoice()
        {
            DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
            DateTime endDate = Convert.ToDateTime(txtEndDate.Text).Date.AddDays(1).AddSeconds(-1);


            var searchParameters = new Dictionary<string, object>();
            var invoiceListByDate = _invoiceService.GetInvoice(searchParameters);

            var filteredInvoiceList = invoiceListByDate
            .Where(invoice => invoice.InvoiceDate >= startDate && invoice.InvoiceDate <= endDate)
            .ToList();

            dgvInvoicesList.DataSource = filteredInvoiceList;
            dgvInvoicesList.ReadOnly = true;
            dgvInvoicesList.Columns["CustomerId"].Visible = false;
            dgvInvoicesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {           
            txtStartDate.Text = DateTime.Now.ToShortDateString();
            txtEndDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnInvoceSearch_Click(object sender, EventArgs e)
        {
            SearchInvoice();
        }

        private void dgvInvoicesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvInvoicesList.Rows[e.RowIndex];
            _salesForm.reportGrid = selectedRow;
            _mainform.ShowSaleFormForEdit(selectedRow);
            SearchInvoice();
        }
    }
}
