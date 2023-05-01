using System;
using StarWarsAPI.Models;

namespace StarWarsAPI.GraphQL.Types
{
	public class CharacterType : ObjectType<StarWarsCharacter>
    {
        protected override void Configure(IObjectTypeDescriptor<StarWarsCharacter> descriptor)
        {
            descriptor.Field(t => t.Name).Type<NonNullType<StringType>>();
            descriptor.Field(t => t.BirthYear).Type<StringType>();
            descriptor.Field(t => t.Gender).Type<StringType>();
        }
    }
}