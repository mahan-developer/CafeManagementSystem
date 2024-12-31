using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;

namespace BusinessApplicationLayer
{
    public class InvoiceItemService
    {
        private readonly InvoiceItemRepository _invoiceItemRepository;
        public InvoiceItemService(InvoiceItemRepository invoiceItemRepository)
        {
            _invoiceItemRepository = invoiceItemRepository;
        }

        public bool AddInvoiceItem(InvoiceItem invoiceItem)
        {
            try
            {
                int result = _invoiceItemRepository.InsertInvoiceItem(invoiceItem);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }
        }


        // Update an existing MenuItemSizeCategory
        public bool EditInvoiceItem(InvoiceItem invoiceItem)
        {
            try
            {
                return _invoiceItemRepository.EditInvoiceItem(invoiceItem);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while updating the invoice.", ex);
            }
        }

        // Delete a MenuItemSizeby ID
        public bool DeleteInvoiceItem(int invoiceItemId)
        {
            try
            {
                return _invoiceItemRepository.DeleteInvoiceItem(invoiceItemId);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while deleting the invoice.", ex);
            }
        }




        // Search MenuItemSize by keyword
        public List<InvoiceItem> GetInvoiceItem(Dictionary<string, object> searchParameters)
        {
            try
            {
                return _invoiceItemRepository.GetInvoiceItem(searchParameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while searching for invoice.", ex);
            }
        }
    }
}
