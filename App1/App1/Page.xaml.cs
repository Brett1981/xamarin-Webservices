using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();
        }

        private void ButtonEmployee_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MainPage());
        }

        private void ButtonDepartement_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Page1());
        }

        private void ButtonSearch_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Search());
        }
    }
}
