using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Helpers
{
    public static class DatabaseBackupHelper
    {
        public static void BackupDatabase(DbContext dbContext, string backupFolderPath)
        {
            try
            {
                // Get the database file path from the DbContext
                string databaseFilePath = dbContext.Database.GetDbConnection().DataSource;

                // Ensure the database file path is not null or empty
                if (string.IsNullOrEmpty(databaseFilePath))
                {
                    Console.WriteLine("Database file path is not available.");
                    return;
                }

                // Generate a backup file name with a timestamp
                string backupFileName = $"backup_{DateTime.Now:yyyyMMddHHmmss}.db";
                string backupFilePath = Path.Combine(backupFolderPath, backupFileName);

                // Copy the database file to the backup location
                File.Copy(databaseFilePath, backupFilePath);

                Console.WriteLine($"Database backup created successfully: {backupFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating database backup: {ex.Message}");
            }
        }

        public static void RestoreDatabaseFromBackup(string backupFilePath, string databaseFilePath)
        {
            try
            {
                // Check if the backup file exists
                if (!File.Exists(backupFilePath))
                {
                    Console.WriteLine("Backup file not found.");
                    return;
                }

                // Check if the database file exists
                if (!File.Exists(databaseFilePath))
                {
                    Console.WriteLine("Database file not found.");
                    return;
                }

                // Replace the database file with the backup file
                File.Copy(backupFilePath, databaseFilePath, true);

                Console.WriteLine("Database restored successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restoring database from backup: {ex.Message}");
            }
        }


    }
}
