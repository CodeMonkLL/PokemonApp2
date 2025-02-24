using Scalar.AspNetCore;
using PokemonApp2.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Füge den HttpClient-Dienst hinzu
builder.Services.AddHttpClient();

// Füge die Controller-Dienste hinzu
builder.Services.AddControllers();

builder.Services.AddDbContext<PokemonDbContext>(options =>
    options.UseSqlite("Data Source=pokemon.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.



app.MapOpenApi();
app.MapScalarApiReference();

app.MapControllers();
app.UseHttpsRedirection();

app.Run();


