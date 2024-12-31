using CommonUtilities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationLayer
{
    public class DatabaseInitializerService
    {
        private readonly DatabaseInitializer _dbInitializer;

        public DatabaseInitializerService(DatabaseInitializer databaseInitializer)
        {
            _dbInitializer = databaseInitializer ?? throw new ArgumentNullException(nameof(databaseInitializer));
        }

        // Method to check for the existence of SQL Server
        public bool CheckSQLServerExists()
        {
            try
            {
                return _dbInitializer.CheckSqlServerExists();
            }
            catch (Exception ex)
            {
                // Log the exception and rethrow it with a friendly message
                ErrorHandler.LogException(ex);
                throw new Exception("Error while checking SQL Server existence.", ex);
            }
        }

        // Method to check database existence
        public bool CheckDatabaseExists()
        {
            try
            {
                return _dbInitializer.CheckDatabaseExists();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while checking database existence.", ex);
            }
        }

        // Method to check if tables exist
        public bool CheckTablesExist(List<string> tableNames)
        {
            if (tableNames == null || !tableNames.Any())
                throw new ArgumentException("Table names cannot be null or empty.", nameof(tableNames));

            try
            {
                return _dbInitializer.CheckTablesExist(tableNames);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while checking table existence.", ex);
            }
        }

        // Method for creating a database if it does not exist
        public bool CreateDatabaseIfNotExists()
        {
            try
            {
                return _dbInitializer.CreateDatabaseIfNotExists();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while creating the database.", ex);
            }
        }

        // Method for creating tables and procedures
        public void CreateTablesAndProceduresIfNotExists(IEnumerable<Type> entityTypes)
        {
            if (entityTypes == null || !entityTypes.Any())
                throw new ArgumentException("Entity types cannot be null or empty.", nameof(entityTypes));

            try
            {
                _dbInitializer.CreateTablesAndProceduresIfNotExists(entityTypes);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while creating tables and procedures.", ex);
            }
        }

        // Method to check if default data exists
        public bool CheckDefaultDataExists()
        {
            try
            {
                return _dbInitializer.CheckDefaultDataExists();
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while checking default data existence.", ex);
            }
        }

        // Method for database backup
        public bool BackupDatabase(string backupPath)
        {
            if (string.IsNullOrWhiteSpace(backupPath))
                throw new ArgumentException("Backup path cannot be null or empty.", nameof(backupPath));

            try
            {
                return _dbInitializer.BackupDatabase(backupPath);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while performing database backup.", ex);
            }
        }

        // Method for database restore
        public bool RestoreDatabase(string backupFilePath)
        {
            if (string.IsNullOrWhiteSpace(backupFilePath))
                throw new ArgumentException("Backup file path cannot be null or empty.", nameof(backupFilePath));

            try
            {
                return _dbInitializer.RestoreDatabase(backupFilePath);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception("Error while restoring the database.", ex);
            }
        }
    }
}
