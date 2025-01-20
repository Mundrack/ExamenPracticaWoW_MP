using PracticaWoW_MP.Models;
using PracticaWoW_MP.Services;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace PracticaWoW_MP.Views
{
    public partial class SavedCharacter_MP : ContentPage
    {
        public SavedCharacter_MP()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var character = BindingContext as Character_MP;
            if (character != null)
            {
                try
                {
                    await App.DataBaseService_MP?.SaveCharacter(character);
                    await DisplayAlert("Éxito", "Personaje guardado correctamente", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", $"No se pudo guardar el personaje: {ex.Message}", "OK");
                }
            }
            else
            {
                await DisplayAlert("Advertencia", "No hay personaje seleccionado para guardar", "OK");
            }
        }
    }
}