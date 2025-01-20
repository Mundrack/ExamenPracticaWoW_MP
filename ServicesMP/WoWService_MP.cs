using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PracticaWoW_MP.Models;

namespace PracticaWoW_MP.Services
{
    public class WowService_MP
    {
        private readonly HttpClient _client;
        private const string BaseUrl = "https://eu.api.blizzard.com"; // Asegúrate de que sea la región correcta
        private const string AccessToken = "US1yuNNztyTwK31rTKe2HgrD2J96vIONc1"; // Reemplaza con tu token válido

        public WowService_MP()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        }

        public async Task<Character_MP> GetCharacter(string realm, string characterName)
        {
            string url = $"{BaseUrl}/profile/wow/character/{realm}/{characterName}?namespace=profile-eu&locale=en_GB";
            var response = await _client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<Character_MP>(response);
        }
    }
}