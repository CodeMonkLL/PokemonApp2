namespace PokemonApp2.Models
{
public class Pokemon
    {
        public int Id { get; set; }  // Primärschlüssel
        public required string Name { get; set; }
        public required string Type { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        
        // Neues Feld für das front_default Bild von der Pokémon-API
        public string? FrontDefault { get; set; }
    }
}