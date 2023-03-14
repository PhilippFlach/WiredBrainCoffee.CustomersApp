using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase() { }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
