using MVVMModel.MVVM.Views;

namespace MVVMModel;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CommandsView();
	}
}
