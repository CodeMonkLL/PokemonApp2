namespace PokemonApp2.Models{

    public class User{
        public required string Name {get; set;}
        public required string ID {get; set;}
        public required string EMail {get; set;}
        public required string Password{get;set;}
        public string? FavPokemon {get; set;}
        public string? Team {get;set;}
    }

}