using System;
using Newtonsoft.Json;
using SQLite;

namespace PracticaWoW_MP.Models
{
    public class Character_MP
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("character_class")]
        public CharacterClass CharacterClass { get; set; }

        [JsonProperty("realm")]
        public Realm Realm { get; set; }
    }

    public class Race
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CharacterClass
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Realm
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}