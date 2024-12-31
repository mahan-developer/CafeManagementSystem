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
    public class CafeMenuItemRepository
    {
        private readonly string _connectionString;
        private readonly DatabaseHelper _databaseHelper;
        public CafeMenuItemRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);
        }

        // Insert a new MenuItem
        public int InsertCafeMenuItem(CafeMenuItem cafeMenuItem)
        {
           
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                new SqlParameter("@CafeMenuCategoryID", SqlDbType.Int) { Value = cafeMenuItem.CafeMenuCategoryID },
                new SqlParameter("@CafeMenuCategoryName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuCategoryName },
                new SqlParameter("@CafeMenuItemSizeCategoryID", SqlDbType.Int) { Value = cafeMenuItem.CafeMenuItemSizeCategoryID },
                new SqlParameter("@CafeMenuItemSizeCategoryName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuItemSizeCategoryName },
                new SqlParameter("@CafeMenuItemSizeID", SqlDbType.Int) { Value = cafeMenuItem.CafeMenuItemSizeID },
                new SqlParameter("@CafeMenuItemSizeName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuItemSizeName },
                new SqlParameter("@CafeMenuItemName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuItemName },                
                new SqlParameter("@CafeMenuItemIsAvailable", SqlDbType.Bit) { Value = cafeMenuItem.CafeMenuItemIsAvailable },
                new SqlParameter("@CafeMenuItemDescripton", SqlDbType.NVarChar, 250) { Value = cafeMenuItem.CafeMenuItemDescripton },
                new SqlParameter("@CafeMenuItemImage", SqlDbType.NVarChar, 20) { Value = cafeMenuItem.CafeMenuItemImage }
            };
            var priceParameter = new SqlParameter("@CafeMenuItemPrice", SqlDbType.Decimal)
            {
                Value = cafeMenuItem.CafeMenuItemPrice
            };
            priceParameter.Precision = 18;
            priceParameter.Scale = 2;
            parameters.Add(priceParameter);

            try
            {
                return _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItem", parameters);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while inserting the menu item: " + ex.Message);
            }
        }


        // Update an existing MenuItem
        public bool EditCafeMenuItem(CafeMenuItem cafeMenuItem)
        {
            
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
                new SqlParameter("@CafeMenuItemID", SqlDbType.Int) { Value = cafeMenuItem.CafeMenuItemID },
                new SqlParameter("@CafeMenuCategoryID", SqlDbType.Int) { Value = cafeMenuItem.CafeMenuCategoryID },
                new SqlParameter("@CafeMenuCategoryName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuCategoryName },
                new SqlParameter("@CafeMenuItemSizeCategoryID", SqlDbType.Int) { Value = cafeMenuItem.CafeMenuItemSizeCategoryID },
                new SqlParameter("@CafeMenuItemSizeCategoryName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuItemSizeCategoryName },
                new SqlParameter("@CafeMenuItemSizeID", SqlDbType.Int) { Value = cafeMenuItem.CafeMenuItemSizeID },
                new SqlParameter("@CafeMenuItemSizeName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuItemSizeName },
                new SqlParameter("@CafeMenuItemName", SqlDbType.NVarChar, 25) { Value = cafeMenuItem.CafeMenuItemName },
                new SqlParameter("@CafeMenuItemIsAvailable", SqlDbType.Bit) { Value = cafeMenuItem.CafeMenuItemIsAvailable },
                new SqlParameter("@CafeMenuItemDescripton", SqlDbType.NVarChar, 250) { Value = cafeMenuItem.CafeMenuItemDescripton },
                new SqlParameter("@CafeMenuItemImage", SqlDbType.NVarChar, 20) { Value = cafeMenuItem.CafeMenuItemImage }
            };
            var priceParameter = new SqlParameter("@CafeMenuItemPrice", SqlDbType.Decimal)
            {
                Value = cafeMenuItem.CafeMenuItemPrice
            };
            priceParameter.Precision = 18;
            priceParameter.Scale = 2;
            parameters.Add(priceParameter);

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItem", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the menu item: " + ex.Message);
            }
        }

        // Delete a MenuItem
        public bool DeleteCafeMenuItem(int cafeMenuItemId)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Delete" },
                new SqlParameter("@CafeMenuItemID", SqlDbType.Int) { Value = cafeMenuItemId }
            };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageCafeMenuItem", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while deleting the menu item: " + ex.Message);
            }
        }

        public List<CafeMenuItem> GetCafeMenuItem(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@CafeMenuItemID", DBNull.Value),                
                new SqlParameter("@CafeMenuCategoryID", DBNull.Value),
                new SqlParameter("@CafeMenuCategoryName", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeCategoryID", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeCategoryName", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeID", DBNull.Value),
                new SqlParameter("@CafeMenuItemSizeName", DBNull.Value),
                new SqlParameter("@CafeMenuItemName", DBNull.Value),
                new SqlParameter("@CafeMenuItemPrice", DBNull.Value),
                new SqlParameter("@CafeMenuItemIsAvailable", DBNull.Value),
                new SqlParameter("@CafeMenuItemDescripton", DBNull.Value),
                new SqlParameter("@CafeMenuItemImage", DBNull.Value)
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
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageCafeMenuItem", parameters))
                {
                    var cafeMenuItem = new List<CafeMenuItem>();
                    while (reader.Read())
                    {
                        cafeMenuItem.Add(new CafeMenuItem
                        {
                            CafeMenuItemID = reader.GetInt32(reader.GetOrdinal("CafeMenuItemID")),
                            CafeMenuCategoryID = reader.GetInt32(reader.GetOrdinal("CafeMenuCategoryID")),
                            CafeMenuCategoryName = reader.GetString(reader.GetOrdinal("CafeMenuCategoryName")),                            
                            CafeMenuItemSizeCategoryID = reader.GetInt32(reader.GetOrdinal("CafeMenuItemSizeCategoryID")),
                            CafeMenuItemSizeCategoryName = reader.GetString(reader.GetOrdinal("CafeMenuItemSizeCategoryName")),
                            CafeMenuItemSizeID = reader.GetInt32(reader.GetOrdinal("CafeMenuItemSizeID")),
                            CafeMenuItemSizeName = reader.GetString(reader.GetOrdinal("CafeMenuItemSizeName")),
                            CafeMenuItemName = reader.GetString(reader.GetOrdinal("CafeMenuItemName")),
                            CafeMenuItemPrice = reader.GetDecimal(reader.GetOrdinal("CafeMenuItemPrice")),
                            CafeMenuItemIsAvailable = reader.GetBoolean(reader.GetOrdinal("CafeMenuItemIsAvailable")),
                            CafeMenuItemDescripton = reader.GetString(reader.GetOrdinal("CafeMenuItemDescripton")),
                            CafeMenuItemImage = reader.GetString(reader.GetOrdinal("CafeMenuItemImage")),
                        });
                    }
                    return cafeMenuItem;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching menu item: " + ex.Message);
            }
        }



    }
}
