using BusinessEntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtilities;
using System.Configuration;

namespace DataAccessLayer
{
    public class InvoiceItemRepository
    {
        private readonly string _connectionString;
        private readonly DatabaseHelper _databaseHelper;

        public InvoiceItemRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);
        }


        // Insert a new InvoiceItem
        public int InsertInvoiceItem(InvoiceItem invoiceItem)
        {

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                new SqlParameter("@InvoiceID", SqlDbType.Int) { Value = invoiceItem.InvoiceID },
                new SqlParameter("@CafeMenuItemID", SqlDbType.Int) { Value = invoiceItem.CafeMenuItemID },
                new SqlParameter("@CafeMenuItemCategory", SqlDbType.NVarChar,25) { Value = invoiceItem.CafeMenuItemCategory },                 
                new SqlParameter("@CafeMenuItemName", SqlDbType.NVarChar,25) { Value = invoiceItem.CafeMenuItemName },
                new SqlParameter("@CafeMenuItemSize", SqlDbType.NVarChar,25) { Value = invoiceItem.CafeMenuItemSize },
                new SqlParameter("@Quantity", SqlDbType.Int) { Value = invoiceItem.Quantity },
                new SqlParameter("@ItemUpdateDate", SqlDbType.DateTime) { Value = invoiceItem.ItemUpdateDate }               
            };
            var priceParameter = new SqlParameter("@CafeMenuItemPrice", SqlDbType.Decimal)
            {
                Value = invoiceItem.CafeMenuItemPrice
            };
            priceParameter.Precision = 18;
            priceParameter.Scale = 2;
            parameters.Add(priceParameter);

            try
            {
                return _databaseHelper.ExecuteStoredProcedure("spManageInvoiceItem", parameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while inserting the invoice item: " + ex.Message);
            }
        }


        // Update an existing Invoice item
        public bool EditInvoiceItem(InvoiceItem invoiceItem)
        {

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
                new SqlParameter("@InvoiceItemID", SqlDbType.Int) { Value = invoiceItem.InvoiceItemID },
                new SqlParameter("@InvoiceID", SqlDbType.Int) { Value = invoiceItem.InvoiceID },
                new SqlParameter("@CafeMenuItemID", SqlDbType.Int) { Value = invoiceItem.CafeMenuItemID },
                new SqlParameter("@CafeMenuItemCategory", SqlDbType.NVarChar,25) { Value = invoiceItem.CafeMenuItemCategory },
                new SqlParameter("@CafeMenuItemName", SqlDbType.NVarChar,25) { Value = invoiceItem.CafeMenuItemName },
                new SqlParameter("@CafeMenuItemSize", SqlDbType.NVarChar,25) { Value = invoiceItem.CafeMenuItemSize },
                new SqlParameter("@Quantity", SqlDbType.Int) { Value = invoiceItem.Quantity },
                new SqlParameter("@ItemUpdateDate", SqlDbType.DateTime) { Value = invoiceItem.ItemUpdateDate }
            };
            var priceParameter = new SqlParameter("@CafeMenuItemPrice", SqlDbType.Decimal)
            {
                Value = invoiceItem.CafeMenuItemPrice
            };
            priceParameter.Precision = 18;
            priceParameter.Scale = 2;
            parameters.Add(priceParameter);


            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageInvoiceItem", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the invoice item: " + ex.Message);
            }
        }

        // Delete a MenuItem
        public bool DeleteInvoiceItem(int invoiceItemID)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Delete" },
                new SqlParameter("@InvoiceItemID", SqlDbType.Int) { Value = invoiceItemID }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageInvoiceItem", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while deleting the invoice item: " + ex.Message);
            }
        }

        public List<InvoiceItem> GetInvoiceItem(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@InvoiceItemID", DBNull.Value),
                new SqlParameter("@InvoiceID", DBNull.Value),
                new SqlParameter("@CafeMenuItemID", DBNull.Value),
                new SqlParameter("@CafeMenuItemCategory", DBNull.Value),
                new SqlParameter("@CafeMenuItemName", DBNull.Value),
                new SqlParameter("@CafeMenuItemSize", DBNull.Value),
                new SqlParameter("@Quantity", DBNull.Value),
                new SqlParameter("@CafeMenuItemPrice", DBNull.Value),
                new SqlParameter("@ItemUpdateDate", DBNull.Value)
            };

            foreach (var param in searchParameters)
            {
                var matchingParameter = parameters.FirstOrDefault(p => p.ParameterName == $"@{param.Key}");
                if (matchingParameter != null)
                {
                    matchingParameter.Value = param.Value;
                }
                
            }

            try
            {
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageInvoiceItem", parameters))
                {
                    var cafeInvoiceItem = new List<InvoiceItem>();
                    while (reader.Read())
                    {
                        cafeInvoiceItem.Add(new InvoiceItem
                        {
                            InvoiceItemID = reader.GetInt32(reader.GetOrdinal("InvoiceItemID")),
                            InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                            CafeMenuItemID = reader.GetInt32(reader.GetOrdinal("CafeMenuItemID")),
                            CafeMenuItemCategory = reader.GetString(reader.GetOrdinal("CafeMenuItemCategory")),
                            CafeMenuItemName = reader.GetString(reader.GetOrdinal("CafeMenuItemName")),
                            CafeMenuItemSize = reader.GetString(reader.GetOrdinal("CafeMenuItemSize")),
                            Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            CafeMenuItemPrice = reader.GetDecimal(reader.GetOrdinal("CafeMenuItemPrice")),
                            ItemUpdateDate = reader.IsDBNull(reader.GetOrdinal("ItemUpdateDate"))
                            ? DateTime.MinValue
                            : reader.GetDateTime(reader.GetOrdinal("ItemUpdateDate"))
                        });
                    }
                    return cafeInvoiceItem;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching invoice item: " + ex.Message);
            }
        }


    }
}
