using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationLayer
{
    public class InvoiceService
    {
        private readonly InvoiceRepository _invoiceRepository;
        public InvoiceService(InvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public bool AddInvoice(Invoice invoice)
        {
            try
            {
                int result = _invoiceRepository.InsertInvoice(invoice);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }
        }


        // Update an existing MenuItemSizeCategory
        public bool EditInvoice(Invoice invoice)
        {
            try
            {
                return _invoiceRepository.EditInvoice(invoice);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while updating the invoice.", ex);
            }
        }

        // Delete a MenuItemSizeby ID
        public bool DeleteInvoice(int invoiceeId)
        {
            try
            {
                return _invoiceRepository.DeleteInvoice(invoiceeId);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while deleting the invoice.", ex);
            }
        }




        // Search MenuItemSize by keyword
        public List<Invoice> GetInvoice(Dictionary<string, object> searchParameters)
        {
            try
            {
                return _invoiceRepository.GetInvoice(searchParameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("An error occurred while searching for invoice.", ex);
            }
        }

    }
}
