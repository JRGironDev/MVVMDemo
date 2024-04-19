using MVVMModel.MVVM.ViewModels;

namespace MVVMModel.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		
		BindingContext = new CommandsViewModel();
	}
}