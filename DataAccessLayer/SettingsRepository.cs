using BusinessEntitiesLayer;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CommonUtilities;


namespace DataAccessLayer
{

    public class SettingsRepository
    {
        private readonly DatabaseHelper _databaseHelper;
        private readonly string _connectionString;
        public SettingsRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseHelper = new DatabaseHelper(_connectionString);
        }


        public int InsertSetting(Settings settings)
        {
            var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Insert" },
                    new SqlParameter("@SettingsKey", SqlDbType.NVarChar, 50) { Value = settings.SettingsKey },
                    new SqlParameter("@SettingsValue", SqlDbType.NVarChar, 250) { Value = settings.SettingsValue }
             };

            return _databaseHelper.ExecuteStoredProcedure("spManageSettings", parameters);
        }

        public bool EditSetting(Settings settings)
        {
            var parameters = new List<SqlParameter>
        {
            new SqlParameter("@Operation", SqlDbType.NVarChar, 10) { Value = "Update" },
            new SqlParameter("@SettingsID", SqlDbType.Int) { Value = settings.SettingsID },
            new SqlParameter("@SettingsKey", SqlDbType.NVarChar, 50) { Value = settings.SettingsKey },
            new SqlParameter("@SettingsValue", SqlDbType.NVarChar, 250) { Value = settings.SettingsValue }
        };

            try
            {
                int rowsAffected = _databaseHelper.ExecuteStoredProcedure("spManageSettings", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while updating the settings: " + ex.Message);
            }
        }




        public List<Settings> GetSetting(Dictionary<string, object> searchParameters)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Operation", "Select"),
                new SqlParameter("@SettingsID", DBNull.Value),
                new SqlParameter("@SettingsKey", DBNull.Value),
                new SqlParameter("@SettingsValue", DBNull.Value)
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
                using (var reader = _databaseHelper.ExecuteReaderStoredProcedure("spManageSettings", parameters))
                {
                    var settings = new List<Settings>();
                    while (reader.Read())
                    {
                        settings.Add(new Settings
                        {
                            SettingsID = reader.GetInt32(reader.GetOrdinal("SettingsID")),
                            SettingsKey = reader.GetString(reader.GetOrdinal("SettingsKey")),
                            SettingsValue = reader.GetString(reader.GetOrdinal("SettingsValue"))
                        });
                    }
                    return settings;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while fetching settings: " + ex.Message);
            }
        }



    }
}