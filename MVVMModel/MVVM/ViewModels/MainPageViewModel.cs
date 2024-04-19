using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMModel.MVVM.ViewModels
{
    public class MainPageViewModel
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public int Result { get; set; }

        public ICommand AddCommand => new Command(() =>
        {
            Result = Number1 + Number2;
        });
    }
}