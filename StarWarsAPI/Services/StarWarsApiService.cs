using System;
using StarWarsAPI.Models;
using StarWarsAPI.Services.Interfaces;

namespace StarWarsAPI.Services
{
	public class StarWarsApiService : IStarWarsApiService
    {
        private readonly HttpClient _httpClient;

        public StarWarsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StarWarsCharacter> GetCharacterAsync(string id)
        {
            var response = await _httpClient.GetFromJsonAsync<StarWarsCharacter>($"https://swapi.dev/api/people/{id}/");
            return response;
        }
    }
}