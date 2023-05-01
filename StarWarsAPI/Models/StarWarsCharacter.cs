using System;
using System.Text.Json.Serialization;

namespace StarWarsAPI.Models
{
	public class StarWarsCharacter
	{
		public string? Name { get; set; }
		public string? BirthYear { get; set; }
		public string? Gender { get; set; }

        [JsonPropertyName("mass")]
        public string? Mass { get; set; }

        [JsonPropertyName("height")]
        public string? Height { get; set; }
    }
}