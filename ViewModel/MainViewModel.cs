﻿using System.Threading.Tasks;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly CustomersViewModel _customersViewModel;
        private readonly ProductsViewModel _productsViewModel;
        private ViewModelBase? _selectedViewModel;

        public MainViewModel(CustomersViewModel customersViewModel,
            ProductsViewModel productsViewModel)
        {
            _customersViewModel = customersViewModel;
            _productsViewModel = productsViewModel;
            SelectedViewModel = _customersViewModel;
        }

        public ViewModelBase? SelectedViewModel
        {
			get { return _selectedViewModel; }
			set
            {
                _selectedViewModel = value;
                RaisePropertyChanged();
            }
        }
        public async override Task LoadAsync()
        {
            if (_selectedViewModel is not null) 
            {
                await SelectedViewModel.LoadAsync();
            }
        }
	}
}
