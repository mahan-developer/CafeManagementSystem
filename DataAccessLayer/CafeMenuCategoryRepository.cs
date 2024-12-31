using BusinessEntitiesLayer;
using CommonUtilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CafeMenuCategoryRepository
    {
        private readonly string _connectionString;
        private readonly DatabaseHelper _databaseHelper;

        public CafeMenuCategoryRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);
        }

        // Insert a new MenuCategory
        public int InsertMenuCategory(CafeMenuCategory cafeMenuCategory)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                new SqlParameter("@CafeMenuCategoryName", SqlDbType.NVarChar, 50) { Value = cafeMenuCategory.CafeMenuCategoryName }
            };

            try
            {
                return _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuCategory", parameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while inserting the menu category: " + ex.Message);
            }
        }

        // Update an existing MenuCategory
        public bool EditMenuCategory(CafeMenuCategory cafeMenuCategory)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
                new SqlParameter("@CafeMenuCategoryID", SqlDbType.Int) { Value = cafeMenuCategory.CafeMenuCategoryID },
                new SqlParameter("@CafeMenuCategoryName", SqlDbType.NVarChar, 50) { Value = cafeMenuCategory.CafeMenuCategoryName }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuCategory", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the menu category: " + ex.Message);
            }
        }

        // Delete a MenuItemSizeCategory
        public bool DeleteMenuCategory(int cafeMenuCategoryId)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Delete" },
                new SqlParameter("@CafeMenuCategoryID", SqlDbType.Int) { Value = cafeMenuCategoryId }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuCategory", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while deleting the menu category: " + ex.Message);
            }
        }


        public List<CafeMenuCategory> GetCafeMenuCategory(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@CafeMenuCategoryID", DBNull.Value),
                new SqlParameter("@CafeMenuCategoryName", DBNull.Value)
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
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageCafeMenuCategory", parameters))
                {
                    var cafeMenuCategory = new List<CafeMenuCategory>();
                    while (reader.Read())
                    {
                        cafeMenuCategory.Add(new CafeMenuCategory
                        {
                            CafeMenuCategoryID = reader.GetInt32(reader.GetOrdinal("CafeMenuCategoryID")),
                            CafeMenuCategoryName = reader.GetString(reader.GetOrdinal("CafeMenuCategoryName"))
                        });
                    }
                    return cafeMenuCategory;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching the menu category: " + ex.Message);
            }
        }


    }
}
