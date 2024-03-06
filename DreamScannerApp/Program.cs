using DreamScannerApp.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DreamScannerApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginFrm());
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();
            Application.Run(new UI.MainDashboardFrm());
        }

    }
}