using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace dffoo.Client.Services.ChampionsService
{
    public class ChampService : IChampService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navman;

        public ChampService(HttpClient http, NavigationManager navman)
        {
            _http = http;
            _navman = navman;
        }

        public List<Champion> Champs { get; set; } = new List<Champion>();
        public List<Game> Games { get; set; } = new List<Game>();

        public async Task CreateChampion(Champion champ)
        {
            var result = await _http.PostAsJsonAsync("/api/champion", champ);
            await SetChamps(result);
        }

        private async Task SetChamps(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Champion>>();
            Champs = response;
            _navman.NavigateTo("/");
        }

        public async Task DeleteChampion(int id)
        {
            var result = await _http.DeleteAsync($"api/champion/{id}");
            await SetChamps(result);
        }

        public async Task GetChampions()
        {
            var result = await _http.GetFromJsonAsync<List<Champion>>("api/champion");
            if (result != null)
                Champs = result;
        }

        public async Task GetGames()
        {
            var result = await _http.GetFromJsonAsync<List<Game>>("api/champion/games");
            if (result != null)
                Games = result;
        }

        public async Task<Champion> GetSingleChamp(int id)
        {
            var result = await _http.GetFromJsonAsync<Champion>($"api/champion/{id}");
            if (result != null)
                return result;
            throw new Exception("Champion Not Found");
        }

        public async Task UpdateChampion(Champion champ)
        {
            Console.WriteLine(champ);
            var result = await _http.PutAsJsonAsync($"api/champion/{champ.Id}", champ);
            await SetChamps(result);
        }
    }
}
