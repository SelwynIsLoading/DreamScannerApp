using DreamScannerApp.Controllers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Services;
using DreamScannerApp.UI;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DreamScannerApp.UserControls.StudentsUserControls;
using DreamScannerApp.Helpers;
using System.Collections.Specialized;
using System.Web;

namespace DreamScannerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // Initialize application configuration
            ApplicationConfiguration.Initialize();
            // Run the main form
            Application.Run(new LoginFrm());

            // Trigger database backup
            PerformDatabaseBackup();
        }

        public static IServiceProvider ServiceProvider { get; set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlite("Data Source=school.db"));

                    services.AddTransient<IStudentService, StudentService>();
                    services.AddTransient<StudentService>();
                    services.AddTransient<IStudentLogService, StudentLogService>();
                    services.AddTransient<MainDashboardFrm>();
                    services.AddTransient<IEmailService, EmailService>();
                    services.AddTransient<ITeacherService, TeacherService>();
                    services.AddTransient<ITeacherLogService, TeacherLogService>();
                    services.AddTransient<IExcelService, ExcelService>();
                    services.AddTransient<ISettingsService, SettingsService>();
                    services.AddTransient<IArduinoService, ArduinoService>();
                });
        }

        public static void PerformDatabaseBackup()
        {
            try
            {
                // Build the DbContextOptions using the SQLite connection string
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlite("Data Source=school.db");

                // Create an instance of your DbContext using the options
                using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
                {
                    // Get the directory of the database file
                    var databaseFilePath = dbContext.Database.GetDbConnection().DataSource;
                    var databaseDirectory = Path.GetDirectoryName(databaseFilePath);

                    // Determine the backup folder path
                    var backupFolderPath = Path.Combine(databaseDirectory, "Backups");

                    // Create the backup folder if it doesn't exist
                    Directory.CreateDirectory(backupFolderPath);

                    // Call the BackupDatabase method
                    DatabaseBackupHelper.BackupDatabase(dbContext, backupFolderPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error performing database backup: {ex.Message}");
            }
        }

        public static void RestoreDatabase()
        {
            try
            {
                // Prompt user to select the backup file
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "Database Files (*.db)|*.db|All Files (*.*)|*.*",
                    Title = "Select Database Backup File"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string backupFilePath = openFileDialog.FileName;
                    var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                    optionsBuilder.UseSqlite("Data Source=school.db");

                    // Create an instance of your DbContext using the options
                    using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
                    {
                        var databaseFilePath = dbContext.Database.GetDbConnection().DataSource;
                        var databaseDirectory = Path.GetDirectoryName(databaseFilePath);

                        // Restore database from backup file
                        DatabaseBackupHelper.RestoreDatabaseFromBackup(backupFilePath, databaseDirectory);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restoring database from backup: {ex.Message}");
            }
        }




    }

}