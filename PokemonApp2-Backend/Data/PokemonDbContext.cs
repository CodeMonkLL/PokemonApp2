using Microsoft.EntityFrameworkCore;
using PokemonApi.Models;

namespace PokemonApi.Data
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}