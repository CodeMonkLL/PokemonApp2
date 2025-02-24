using Microsoft.EntityFrameworkCore;
using PokemonApp2.Models;

namespace PokemonApp2.Data
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options)
            : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Primärschlüssel
            modelBuilder.Entity<Pokemon>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Team>()
            .HasKey(t => t.Id);

            modelBuilder.Entity<User>()
            .HasKey(u => u.Id);


            // User und UserTeam (1:1)
            modelBuilder.Entity<User>()
                .HasOne<Team>()
                .WithOne()
                .HasForeignKey<User>(u => u.UserTeamID);

            //User und Pokemon
            modelBuilder.Entity<User>()
                .HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(u => u.FavPokemon)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(t => t.Slot1)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(t => t.Slot2)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(t => t.Slot3)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(t => t.Slot4)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(t => t.Slot5)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(t => t.Slot6)
                .OnDelete(DeleteBehavior.SetNull);


        }
    }
}
// DbContext ist eine zentrale Klasse in Entity Framework Core (EF Core), die als Brücke zwischen deiner C#-Anwendung und der Datenbank dient.
// Sie verwaltet die Verbindung zur Datenbank, das Laden und Speichern von Daten sowie die Abbildung deiner C#-Modelle auf Datenbanktabellen
//DbSet<T> ist eine Sammlung von Entitäten eines bestimmten Typs, z. B. Pokemons. Diese Sammlung stellt eine Tabelle in der Datenbank dar.
