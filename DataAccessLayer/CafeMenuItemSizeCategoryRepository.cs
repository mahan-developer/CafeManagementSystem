using BusinessEntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CommonUtilities;
using System.Configuration;
using System.Linq;

namespace DataAccessLayer
{
    public class CafeMenuItemSizeCategoryRepository
    {
        private readonly string _connectionString;
        private readonly DatabaseHelper _databaseHelper;

        public CafeMenuItemSizeCategoryRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);
        }

        // Insert a new MenuItemSizeCategory
        public int InsertMenuItemSizeCategory(CafeMenuItemSizeCategory cafeMenuItemSizeCategory)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                new SqlParameter("@CafeMenuItemSizeCategoryName", SqlDbType.NVarChar, 50) { Value = cafeMenuItemSizeCategory.CafeMenuItemSizeCategoryName }
            };

            try
            {
                return _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItemSizeCategory", parameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while inserting the menu item size category: " + ex.Message);
            }
        }

        // Update an existing MenuItemSizeCategory
        public bool EditMenuItemSizeCategory(CafeMenuItemSizeCategory cafeMenuItemSizeCategory)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
                new SqlParameter("@CafeMenuItemSizeCategoryID", SqlDbType.Int) { Value = cafeMenuItemSizeCategory.CafeMenuItemSizeCategoryID },
                new SqlParameter("@CafeMenuItemSizeCategoryName", SqlDbType.NVarChar, 50) { Value = cafeMenuItemSizeCategory.CafeMenuItemSizeCategoryName }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItemSizeCategory", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the menu item size category: " + ex.Message);
            }
        }

        // Delete a MenuItemSizeCategory
        public bool DeleteMenuItemSizeCategory(int cafeMenuItemSizeCategoryId)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Delete" },
                new SqlParameter("@CafeMenuItemSizeCategoryID", SqlDbType.Int) { Value = cafeMenuItemSizeCategoryId }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItemSizeCategory", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while deleting the menu item size category: " + ex.Message);
            }
        }


        public List<CafeMenuItemSizeCategory> GetCafeMenuItemSizeCategory(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@CafeMenuItemSizeCategoryID", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeCategoryName", DBNull.Value)
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
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageCafeMenuItemSizeCategory", parameters))
                {
                    var cafeMenuItemSizeCategory = new List<CafeMenuItemSizeCategory>();
                    while (reader.Read())
                    {
                        cafeMenuItemSizeCategory.Add(new CafeMenuItemSizeCategory
                        {
                            CafeMenuItemSizeCategoryID = reader.GetInt32(reader.GetOrdinal("CafeMenuItemSizeCategoryID")),
                            CafeMenuItemSizeCategoryName = reader.GetString(reader.GetOrdinal("CafeMenuItemSizeCategoryName"))
                        });
                    }
                    return cafeMenuItemSizeCategory;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching menu item size category: " + ex.Message);
            }
        }


    }
}
