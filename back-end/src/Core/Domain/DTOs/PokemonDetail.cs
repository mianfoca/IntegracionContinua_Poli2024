using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PokemonDetailRequest
    {
        public int Id { get; set; }
    }

    public class PokemonDetailResponse
    {
        [JsonProperty("abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("cries")]
        public Dictionary<string, string> Cries { get; set; }

        [JsonProperty("forms")]
        public List<NamedApiResource> Forms { get; set; }

        [JsonProperty("game_indices")]
        public List<VersionGameIndex> GameIndices { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("held_items")]
        public List<object> HeldItems { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        [JsonProperty("moves")]
        public List<Move> Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("past_abilities")]
        public List<object> PastAbilities { get; set; }

        [JsonProperty("past_types")]
        public List<object> PastTypes { get; set; }

        [JsonProperty("species")]
        public NamedApiResource Species { get; set; }

        [JsonProperty("sprites")]
        public Sprite Sprites { get; set; }

        [JsonProperty("stats")]
        public List<Stat> Stats { get; set; }

        [JsonProperty("types")]
        public List<Type> Types { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class Ability
    {
        [JsonProperty("ability")]
        public NamedApiResource AbilityResource { get; set; }
    }

    public class NamedApiResource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PokemonForm
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VersionGameIndex
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("version")]
        public NamedApiResource Version { get; set; }
    }

    public class Move
    {
        [JsonProperty("move")]
        public NamedApiResource MoveResource { get; set; }
    }

    public class PokemonSpecies
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Sprite
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }

        [JsonProperty("other")]
        public OtherSprites Other { get; set; }

        [JsonProperty("versions")]
        public Dictionary<string, Dictionary<string, VersionSprites>> Versions { get; set; }
    }

    public class OtherSprites
    {
        [JsonProperty("dream_world")]
        public DreamWorldSprites DreamWorld { get; set; }

        [JsonProperty("home")]
        public HomeSprites Home { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtworkSprites OfficialArtwork { get; set; }

        [JsonProperty("showdown")]
        public ShowdownSprites Showdown { get; set; }
    }

    public class DreamWorldSprites
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }
    }

    public class HomeSprites
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class OfficialArtworkSprites
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class ShowdownSprites
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class VersionSprites
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_gray")]
        public string BackGray { get; set; }

        [JsonProperty("back_transparent")]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_gray")]
        public string FrontGray { get; set; }

        [JsonProperty("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class Stat
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

        [JsonProperty("effort")]
        public int Effort { get; set; }

        [JsonProperty("stat")]
        public NamedApiResource StatResource { get; set; }
    }

    public class Type
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public NamedApiResource TypeResource { get; set; }
    }

    public class Pokemon
    {
        
    }
}
