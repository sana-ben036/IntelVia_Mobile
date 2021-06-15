using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public class ProductService : IProductService
    {
        private string api = "http://productapiccc.herokuapp.com/api/product/";
        public async Task<ObservableCollection<Product>> GetProduct()
        {
            string url = api;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<ObservableCollection<Product>>(result);

                return json;

            }

            return null;

        }
    }
}
