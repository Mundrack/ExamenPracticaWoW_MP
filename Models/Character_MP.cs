using System.ComponentModel.DataAnnotations;
using SQLite;

namespace PracticaWoW_MP.Models
{
    public class Character_MP
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Level { get; set; }
        public string Race { get; set; }
        public string CharacterClass { get; set; }
        public string Realm { get; set; }
    }
}