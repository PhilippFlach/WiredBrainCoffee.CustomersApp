using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using WiredBrainCoffee.CustomersApp.Data;
using WiredBrainCoffee.CustomersApp.ViewModel;

namespace WiredBrainCoffee.CustomersApp
{

    public partial class App : Application
    {
        public App()
        {
            ServiceCollection services  = new ();
            ConfigureServices(services);
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainWindow>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<CustomersViewModel>();
            services.AddTransient<ProductsViewModel>();

            services.AddTransient<ICustomerDataProvider, CustomerDataProvider>();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow(new MainViewModel(
                new CustomersViewModel(new CustomerDataProvider()),
                new ProductsViewModel()));
            mainWindow.Show();
        }
    }
}
