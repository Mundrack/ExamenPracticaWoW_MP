using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PracticaWoW_MP.Models;
using PracticaWoW_MP.ServicesMP;

namespace PracticaWoW_MP.ViewModels
{
    public class WowViewModel_MP : INotifyPropertyChanged
    {
        private readonly WowService_MP _wowService;
        private Character_MP _character;

        public Character_MP Character
        {
            get => _character;
            set
            {
                _character = value;
                OnPropertyChanged();
            }
        }

        public WowViewModel_MP()
        {
            _wowService = new WowService_MP();
        }

        public async Task LoadCharacter(string realm, string name)
        {
            try
            {
                Character = await _wowService.GetCharacter(realm, name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar personaje: {ex.Message}");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}