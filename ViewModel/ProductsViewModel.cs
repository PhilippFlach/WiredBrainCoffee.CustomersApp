using WiredBrainCoffee.CustomersApp.Data;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
    public class ProductsViewModel : ViewModelBase
    {
        private readonly IProductDataProvider _productDataProvider;

        public ProductsViewModel(IProductDataProvider productDataProvider)
        {
            _productDataProvider = productDataProvider;
        }
    }
}
