using App1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void EndangeredAnimalsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndangeredAnimals());
        }

        private async void AddAnimalClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowEmployeePage());
        }

    }
}
