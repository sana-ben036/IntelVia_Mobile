using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public interface IProductService
    {
        Task<ObservableCollection<Product>> GetProduct();
    }
}
