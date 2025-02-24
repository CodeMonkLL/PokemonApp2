using System.ComponentModel.DataAnnotations;
namespace PokemonApp2.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public int? Slot1 { get; set; }
        public int? Slot2 { get; set; }
        public int? Slot3 { get; set; }
        public int? Slot4 { get; set; }
        public int? Slot5 { get; set; }
        public int? Slot6 { get; set; }

    }
}