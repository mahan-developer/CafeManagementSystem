using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using BusinessApplicationLayer;

namespace CafeManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = ServiceConfigurator.ConfigureServices();
            var customerService = serviceProvider.GetService<CustomerService>();
            var settingService = serviceProvider.GetService<SettingsService>();
            var databaseInitializerService = serviceProvider.GetService<DatabaseInitializerService>();
            var menuItemSizeCategoryService = serviceProvider.GetService<CafeMenuItemSizeCategoryService>();
            var menuItemSizeService = serviceProvider.GetService<CafeMenuItemSizeService>();
            var invoiceService = serviceProvider.GetService<InvoiceService>();
            var invoiceItemService = serviceProvider.GetService<InvoiceItemService>();
            var cafeMenuItemService = serviceProvider.GetService<CafeMenuItemService>();
            var cafeMenuCategoryService = serviceProvider.GetService<CafeMenuCategoryService>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(databaseInitializerService, settingService, customerService, menuItemSizeCategoryService,
                menuItemSizeService, invoiceService, invoiceItemService, cafeMenuItemService, cafeMenuCategoryService));
        }
    }
}
