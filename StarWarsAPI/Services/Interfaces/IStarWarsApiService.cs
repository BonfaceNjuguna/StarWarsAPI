using System;
using StarWarsAPI.Models;

namespace StarWarsAPI.Services.Interfaces
{
	public interface IStarWarsApiService
	{
        Task<StarWarsCharacter> GetCharacterAsync(string id);
    }
}