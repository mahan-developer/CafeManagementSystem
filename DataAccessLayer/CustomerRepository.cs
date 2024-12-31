using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessEntitiesLayer;
using CommonUtilities;
using System.Configuration;

namespace DataAccessLayer
{
    public class CustomerRepository
    {
        private readonly string _connectionString;
        private readonly DatabaseHelper _databaseHelper;
        public CustomerRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);            
        }


        public int InsertCustomer(Customer customer)
        {
            var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                    new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = customer.FirstName },
                    new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = customer.LastName },
                    new SqlParameter("@PhoneNumber", SqlDbType.NVarChar,20) { Value = customer.PhoneNumber },                    
                    new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 80) { Value = customer.EmailAddress },
                    new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 150) { Value = customer.CustomerAddress }
             };

            return _databaseHelper.ExecuteStoredProcedure("spManageCustomer", parameters);
        }


        public bool EditCustomer(Customer customer)
        {
            var parameters = new List<SqlParameter>
        {
            new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
            new SqlParameter("@CustomerID", SqlDbType.Int) { Value = customer.CustomerID },
            new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = customer.FirstName },
            new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = customer.LastName },
            new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 20) { Value = customer.PhoneNumber },
            new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 80) { Value = customer.EmailAddress },
            new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 150) { Value = customer.CustomerAddress }
        };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCustomer", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the customer: " + ex.Message);
            }
        }



        public bool DeleteCustomer(int customerId)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Delete" },
                new SqlParameter("@CustomerID", SqlDbType.Int) { Value = customerId }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCustomer", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while deleting the customer: " + ex.Message);
            }
        }


        public List<Customer> GetCustomers(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@CustomerID", DBNull.Value),
                new SqlParameter("@FirstName", DBNull.Value),
                new SqlParameter("@LastName", DBNull.Value),
                new SqlParameter("@PhoneNumber", DBNull.Value),
                new SqlParameter("@EmailAddress", DBNull.Value),
                new SqlParameter("@CustomerAddress", DBNull.Value)
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
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageCustomer", parameters))
                {
                    var customers = new List<Customer>();
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress")),
                            CustomerAddress = reader.GetString(reader.GetOrdinal("CustomerAddress"))
                        });
                    }
                    return customers;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching customers: " + ex.Message);
            }
        }




        //public List<Customer> SearchCustomersByKeyword(Dictionary<string, object> searchParameters)
        //{
        //    // تعریف پارامترها
        //    var parameters = new List<SqlParameter>
        //    {
        //        new SqlParameter("@Operation", "Select"),
        //        new SqlParameter("@CustomerID", DBNull.Value),
        //        new SqlParameter("@FirstName", DBNull.Value),
        //        new SqlParameter("@LastName", DBNull.Value),
        //        new SqlParameter("@PhoneNumber", DBNull.Value),
        //        new SqlParameter("@EmailAddress", DBNull.Value),
        //        new SqlParameter("@CustomerAddress", DBNull.Value)
        //    };

        //    // مقداردهی به پارامترهای مطابق با searchParameters
        //    foreach (var param in searchParameters)
        //    {
        //        var matchingParameter = parameters.FirstOrDefault(p => p.ParameterName == $"@{param.Key}");
        //        if (matchingParameter != null)
        //        {
        //            matchingParameter.Value = param.Value;
        //        }
        //    }

        //    try
        //    {
        //        // اجرای Stored Procedure و خواندن نتایج
        //        using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageCustomer", parameters))
        //        {
        //            var customers = new List<Customer>();
        //            while (reader.Read())
        //            {
        //                customers.Add(new Customer
        //                {
        //                    CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
        //                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
        //                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
        //                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
        //                    EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress")),
        //                    CustomerAddress = reader.GetString(reader.GetOrdinal("CustomerAddress"))
        //                });
        //            }
        //            return customers;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorHandler.LogException(ex);
        //        throw new Exception("Error while searching customers: " + ex.Message);
        //    }
        //}



        //public List<Customer> GetAllCustomers()
        //{
        //    var customers = new List<Customer>();

        //    var parameters = new List<SqlParameter>
        //{
        //    new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Select" }
        //};

        //    using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageCustomer", parameters))
        //    {
        //        while (reader.Read())
        //        {
        //            customers.Add(new Customer
        //            {
        //                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
        //                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
        //                LastName = reader.GetString(reader.GetOrdinal("LastName")),
        //                PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
        //                EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress")),
        //                CustomerAddress = reader.GetString(reader.GetOrdinal("CustomerAddress"))
        //            });
        //        }
        //    }

        //    return customers;
        //}


    }

}
