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
    public partial class AddAnimal : ContentPage
    {
        EmployeeViewModel _viewModel;
        bool _isUpdate;
        int employeeID;
        public AddEmployee()
        {
            InitializeComponent();
            _viewModel = new AnimalViewModel();
            _isUpdate = false;
        }
        public AddEmployee(EmployeeModel obj)
        {
            InitializeComponent();
            _viewModel = new AnimalViewModel();
            if (obj != null)
            {
                employeeID = obj.Id;
                txtAnimal.Text = obj.Animal;
                txtChar.Text = obj.Characteristics;
                txtSpecies.Text = obj.Species;
                txtHabitat.Text = obj.Habitat;
                txtThreat.Text = obj.Threat;
                _isUpdate = true;
            }
        }

        private async void btnSaveUpdate_Clicked(object sender, EventArgs e)
        {
            AnimalModel obj = new AnimalModel();
            obj.Animal = txtAnimal.Text;
            obj.Characteristics = txtChar.Text;
            obj.Species = txtSpecies.Text;
            obj.Habitat = txtHabitat.Text;
            obj.Threat = txtThreat.Text;
            if (_isUpdate)
            {
                obj.Id = employeeID;
                await _viewModel.UpdateAnimal(obj);
            }
            else
            {
                _viewModel.InsertEmployee(obj);
            }
            await this.Navigation.PopAsync();
        }
    }
}
