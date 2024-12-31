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
    public class InvoiceRepository
    {
        private readonly string _connectionString;
        private readonly DatabaseHelper _databaseHelper;

        public InvoiceRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);
        }

        // Insert a new Invoice
        public int InsertInvoice(Invoice invoice)
        {

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                new SqlParameter("@CustomerID", SqlDbType.Int) { Value = invoice.CustomerID },
                new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50) { Value = invoice.CustomerName },
                new SqlParameter("@InvoiceDate", SqlDbType.DateTime) { Value = invoice.InvoiceDate },
                new SqlParameter("@InvoiceUpdateDate", SqlDbType.DateTime) { Value = invoice.InvoiceUpdateDate },             
                new SqlParameter("@PaymentMethod", SqlDbType.NVarChar, 8) { Value = invoice.PaymentMethod },
                new SqlParameter("@OrderMode", SqlDbType.NVarChar, 8) { Value = invoice.OrderMode },
                new SqlParameter("@InvoiceDescripton", SqlDbType.NVarChar, 250) { Value = invoice.InvoiceDescripton }
            };
            var priceParameter = new SqlParameter("@InvoicePrice", SqlDbType.Decimal)
            {
                Value = invoice.InvoicePrice
            };
            priceParameter.Precision = 18;
            priceParameter.Scale = 2;
            parameters.Add(priceParameter);

            try
            {
                return _databaseHelper.ExecuteStoredProcedure("spManageInvoice", parameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while inserting the invoice: " + ex.Message);
            }
        }


        // Update an existing MenuItem
        public bool EditInvoice(Invoice invoice)
        {

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
                new SqlParameter("@InvoiceID", SqlDbType.Int) { Value = invoice.InvoiceID },
                new SqlParameter("@CustomerID", SqlDbType.Int) { Value = invoice.CustomerID },
                new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50) { Value = invoice.CustomerName },
                new SqlParameter("@InvoiceDate", SqlDbType.DateTime) { Value = invoice.InvoiceDate },
                new SqlParameter("@InvoiceUpdateDate", SqlDbType.DateTime) { Value = invoice.InvoiceUpdateDate },
                new SqlParameter("@PaymentMethod", SqlDbType.NVarChar, 8) { Value = invoice.PaymentMethod },
                new SqlParameter("@OrderMode", SqlDbType.NVarChar, 8) { Value = invoice.OrderMode },
                new SqlParameter("@InvoiceDescripton", SqlDbType.NVarChar, 250) { Value = invoice.InvoiceDescripton }
            };
            var priceParameter = new SqlParameter("@InvoicePrice", SqlDbType.Decimal)
            {
                Value = invoice.InvoicePrice
            };
            priceParameter.Precision = 18;
            priceParameter.Scale = 2;
            parameters.Add(priceParameter);


            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageInvoice", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the invoice: " + ex.Message);
            }
        }

        // Delete a MenuItem
        public bool DeleteInvoice(int invoiceID)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Delete" },
                new SqlParameter("@InvoiceID", SqlDbType.Int) { Value = invoiceID }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageInvoice", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while deleting the invoice: " + ex.Message);
            }
        }

        public List<Invoice> GetInvoice(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@InvoiceID", DBNull.Value),
                new SqlParameter("@CustomerID", DBNull.Value),
                new SqlParameter("@CustomerName", DBNull.Value),
                new SqlParameter("@InvoiceDate", DBNull.Value),
                new SqlParameter("@InvoiceUpdateDate", DBNull.Value),
                new SqlParameter("@InvoicePrice", DBNull.Value),                
                new SqlParameter("@PaymentMethod", DBNull.Value),
                new SqlParameter("@OrderMode", DBNull.Value),
                new SqlParameter("@InvoiceDescripton", DBNull.Value)
            };

            foreach (var param in searchParameters)
            {
                var matchingParameter = parameters.FirstOrDefault(p => p.ParameterName == $"@{param.Key}");
                if (matchingParameter != null)
                {
                    matchingParameter.Value = param.Value;
                }
                Console.WriteLine($"Parameter: {matchingParameter.ParameterName}, Value: {matchingParameter.Value}, Type: {matchingParameter.Value?.GetType()}");
                
            }

            try
            {
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageInvoice", parameters))
                {
                    var cafeInvoice = new List<Invoice>();
                    while (reader.Read())
                    {
                        cafeInvoice.Add(new Invoice
                        {
                            InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                            CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                            InvoiceDate = reader.IsDBNull(reader.GetOrdinal("InvoiceDate"))
                            ? DateTime.MinValue
                            : reader.GetDateTime(reader.GetOrdinal("InvoiceDate")),

                            InvoiceUpdateDate = reader.IsDBNull(reader.GetOrdinal("InvoiceUpdateDate"))
                            ? DateTime.MinValue 
                            : reader.GetDateTime(reader.GetOrdinal("InvoiceUpdateDate")),

                            InvoicePrice = reader.GetDecimal(reader.GetOrdinal("InvoicePrice")),
                            PaymentMethod = reader.GetString(reader.GetOrdinal("PaymentMethod")),
                            OrderMode = reader.GetString(reader.GetOrdinal("OrderMode")),
                            InvoiceDescripton = reader.GetString(reader.GetOrdinal("InvoiceDescripton"))
                        });
                    }
                    return cafeInvoice;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching invoice: " + ex.Message);
            }
        }
    }
}
