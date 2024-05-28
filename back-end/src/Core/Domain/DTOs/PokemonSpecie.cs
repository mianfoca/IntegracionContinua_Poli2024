using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.DTOs
{
        public class Area
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Color
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class EggGroup
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class EvolutionChain
    {
        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class FlavorTextEntry
    {
        [JsonProperty("flavor_text")]
        [JsonPropertyName("flavor_text")]
        public string flavor_text { get; set; }

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public Language language { get; set; }

        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public VersionSpecie version { get; set; }
    }

    public class Genera
    {
        [JsonProperty("genus")]
        [JsonPropertyName("genus")]
        public string genus { get; set; }

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public Language language { get; set; }
    }

    public class Generation
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class GrowthRate
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Habitat
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Language
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Name
    {
        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public Language language { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }
    }

    public class PalParkEncounter
    {
        [JsonProperty("area")]
        [JsonPropertyName("area")]
        public Area area { get; set; }

        [JsonProperty("base_score")]
        [JsonPropertyName("base_score")]
        public int base_score { get; set; }

        [JsonProperty("rate")]
        [JsonPropertyName("rate")]
        public int rate { get; set; }
    }

    public class Pokedex
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class PokedexNumber
    {
        [JsonProperty("entry_number")]
        [JsonPropertyName("entry_number")]
        public int entry_number { get; set; }

        [JsonProperty("pokedex")]
        [JsonPropertyName("pokedex")]
        public Pokedex pokedex { get; set; }
    }

    public class Pokemon
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class PokemonSpecieResponse
    {
        [JsonProperty("base_happiness")]
        [JsonPropertyName("base_happiness")]
        public int base_happiness { get; set; }

        [JsonProperty("capture_rate")]
        [JsonPropertyName("capture_rate")]
        public int capture_rate { get; set; }

        [JsonProperty("color")]
        [JsonPropertyName("color")]
        public Color color { get; set; }

        [JsonProperty("egg_groups")]
        [JsonPropertyName("egg_groups")]
        public List<EggGroup> egg_groups { get; set; }

        [JsonProperty("evolution_chain")]
        [JsonPropertyName("evolution_chain")]
        public EvolutionChain evolution_chain { get; set; }

        [JsonProperty("evolves_from_species")]
        [JsonPropertyName("evolves_from_species")]
        public object evolves_from_species { get; set; }

        [JsonProperty("flavor_text_entries")]
        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorTextEntry> flavor_text_entries { get; set; }

        [JsonProperty("form_descriptions")]
        [JsonPropertyName("form_descriptions")]
        public List<object> form_descriptions { get; set; }

        [JsonProperty("forms_switchable")]
        [JsonPropertyName("forms_switchable")]
        public bool forms_switchable { get; set; }

        [JsonProperty("gender_rate")]
        [JsonPropertyName("gender_rate")]
        public int gender_rate { get; set; }

        [JsonProperty("genera")]
        [JsonPropertyName("genera")]
        public List<Genera> genera { get; set; }

        [JsonProperty("generation")]
        [JsonPropertyName("generation")]
        public Generation generation { get; set; }

        [JsonProperty("growth_rate")]
        [JsonPropertyName("growth_rate")]
        public GrowthRate growth_rate { get; set; }

        [JsonProperty("habitat")]
        [JsonPropertyName("habitat")]
        public Habitat habitat { get; set; }

        [JsonProperty("has_gender_differences")]
        [JsonPropertyName("has_gender_differences")]
        public bool has_gender_differences { get; set; }

        [JsonProperty("hatch_counter")]
        [JsonPropertyName("hatch_counter")]
        public int hatch_counter { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonProperty("is_baby")]
        [JsonPropertyName("is_baby")]
        public bool is_baby { get; set; }

        [JsonProperty("is_legendary")]
        [JsonPropertyName("is_legendary")]
        public bool is_legendary { get; set; }

        [JsonProperty("is_mythical")]
        [JsonPropertyName("is_mythical")]
        public bool is_mythical { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("names")]
        [JsonPropertyName("names")]
        public List<Name> names { get; set; }

        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int order { get; set; }

        [JsonProperty("pal_park_encounters")]
        [JsonPropertyName("pal_park_encounters")]
        public List<PalParkEncounter> pal_park_encounters { get; set; }

        [JsonProperty("pokedex_numbers")]
        [JsonPropertyName("pokedex_numbers")]
        public List<PokedexNumber> pokedex_numbers { get; set; }

        [JsonProperty("shape")]
        [JsonPropertyName("shape")]
        public Shape shape { get; set; }

        [JsonProperty("varieties")]
        [JsonPropertyName("varieties")]
        public List<Variety> varieties { get; set; }
    }

    public class Shape
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Variety
    {
        [JsonProperty("is_default")]
        [JsonPropertyName("is_default")]
        public bool is_default { get; set; }

        [JsonProperty("pokemon")]
        [JsonPropertyName("pokemon")]
        public Pokemon pokemon { get; set; }
    }

    public class VersionSpecie
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }


}
