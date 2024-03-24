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

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Configure services
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlite("Data Source=school.db"))
                .BuildServiceProvider();


            // Apply pending migrations
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                try
                {
                    dbContext.Database.Migrate();
                    Console.WriteLine("Migrations applied successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while applying migrations: " + ex.Message);
                }
            }

            // Run the main form
            Application.Run(ServiceProvider.GetRequiredService<MainDashboardFrm>());
            //Application.Run(new LoginFrm());
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
                });
        }


    }

}