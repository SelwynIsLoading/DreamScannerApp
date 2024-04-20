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

namespace DreamScannerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build the host
            var host = CreateHostBuilder().Build();

            // Resolve the service provider from the host
            ServiceProvider = host.Services;

            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Run the main form
            Application.Run(new LoginFrm());
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


    }

}