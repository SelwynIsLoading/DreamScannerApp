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

            // Initialize the database (if needed)
            DatabaseFacade facade = new DatabaseFacade(new ApplicationDbContext());
            facade.EnsureCreated();

            // Run the main form
            Application.Run(ServiceProvider.GetRequiredService<MainDashboardFrm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<ApplicationDbContext>();
                    services.AddTransient<IStudentService, StudentService>();
                    services.AddTransient<MainDashboardFrm>();
                });
        }
    }

}