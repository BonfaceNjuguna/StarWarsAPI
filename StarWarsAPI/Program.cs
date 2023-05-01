using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using StarWarsAPI.GraphQL;
using StarWarsAPI.GraphQL.Types;
using StarWarsAPI.Services;
using StarWarsAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpClient<IStarWarsApiService, StarWarsApiService>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<CharacterType>();

var app = builder.Build();

// HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapGraphQL("/graphql");
app.UsePlayground();

app.Run();