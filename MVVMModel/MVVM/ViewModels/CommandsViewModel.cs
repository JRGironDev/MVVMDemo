using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMModel.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ClickCommand { get; }

        public CommandsViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");
            });
        }
        
        private void Alert()
        {
            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");
        }
    }
}