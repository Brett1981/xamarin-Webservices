using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        private void ButtonSearch_OnClicked(object sender, EventArgs e)
        {
          SearchEmployees();
        }
        public async void SearchEmployees()
        {
            List<Employee> employees = new List<Employee>();
            var key = TxtSearch.Text;
            Uri URl = new Uri("http://localhost:50842/api/Employees/Searchlist/"+key); //replace your url  

            HttpClient client = new HttpClient();

            HttpResponseMessage requeteGet = await client.GetAsync(URl);

            string response = await requeteGet.Content.ReadAsStringAsync();

            employees = JsonConvert.DeserializeObject<List<Employee>>(response);
            Mainlistview.ItemsSource = employees;

        }
    }
}
