using System.ComponentModel.DataAnnotations;

namespace PokemonApp2.Models
{

    public class User
    {
        public required string Name { get; set; }

        [Key]
        public required int Id { get; set; }
        public required string EMail { get; set; }
        public required string Password { get; set; }
        public int? UserTeamID { get; set; }
        public int? FavPokemon { get; set; }
    }

}