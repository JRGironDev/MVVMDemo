using MVVMModel.MVVM.ViewModels;

namespace MVVMModel.MVVM.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
		
		BindingContext = new ConvertersViewModel();
	}
}