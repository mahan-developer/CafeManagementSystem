using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ServiceProcess;
using BusinessEntitiesLayer;
using System.Reflection;
using CommonUtilities;

namespace DataAccessLayer
{
    public class DatabaseInitializer
    {
        private readonly string _masterConnectionString;
        private readonly string _connectionString;
        private readonly string _databaseName;

        public DatabaseInitializer()
        {
            _masterConnectionString = @"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _databaseName = GetDatabaseNameFromConnectionString(_connectionString);
        }


        // Method to check for the existence of sql
        public bool CheckSqlServerExists()
        {
            string serviceName = "MSSQL$SQLEXPRESS";

            try
            {
                ServiceController service = new ServiceController(serviceName);
                return service.Status == ServiceControllerStatus.Running || service.Status == ServiceControllerStatus.Stopped;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }
        }


        // Extract database name from connection string
        private string GetDatabaseNameFromConnectionString(string connectionString)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            return builder.InitialCatalog;
        }
         
        // Method to check database existence
        public bool CheckDatabaseExists()
        {
            using (var connection = new SqlConnection(_masterConnectionString))
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{_databaseName}'";
                using (var cmd = new SqlCommand(query, connection))
                {
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }


        // Method to check for the existence of tables
        public bool CheckTablesExist(List<string> tableNames)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    foreach (var tableName in tableNames)
                    {
                        string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
                        using (var cmd = new SqlCommand(query, connection))
                        {
                            int count = (int)cmd.ExecuteScalar();
                            if (count == 0)
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogException(ex);
                    throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
                }
            }
        }


        // Method for creating a database alone
        public bool CreateDatabaseIfNotExists()
        {
            if (!CheckDatabaseExists())
            {
                using (var connection = new SqlConnection(_masterConnectionString))
                {
                    connection.Open();
                    string createDbQuery = $"CREATE DATABASE [{_databaseName}]";
                    using (var cmd = new SqlCommand(createDbQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            else
                return false;
        }

        // Method for creating tables alone
        public void CreateTablesAndProceduresIfNotExists(IEnumerable<Type> entityTypes)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var entityType in entityTypes)
                        {
                            string tableName = entityType.Name;

                            // Step 1: Create the table
                            string createTableQuery = GenerateCreateTableQuery(entityType, tableName);
                            ExecuteQuery(connection, transaction, createTableQuery);

                            // Step 2: Create Stored Procedures
                            string createProcedureQuery = GenerateCreateProcedureQueries(tableName, entityType);
                            ExecuteQuery(connection, transaction, createProcedureQuery);
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ErrorHandler.LogException(ex);
                        throw new Exception("Error while creating tables or procedures: " + ex.Message);
                    }
                }
            }
        }

        private void ExecuteQuery(SqlConnection connection, SqlTransaction transaction, string query)
        {
            if (string.IsNullOrEmpty(query))
                return;

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.ExecuteNonQuery();
            }
        }

        // Method to generate a CREATE TABLE query based on entity fields
        private string GenerateCreateTableQuery(Type entityType, string tableName)
        {
            var properties = entityType.GetProperties();
            List<string> columnDefinitions = new List<string>();

            foreach (var prop in properties)
            {
                string columnName = prop.Name;
                string columnType = "NVARCHAR(255)"; // Default value

                var columnAttr = prop.GetCustomAttribute<ColumnAttribute>();
                if (columnAttr != null)
                {
                    if (columnAttr.DataType == "DECIMAL")
                    {
                        columnType = $"{columnAttr.DataType}({columnAttr.Precision},{columnAttr.Scale})";
                    }
                    else if (columnAttr.Length > 0)
                    {
                        columnType = $"{columnAttr.DataType}({columnAttr.Length})";
                    }
                    else
                    {
                        columnType = columnAttr.DataType;
                    }
                }
                else
                {
                    // If Attribute is not present, the data type is determined based on the field type
                    columnType = GetSqlType(prop.PropertyType);
                }

                if (columnName.Equals($"{tableName}ID", StringComparison.OrdinalIgnoreCase))
                {
                    columnDefinitions.Add($"{columnName} {columnType} PRIMARY KEY IDENTITY");
                }
                else
                {
                    columnDefinitions.Add($"{columnName} {columnType}");
                }
            }


            return $"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='{tableName}' AND xtype='U') " +
                   $"CREATE TABLE {tableName} ({string.Join(", ", columnDefinitions)})";

        }






        private string GenerateCreateProcedureQueries(string tableName, Type entityType)
        {
            var procedures = new StringBuilder();

            // دریافت خصوصیات کلاس (Entity)
            var properties = entityType.GetProperties();
            var primaryKey = $"{tableName}ID";

            // تعریف پارامترها برای عملیات CRUD
            var insertParameters = string.Join(", ", properties.Select(p => $"@{p.Name} {GetSqlType(p.PropertyType)}"));
            var updateDeleteParameters = string.Join(", ", properties.Select(p => $"@{p.Name} {GetSqlType(p.PropertyType)} = NULL"));

            var columns = string.Join(", ", properties.Where(p => p.Name != primaryKey).Select(p => p.Name));
            var values = string.Join(", ", properties.Where(p => p.Name != primaryKey).Select(p => $"@{p.Name}"));
            var updateSets = string.Join(", ", properties.Where(p => p.Name != primaryKey).Select(p => $"{p.Name} = @{p.Name}"));

            // ایجاد شرط‌ها برای Select (بر اساس نوع داده)
            var conditions = string.Join(" ", properties.Select(p =>
            {
                if (p.PropertyType == typeof(bool) || p.PropertyType == typeof(int) || p.PropertyType == typeof(decimal))
                {
                    // شرط برای انواع عددی و منطقی
                    return $"AND (@{p.Name} IS NULL OR {p.Name} = @{p.Name})";
                }
                else if (p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(DateTime?))
                {
                    // شرط برای نوع DateTime
                    return $"AND (@{p.Name} IS NULL OR CAST({p.Name} AS DATE) = CAST(@{p.Name} AS DATE))";
                }
                else
                {
                    // شرط برای رشته‌ها
                    return $"AND (@{p.Name} IS NULL OR {p.Name} LIKE ''%'' + @{p.Name} + ''%'')";
                }
            }));

            // تولید کوئری ایجاد Stored Procedures
            procedures.Append($@"
    IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'spManage{tableName}' AND type = 'P')
    BEGIN
        EXEC('
        CREATE PROCEDURE spManage{tableName}
            @Operation NVARCHAR(10),
            {updateDeleteParameters}
        AS
        BEGIN
            IF @Operation = ''Insert''
            BEGIN
                INSERT INTO {tableName} ({columns})
                VALUES ({values});
            END

            ELSE IF @Operation = ''Select''
            BEGIN
                SELECT * FROM {tableName} WHERE 1=1
                {conditions};
            END

            ELSE IF @Operation = ''Update''
            BEGIN
                UPDATE {tableName}
                SET {updateSets}
                WHERE {primaryKey} = @{primaryKey};
            END

            ELSE IF @Operation = ''Delete''
            BEGIN
                DELETE FROM {tableName}
                WHERE {primaryKey} = @{primaryKey};
            END
        END');
    END;");

            return procedures.ToString();
        }




        //private string GenerateCreateProcedureQueries(string tableName, Type entityType)
        //{
        //    var procedures = new StringBuilder();

        //    // دریافت خصوصیات کلاس (Entity)
        //    var properties = entityType.GetProperties();
        //    var primaryKey = $"{tableName}ID";

        //    // تعریف پارامترها برای عملیات CRUD
        //    var insertParameters = string.Join(", ", properties.Select(p => $"@{p.Name} {GetSqlType(p.PropertyType)}"));
        //    var updateDeleteParameters = string.Join(", ", properties.Select(p => $"@{p.Name} {GetSqlType(p.PropertyType)} = NULL"));

        //    var columns = string.Join(", ", properties.Where(p => p.Name != primaryKey).Select(p => p.Name));
        //    var values = string.Join(", ", properties.Where(p => p.Name != primaryKey).Select(p => $"@{p.Name}"));
        //    var updateSets = string.Join(", ", properties.Where(p => p.Name != primaryKey).Select(p => $"{p.Name} = @{p.Name}"));

        //    // ایجاد شرط‌ها برای Select (بر اساس نوع داده)
        //    var conditions = string.Join(" ", properties.Select(p =>
        //    {
        //        if (p.PropertyType == typeof(bool) || p.PropertyType == typeof(int) || p.PropertyType == typeof(decimal))
        //            return $"AND (@{p.Name} IS NULL OR {p.Name} = @{p.Name})"; // برای ستون‌های عددی و منطقی
        //        else
        //            return $"AND (@{p.Name} IS NULL OR {p.Name} LIKE ''%'' + @{p.Name} + ''%'')"; // برای رشته‌ها
        //    }));

        //    // تولید کوئری ایجاد Stored Procedures
        //    procedures.Append($@"
        //    IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'spManage{tableName}' AND type = 'P')
        //    BEGIN
        //        EXEC('
        //        CREATE PROCEDURE spManage{tableName}
        //            @Operation NVARCHAR(10),
        //            {updateDeleteParameters}
        //        AS
        //        BEGIN
        //            IF @Operation = ''Insert''
        //            BEGIN
        //                INSERT INTO {tableName} ({columns})
        //                VALUES ({values});
        //            END

        //            ELSE IF @Operation = ''Select''
        //            BEGIN
        //                SELECT * FROM {tableName} WHERE 1=1
        //                {conditions};
        //            END

        //            ELSE IF @Operation = ''Update''
        //            BEGIN
        //                UPDATE {tableName}
        //                SET {updateSets}
        //                WHERE {primaryKey} = @{primaryKey};
        //            END

        //            ELSE IF @Operation = ''Delete''
        //            BEGIN
        //                DELETE FROM {tableName}
        //                WHERE {primaryKey} = @{primaryKey};
        //            END
        //        END');
        //    END;");

        //    return procedures.ToString();
        //}




        // Method to check default values ​​of tables
        public bool CheckDefaultDataExists()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    string query = $"SELECT count(*) FROM Customer";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    ErrorHandler.LogException(ex);
                    throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
                }
            }
        }




        // Method to convert C# types to SQL types
        private string GetSqlType(Type type)
        {
            if (type == typeof(int))
                return "INT";
            if (type == typeof(string))
                return "NVARCHAR(255)";
            if (type == typeof(decimal))
                return "DECIMAL(18,2)";
            if (type == typeof(DateTime))
                return "DATETIME";
            if (type == typeof(bool))
                return "BIT";

            throw new Exception($"Unsupported type: {type.Name}");
        }


        // Method for backing up the database
        public bool BackupDatabase(string backupPath)
        {
            string backupQuery = $@"
                BACKUP DATABASE [{GetDatabaseName()}] 
                TO DISK = @BackupPath 
                WITH FORMAT, INIT, NAME = 'Full Database Backup'";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(backupQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BackupPath", backupPath);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }
        }



        // Method for restoring the database
        public bool RestoreDatabase(string backupFilePath)
        {
            string databaseName = GetDatabaseName();
            string restoreQuery = $@"
                USE master;
                ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{databaseName}] FROM DISK = @BackupFilePath WITH REPLACE;
                ALTER DATABASE [{databaseName}] SET MULTI_USER;";

            try
            {
                using (var connection = new SqlConnection(_connectionString.Replace($"Initial Catalog={databaseName}", "Initial Catalog=master")))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(restoreQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BackupFilePath", backupFilePath);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }
        }



        // Method to extract database name from connection string
        private string GetDatabaseName()
        {
            var builder = new SqlConnectionStringBuilder(_connectionString);
            return builder.InitialCatalog;
        }


    }
}
