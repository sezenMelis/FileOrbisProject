using FileOrbisProject.Views;
using CommunityToolkit.Mvvm.Input;


namespace FileOrbisProject.ViewModels;

public partial class ClientPageViewModel :BaseClientViewModel
{
    [ICommand]
    private async void OnAddClient()
    {
        await Shell.Current.GoToAsync(nameof(AddClientPage));
    }

}
