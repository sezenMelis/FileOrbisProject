namespace FileOrbisProject.Views;
using FileOrbisProject.ViewModels;

public partial class ClientPage : ContentPage
{
	ClientPageViewModel clientPageViewModel;
	public ClientPage()
	{
		InitializeComponent();
		this.BindingContext = clientPageViewModel = new ClientPageViewModel();
	}
}