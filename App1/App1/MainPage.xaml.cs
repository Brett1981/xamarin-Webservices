using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RestClient.Client;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonGet_OnClicked(object sender, EventArgs e)
        {
           GetEmployees(); 
        }

        private void ButtonPost_OnClicked(object sender, EventArgs e)
        {
         PostEmployees();
        }

        private void ButtonPut_OnClicked(object sender, EventArgs e)
        {
           PutEmployees();
        }

        private void ButtonDelete_OnClicked(object sender, EventArgs e)
        {
           DeleteEmployees();
        }

        public async void GetEmployees()
        {
            var Restclient = new GenericRestClient<Employee>();

            var employees = await Restclient.GetAsync();
           
           Mainlistview.ItemsSource = employees;

        }

        public async void PostEmployees()
        {
            Employee E = new Employee();
            E.Name = txtname1.Text;
            E.Email = txtmail1.Text;

            var restClient = new GenericRestClient<Employee>();
            await restClient.PostAsync(new Employee
            {
                Name = txtname1.Text,
                Email = txtmail1.Text,
        });
        }


        public async void PutEmployees()
        {
            var restClient = new GenericRestClient<Employee>();
            var id = Int32.Parse(txtId2.Text);
            await restClient.PutAsync(id, new Employee
            {
                Name = txtname2.Text,
                Email = txtmail2.Text,
                EmployeeId = int.Parse(txtId2.Text),
            });
        }

        public async void DeleteEmployees()
        {
            var restClient = new GenericRestClient<Employee>();
            var id = Int32.Parse(txtId3.Text);
            Boolean ok = await restClient.DeleteAsync(id);

        }
    }
}
