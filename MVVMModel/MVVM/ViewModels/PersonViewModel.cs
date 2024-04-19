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
                Age = 35,
                Married = true,
                BirthDate = new DateTime(1988, 05, 24),
                Weight = 80,
                Lunchtime = new TimeSpan(10, 0, 0)
            };
        }
    }
}