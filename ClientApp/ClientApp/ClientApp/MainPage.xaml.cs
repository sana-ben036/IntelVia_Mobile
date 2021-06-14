using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClientApp
{
    public partial class MainPage : ContentPage
    {
        private string Api = "http://karangue.azurewebsites.net/api/apiDeclarations";
        public MainPage()
        {
            InitializeComponent();
            Demarreur();
        }

        private async Task Demarreur()
        {
            var client = new HttpClient();
            string json = await client.GetStringAsync(Api);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            ListData.ItemsSource = products;
        }
    }
}
