using System.Windows.Input;

namespace MVVMModel.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ClickCommand { get; }

        public ICommand SearchCommand { get; }

        public CommandsViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");
            });

            SearchCommand = new Command((s) =>
            {
                var data = s;
            });
        }
        
        private void Alert()
        {
            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");
        }
    }
}