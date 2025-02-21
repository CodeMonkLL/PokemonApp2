using Microsoft.EntityFrameworkCore;
using PokemonApp2.Models;

namespace PokemonApp2.Data
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext() { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }
        public DbSet<User> Users { get; set; }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=pokemon.db");
            }
        }

    }
}
// DbContext ist eine zentrale Klasse in Entity Framework Core (EF Core), die als Brücke zwischen deiner C#-Anwendung und der Datenbank dient. 
// Sie verwaltet die Verbindung zur Datenbank, das Laden und Speichern von Daten sowie die Abbildung deiner C#-Modelle auf Datenbanktabellen