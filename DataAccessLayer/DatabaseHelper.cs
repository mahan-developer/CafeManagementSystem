using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CommonUtilities;

namespace DataAccessLayer
{
    public class DatabaseHelper
    {

        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int ExecuteStoredProcedure(string storedProcedureName, List<SqlParameter> parameters)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var cmd = new SqlCommand(storedProcedureName, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }
                        connection.Open();

                        return cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex); 
                throw new Exception("Database error occurred: " + ex.Message);
            }
        }



        public SqlDataReader ExecuteReaderStoredProcedure(string storedProcedureName, List<SqlParameter> parameters)
        {
            var connection = new SqlConnection(_connectionString);
            try
            {
                var cmd = new SqlCommand(storedProcedureName, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (parameters != null && parameters.Count > 0)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                connection.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                connection.Close();
                ErrorHandler.LogException(ex);
                throw;
            }
        }



    }
}
