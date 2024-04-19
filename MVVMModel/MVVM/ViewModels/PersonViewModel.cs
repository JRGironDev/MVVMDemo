using MVVMModel.MVVM.Models;

namespace MVVMModel.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewModel()
        {

            Person = new Person
            {
                Name = "José",
                Age = 35
            };
        }
    }
}