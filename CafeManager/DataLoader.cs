using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public class DataLoader
    {
        private readonly CafeMenuItemService _cafeMenuItemService;
        private readonly CafeMenuCategoryService _cafeMenuCategoryService;
        private readonly InvoiceService _invoiceService;
        private readonly InvoiceItemService _invoiceItemService;
        private readonly CustomerService _customerService;

        public DataLoader(CafeMenuItemService cafeMenuItemService, CafeMenuCategoryService cafeMenuCategoryService,
            InvoiceService invoiceService, InvoiceItemService invoiceItemService, CustomerService customerService)
        {
            _cafeMenuItemService = cafeMenuItemService;
            _cafeMenuCategoryService = cafeMenuCategoryService;
            _invoiceService = invoiceService;
            _invoiceItemService = invoiceItemService;
            _customerService = customerService;
        }

        public List<T> LoadData<T>(Func<Dictionary<string, object>, List<T>> serviceMethod, Dictionary<string, object> searchParameters, string errorMessage)
        {
            try
            {
                return serviceMethod(searchParameters);
            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<InvoiceItem> LoadInvoiceItems(int invoiceID)
        {
            var searchParameters = new Dictionary<string, object> { { "InvoiceID", invoiceID } };
            return LoadData(_invoiceItemService.GetInvoiceItem, searchParameters, "Error in getting invoice items.");
        }

        public List<Invoice> LoadInvoices(DateTime invoiceDate)
        {
            var searchParameters = new Dictionary<string, object> { { "InvoiceDate", invoiceDate.Date.ToShortDateString() } };
            return LoadData(_invoiceService.GetInvoice, searchParameters, "Error in getting invoices.");
        }

        public List<Customer> LoadCustomers(string lastName)
        {
            var searchParameters = new Dictionary<string, object> { { "LastName", lastName } };
            return LoadData(_customerService.GetCustomersByField, searchParameters, "Error in getting customers.");
        }

        public List<CafeMenuCategory> LoadCafeMenuCategories()
        {
            return LoadData(_cafeMenuCategoryService.GetCafeMenuCategories, new Dictionary<string, object>(), "Error in getting menu categories.");
        }

        public List<CafeMenuItem> LoadCafeMenuItems()
        {
            return LoadData(_cafeMenuItemService.GetCafeMenuItem, new Dictionary<string, object>(), "Error in getting menu items.");
        }


        public List<object[]> GetInvoiceItemsForGrid(int invoiceID)
        {
            var invoiceItems = LoadInvoiceItems(invoiceID);
            var formattedItems = new List<object[]>();

            for (int i = 0; i < invoiceItems.Count; i++)
            {
                formattedItems.Add(new object[]
                {
                    i + 1,
                    invoiceItems[i].InvoiceItemID,
                    invoiceItems[i].InvoiceID,
                    invoiceItems[i].InvoiceItemID,
                    invoiceItems[i].CafeMenuItemCategory,
                    invoiceItems[i].CafeMenuItemName,
                    invoiceItems[i].CafeMenuItemSize,
                    invoiceItems[i].CafeMenuItemPrice,
                    invoiceItems[i].Quantity,
                    invoiceItems[i].CafeMenuItemPrice * invoiceItems[i].Quantity,
                    invoiceItems[i].ItemUpdateDate
                });
            }

            return formattedItems;
        }


    }
}
