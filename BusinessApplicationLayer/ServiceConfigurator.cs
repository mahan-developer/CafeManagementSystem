using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;


namespace BusinessApplicationLayer
{
    public class ServiceConfigurator
    {
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            services.AddSingleton(new DatabaseConnection(connectionString));

            services.AddSingleton<DatabaseConnection>();
            services.AddSingleton<CustomerRepository>();
            services.AddSingleton<CustomerService>();
            services.AddSingleton<InvoiceRepository>();
            services.AddSingleton<InvoiceService>();
            services.AddSingleton<InvoiceItemRepository>();
            services.AddSingleton<InvoiceItemService>();
            services.AddSingleton<CafeMenuItemService>();
            services.AddSingleton<CafeMenuItemRepository>();
            services.AddSingleton<CafeMenuItemSizeRepository>();
            services.AddSingleton<CafeMenuItemSizeService>();
            services.AddSingleton<CafeMenuItemSizeCategoryRepository>();
            services.AddSingleton<CafeMenuItemSizeCategoryService>();
            services.AddSingleton<SettingsRepository>();
            services.AddSingleton<SettingsService>();
            services.AddSingleton<DatabaseInitializer>();
            services.AddSingleton<DatabaseInitializerService>();
            services.AddSingleton<CafeMenuCategoryService>();
            services.AddSingleton<CafeMenuCategoryRepository>();

            return services.BuildServiceProvider();
        }
    }
}
