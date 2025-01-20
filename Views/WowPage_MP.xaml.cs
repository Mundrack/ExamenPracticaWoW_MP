using System;
using PracticaWoW_MP.ViewModels;
using Microsoft.Maui.Controls;

namespace PracticaWoW_MP.Views
{
    public partial class WowPage_MP : ContentPage
    {
        private readonly WowViewModel_MP _viewModel;

        public WowPage_MP()
        {
            InitializeComponent();
            _viewModel = new WowViewModel_MP();
            BindingContext = _viewModel;
        }

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            string realm = RealmEntry.Text?.Trim();
            string name = NameEntry.Text?.Trim();

            if (string.IsNullOrEmpty(realm) || string.IsNullOrEmpty(name))
            {
                await DisplayAlert("Advertencia", "Por favor, ingresa un reino y un personaje.", "OK");
                return;
            }

            try
            {
                await _viewModel.LoadCharacter(realm, name);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo cargar el personaje: {ex.Message}", "OK");
            }
        }
    }
}