using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

using Xamarin.Forms;
using RestClient.Client;

namespace App1
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ButtonGet_OnClicked(object sender, EventArgs e)
        {
            GetDepartements();
        }

        private void ButtonPost_OnClicked(object sender, EventArgs e)
        {
            PostDepartements();
        }

        private void ButtonPut_OnClicked(object sender, EventArgs e)
        {
            PutDepartements();
        }

        private void ButtonDelete_OnClicked(object sender, EventArgs e)
        {
            DeleteDepartements();
        }

        public async void GetDepartements()
        {
            var classs = new GenericRestClient<Departement>();
            Mainlistview.ItemsSource = await classs.GetAsync();
        }

        public async void PostDepartements()
        {
            var restClient = new GenericRestClient<Departement>();
            await restClient.PostAsync(new Departement
            {
                Name = txtname1.Text,
            });
        }


        public async void PutDepartements()
        {
            var restClient = new GenericRestClient<Departement>();
            var id = Int32.Parse(txtId2.Text);
            await restClient.PutAsync(id, new Departement
            {
                DepartementId = id,
                Name = txtname2.Text,
            });
        }

        public async void DeleteDepartements()
        {
            var restClient = new GenericRestClient<Departement>();
            var id = Int32.Parse(txtId3.Text);
            Boolean ok = await restClient.DeleteAsync(id);
        }
    }
}
