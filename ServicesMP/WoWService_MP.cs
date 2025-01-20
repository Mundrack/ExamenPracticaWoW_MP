using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PracticaWoW_MP.Models;

namespace PracticaWoW_MP.ServicesMP
{
    public class WowService_MP
    {
        private readonly HttpClient _client;

        public WowService_MP()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "US1yuNNztyTwK31rTKe2HgrD2J96vIONc1");
        }

        public async Task<Character_MP> GetCharacter(string realm, string name)
        {
            string url = $"https://eu.api.blizzard.com/profile/wow/character/{realm}/{name}?namespace=profile-eu&locale=en_GB";
            var response = await _client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<Character_MP>(response);
        }
    }
}



