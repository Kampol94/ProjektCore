using ProjektCoreMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ProjektCoreMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaKlientow : ContentPage
	{
		public ListaKlientow ()
		{
			InitializeComponent ();
            //var client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:5001/api/customers");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage respone = client.GetAsync("").Result;
            //respone.EnsureSuccessStatusCode();
            //string content = respone.Content.ReadAsStringAsync().Result;
            //var customersFromService = JsonConvert.DeserializeObject<IEnumerable<Customer>>(content);
            //foreach (Customer customer in customersFromService.OrderBy(c => c.CompanyName))
            //{
            //    Customer.Customers.Add(customer);
            //}

            Customer.SampleData();
            BindingContext = Customer.Customers;
		}

        async void Customer_Tapped(object sender, ItemTappedEventArgs e)
        {
            Customer c = e.Item as Customer;
            if (c == null) return;
            await Navigation.PushAsync(new CustomerDetails(c));
        }
        async void Customer_Refreshing(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            listView.IsRefreshing = true;
            await Task.Delay(1500);
            listView.IsRefreshing = false;
        }
        void Customer_Deleted(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Customer c = menuItem.BindingContext as Customer;
            Customer.Customers.Remove(c);
        }
        async void Customer_Phoned(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Customer c = menuItem.BindingContext as Customer;
            if (await this.DisplayAlert("Wybór numeru", "Czy chcesz zadzwonić do" + c.Phone + "?", "Tak", "Nie"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null) dialer.Dial(c.Phone);
            }
        }
        async void Add_Activated(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomerDetails());
        }
    }
}