using System;
using StarWarsAPI.Models;
using StarWarsAPI.Services.Interfaces;

namespace StarWarsAPI.GraphQL
{
	public class Query
	{
        public Task<StarWarsCharacter> GetCharacterAsync(string id, [Service] IStarWarsApiService starWarsApiService)
        {
            return starWarsApiService.GetCharacterAsync(id);
        }
    }
}