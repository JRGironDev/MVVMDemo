using MVVMModel.MVVM.Models;

namespace MVVMModel.MVVM.Views;

    public partial class PersonView : ContentPage
    {
        public PersonView()
        {
            InitializeComponent();

            var person = new Person
            {
                Name = "José",
                Age = 35
            };

            BindingContext = person;
        }
    }
