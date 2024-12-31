using BusinessEntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using CommonUtilities;
using System.Configuration;

namespace DataAccessLayer
{
    public class CafeMenuItemSizeRepository
    {
        private readonly string _connectionString;
        private readonly DatabaseHelper _databaseHelper;
        public CafeMenuItemSizeRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);
        }
              

        // Insert a new MenuItemSize
        public int InsertCafeMenuItemSize(CafeMenuItemSize cafeMenuItemSize)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                new SqlParameter("@CafeMenuItemSizeCategoryID", SqlDbType.Int) { Value = cafeMenuItemSize.CafeMenuItemSizeCategoryID },
                new SqlParameter("@CafeMenuItemSizeCategoryName", SqlDbType.NVarChar, 15) { Value = cafeMenuItemSize.CafeMenuItemSizeCategoryName },
                new SqlParameter("@CafeMenuItemSizeName", SqlDbType.NVarChar, 15) { Value = cafeMenuItemSize.CafeMenuItemSizeName }

            };

            try
            {
                return _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItemSize", parameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while inserting the menu item size: " + ex.Message);
            }
        }

        // Update an existing MenuItemSize
        public bool EditCafeMenuItemSize(CafeMenuItemSize cafeMenuItemSize)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
                new SqlParameter("@CafeMenuItemSizeID", SqlDbType.Int) { Value = cafeMenuItemSize.CafeMenuItemSizeID },
                new SqlParameter("@CafeMenuItemSizeCategoryID", SqlDbType.Int) { Value = cafeMenuItemSize.CafeMenuItemSizeCategoryID },
                new SqlParameter("@CafeMenuItemSizeCategoryName", SqlDbType.NVarChar, 125) { Value = cafeMenuItemSize.CafeMenuItemSizeCategoryName },
                new SqlParameter("@CafeMenuItemSizeName", SqlDbType.NVarChar, 25) { Value = cafeMenuItemSize.CafeMenuItemSizeName }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItemSize", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the menu item size: " + ex.Message);
            }
        }

        // Delete a MenuItemSize
        public bool DeleteCafeMenuItemSize(int cafeMenuItemSizeId)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Delete" },
                new SqlParameter("@CafeMenuItemSizeID", SqlDbType.Int) { Value = cafeMenuItemSizeId }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItemSize", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while deleting the menu item size: " + ex.Message);
            }
        }


        public List<CafeMenuItemSize> GetCafeMenuItemSize(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@CafeMenuItemSizeID", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeCategoryID", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeCategoryName", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeName", DBNull.Value),
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
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageCafeMenuItemSize", parameters))
                {
                    var cafeMenuItemSize = new List<CafeMenuItemSize>();
                    while (reader.Read())
                    {
                        cafeMenuItemSize.Add(new CafeMenuItemSize
                        {
                            CafeMenuItemSizeID = reader.GetInt32(reader.GetOrdinal("CafeMenuItemSizeID")),
                            CafeMenuItemSizeCategoryID = reader.GetInt32(reader.GetOrdinal("CafeMenuItemSizeCategoryID")),
                            CafeMenuItemSizeCategoryName = reader.GetString(reader.GetOrdinal("CafeMenuItemSizeCategoryName")),
                            CafeMenuItemSizeName = reader.GetString(reader.GetOrdinal("CafeMenuItemSizeName"))
                        });
                    }
                    return cafeMenuItemSize;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching customers: " + ex.Message);
            }
        }

    }
}
