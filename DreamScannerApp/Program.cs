using DreamScannerApp.Controllers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace DreamScannerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Set up dependency injection
            var serviceProvider = new ServiceCollection()
                .AddScoped<IStudentService, StudentService>()
                .BuildServiceProvider();

            // Resolve the StudentController
            var studentService = serviceProvider.GetService<StudentController>();

            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Initialize the database (if needed)
            DatabaseFacade facade = new DatabaseFacade(new ApplicationDbContext());
            facade.EnsureCreated();

            // Run the main form
            Application.Run(new UI.MainDashboardFrm());
        }
    }

}