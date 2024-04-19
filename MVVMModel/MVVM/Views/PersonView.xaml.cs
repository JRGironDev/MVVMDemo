using MVVMModel.MVVM.Models;
using MVVMModel.MVVM.ViewModels;

namespace MVVMModel.MVVM.Views;

    public partial class PersonView : ContentPage
    {
        public PersonView()
        {
            InitializeComponent();

            BindingContext = new PersonViewModel();
        }
    }
