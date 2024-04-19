using MVVMModel.MVVM.ViewModels;

namespace MVVMModel.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		
		BindingContext = new PeopleViewModel();
	}
}