using Scalar.AspNetCore;
using PokemonApp2.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Füge den HttpClient-Dienst hinzu
builder.Services.AddHttpClient();

// Füge die Controller-Dienste hinzu
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

// Füge DbContext hinzu
builder.Services.AddDbContext<PokemonDbContext>(options =>
    options.UseSqlite("Data Source=pokemon.db"));

app.MapOpenApi();
app.MapScalarApiReference();

app.MapControllers();
app.UseHttpsRedirection();

app.Run();


