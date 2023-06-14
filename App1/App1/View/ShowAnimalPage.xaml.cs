using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;
using App1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowEmployeePage : ContentPage
    {
        AnimalViewModel viewModel;
        public ShowAnimalPage()
        {
            InitializeComponent();
            viewModel = new AnimalViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            showAnimals();
        }
        private void showEmployee()
        {
            var res = viewModel.GetAllAnimals().Result;
            lstData.ItemsSource = res;
        }

        private void btnAddRecord_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AddAnimal());
        }

        private async void lstData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                EmployeeModel obj = (AnimalModel)e.SelectedItem;
                string res = await DisplayActionSheet("Operation", "Cancel", null, "Update", "Delete");

                switch (res)
                {
                    case "Update":
                        await this.Navigation.PushAsync(new AddAnimal(obj));

                        break;
                    case "Delete":
                        viewModel.DeleteAnimal(obj);
                        showEmployee();
                        break;
                }
                lstData.SelectedItem = null;
            }
        }
    }
}
