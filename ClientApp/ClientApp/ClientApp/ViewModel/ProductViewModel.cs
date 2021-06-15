using ClientApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ClientApp.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged    
    {
        public event PropertyChangedEventHandler PropertyChanged;

        IProductService _rest = DependencyService.Get<IProductService>();

        public ProductViewModel()
        {
            GetProduct();
        }

        public async void GetProduct()
        {
            var result = await _rest.GetProduct();

            if(result != null)
            {
                Products = result;
            }
        }

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set 
            {
                products = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Products"));
            }
        }
    }
}
