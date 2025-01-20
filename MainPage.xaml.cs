using Microsoft.Maui.Controls;

namespace PracticaWoW_MP.Views;

public partial class MainPage_MP : ContentPage
{
    public MainPage_MP()
    {
        InitializeComponent();
    }

    private async void GoToWoWPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(WowPage_MP));
    }

    private async void GoToSavedCharacters(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SavedCharacter_MP));
    }
}