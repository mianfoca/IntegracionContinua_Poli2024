using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PokemonDetailRequest
    {
        public string Name { get; set; }
    }

    public class Ability
    {
        [JsonProperty("ability")]
        [JsonPropertyName("ability")]
        public Ability2 ability { get; set; }

        [JsonProperty("is_hidden")]
        [JsonPropertyName("is_hidden")]
        public bool is_hidden { get; set; }

        [JsonProperty("slot")]
        [JsonPropertyName("slot")]
        public int slot { get; set; }
    }

    public class Ability2
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Animated
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class BlackWhite
    {
        [JsonProperty("animated")]
        [JsonPropertyName("animated")]
        public Animated animated { get; set; }

        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Cries
    {
        [JsonProperty("latest")]
        [JsonPropertyName("latest")]
        public string latest { get; set; }

        [JsonProperty("legacy")]
        [JsonPropertyName("legacy")]
        public string legacy { get; set; }
    }

    public class Crystal
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_transparent")]
        [JsonPropertyName("back_shiny_transparent")]
        public string back_shiny_transparent { get; set; }

        [JsonProperty("back_transparent")]
        [JsonPropertyName("back_transparent")]
        public string back_transparent { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_transparent")]
        [JsonPropertyName("front_shiny_transparent")]
        public string front_shiny_transparent { get; set; }

        [JsonProperty("front_transparent")]
        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class DiamondPearl
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class DreamWorld
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }
    }

    public class Emerald
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class FireredLeafgreen
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class Form
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class GameIndex
    {
        [JsonProperty("game_index")]
        [JsonPropertyName("game_index")]
        public int game_index { get; set; }

        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public Version version { get; set; }
    }

    public class GenerationI
    {
        [JsonProperty("red-blue")]
        [JsonPropertyName("red-blue")]
        public RedBlue redblue { get; set; }

        [JsonProperty("yellow")]
        [JsonPropertyName("yellow")]
        public Yellow yellow { get; set; }
    }

    public class GenerationIi
    {
        [JsonProperty("crystal")]
        [JsonPropertyName("crystal")]
        public Crystal crystal { get; set; }

        [JsonProperty("gold")]
        [JsonPropertyName("gold")]
        public Gold gold { get; set; }

        [JsonProperty("silver")]
        [JsonPropertyName("silver")]
        public Silver silver { get; set; }
    }

    public class GenerationIii
    {
        [JsonProperty("emerald")]
        [JsonPropertyName("emerald")]
        public Emerald emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        [JsonPropertyName("firered-leafgreen")]
        public FireredLeafgreen fireredleafgreen { get; set; }

        [JsonProperty("ruby-sapphire")]
        [JsonPropertyName("ruby-sapphire")]
        public RubySapphire rubysapphire { get; set; }
    }

    public class GenerationIv
    {
        [JsonProperty("diamond-pearl")]
        [JsonPropertyName("diamond-pearl")]
        public DiamondPearl diamondpearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        [JsonPropertyName("heartgold-soulsilver")]
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }

        [JsonProperty("platinum")]
        [JsonPropertyName("platinum")]
        public Platinum platinum { get; set; }
    }

    public class GenerationV
    {
        [JsonProperty("black-white")]
        [JsonPropertyName("black-white")]
        public BlackWhite blackwhite { get; set; }
    }

    public class GenerationVi
    {
        [JsonProperty("omegaruby-alphasapphire")]
        [JsonPropertyName("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }

        [JsonProperty("x-y")]
        [JsonPropertyName("x-y")]
        public XY xy { get; set; }
    }

    public class GenerationVii
    {
        [JsonProperty("icons")]
        [JsonPropertyName("icons")]
        public Icons icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        [JsonPropertyName("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon ultrasunultramoon { get; set; }
    }

    public class GenerationViii
    {
        [JsonProperty("icons")]
        [JsonPropertyName("icons")]
        public Icons icons { get; set; }
    }

    public class Gold
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_transparent")]
        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Home
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Icons
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }
    }

    public class Move
    {
        [JsonProperty("move")]
        [JsonPropertyName("move")]
        public Move move { get; set; }

        [JsonProperty("version_group_details")]
        [JsonPropertyName("version_group_details")]
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Move2
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Other
    {
        [JsonProperty("dream_world")]
        [JsonPropertyName("dream_world")]
        public DreamWorld dream_world { get; set; }

        [JsonProperty("home")]
        [JsonPropertyName("home")]
        public Home home { get; set; }

        [JsonProperty("official-artwork")]
        [JsonPropertyName("official-artwork")]
        public OfficialArtwork officialartwork { get; set; }

        [JsonProperty("showdown")]
        [JsonPropertyName("showdown")]
        public Showdown showdown { get; set; }
    }

    public class Platinum
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class RedBlue
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_gray")]
        [JsonPropertyName("back_gray")]
        public string back_gray { get; set; }

        [JsonProperty("back_transparent")]
        [JsonPropertyName("back_transparent")]
        public string back_transparent { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_gray")]
        [JsonPropertyName("front_gray")]
        public string front_gray { get; set; }

        [JsonProperty("front_transparent")]
        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class PokemonDetailResponse
    {
        [JsonProperty("abilities")]
        [JsonPropertyName("abilities")]
        public List<Ability> abilities { get; set; }

        [JsonProperty("base_experience")]
        [JsonPropertyName("base_experience")]
        public int base_experience { get; set; }

        [JsonProperty("cries")]
        [JsonPropertyName("cries")]
        public Cries cries { get; set; }

        [JsonProperty("forms")]
        [JsonPropertyName("forms")]
        public List<Form> forms { get; set; }

        [JsonProperty("game_indices")]
        [JsonPropertyName("game_indices")]
        public List<GameIndex> game_indices { get; set; }

        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public int height { get; set; }

        [JsonProperty("held_items")]
        [JsonPropertyName("held_items")]
        public List<object> held_items { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonProperty("is_default")]
        [JsonPropertyName("is_default")]
        public bool is_default { get; set; }

        [JsonProperty("location_area_encounters")]
        [JsonPropertyName("location_area_encounters")]
        public string location_area_encounters { get; set; }

        [JsonProperty("moves")]
        [JsonPropertyName("moves")]
        public List<Move> moves { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int order { get; set; }

        [JsonProperty("past_abilities")]
        [JsonPropertyName("past_abilities")]
        public List<object> past_abilities { get; set; }

        [JsonProperty("past_types")]
        [JsonPropertyName("past_types")]
        public List<object> past_types { get; set; }

        [JsonProperty("species")]
        [JsonPropertyName("species")]
        public Species species { get; set; }

        [JsonProperty("sprites")]
        [JsonPropertyName("sprites")]
        public Sprites sprites { get; set; }

        [JsonProperty("stats")]
        [JsonPropertyName("stats")]
        public List<Stat> stats { get; set; }

        [JsonProperty("types")]
        [JsonPropertyName("types")]
        public List<Type> types { get; set; }

        [JsonProperty("weight")]
        [JsonPropertyName("weight")]
        public int weight { get; set; }
    }

    public class RubySapphire
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class Showdown
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Silver
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_transparent")]
        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class Species
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Sprites
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }

        [JsonProperty("other")]
        [JsonPropertyName("other")]
        public Other other { get; set; }

        [JsonProperty("versions")]
        [JsonPropertyName("versions")]
        public Versions versions { get; set; }
    }

    public class Stat
    {
        [JsonProperty("base_stat")]
        [JsonPropertyName("base_stat")]
        public int base_stat { get; set; }

        [JsonProperty("effort")]
        [JsonPropertyName("effort")]
        public int effort { get; set; }

        [JsonProperty("stat")]
        [JsonPropertyName("stat")]
        public Stat stat { get; set; }
    }

    public class Stat2
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Type
    {
        [JsonProperty("slot")]
        [JsonPropertyName("slot")]
        public int slot { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public Type type { get; set; }
    }

    public class Type2
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class UltraSunUltraMoon
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Version
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class VersionGroup
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        [JsonPropertyName("level_learned_at")]
        public int level_learned_at { get; set; }

        [JsonProperty("move_learn_method")]
        [JsonPropertyName("move_learn_method")]
        public MoveLearnMethod move_learn_method { get; set; }

        [JsonProperty("version_group")]
        [JsonPropertyName("version_group")]
        public VersionGroup version_group { get; set; }
    }

    public class Versions
    {
        [JsonProperty("generation-i")]
        [JsonPropertyName("generation-i")]
        public GenerationI generationi { get; set; }

        [JsonProperty("generation-ii")]
        [JsonPropertyName("generation-ii")]
        public GenerationIi generationii { get; set; }

        [JsonProperty("generation-iii")]
        [JsonPropertyName("generation-iii")]
        public GenerationIii generationiii { get; set; }

        [JsonProperty("generation-iv")]
        [JsonPropertyName("generation-iv")]
        public GenerationIv generationiv { get; set; }

        [JsonProperty("generation-v")]
        [JsonPropertyName("generation-v")]
        public GenerationV generationv { get; set; }

        [JsonProperty("generation-vi")]
        [JsonPropertyName("generation-vi")]
        public GenerationVi generationvi { get; set; }

        [JsonProperty("generation-vii")]
        [JsonPropertyName("generation-vii")]
        public GenerationVii generationvii { get; set; }

        [JsonProperty("generation-viii")]
        [JsonPropertyName("generation-viii")]
        public GenerationViii generationviii { get; set; }
    }

    public class XY
    {
        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Yellow
    {
        [JsonProperty("back_default")]
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_gray")]
        [JsonPropertyName("back_gray")]
        public string back_gray { get; set; }

        [JsonProperty("back_transparent")]
        [JsonPropertyName("back_transparent")]
        public string back_transparent { get; set; }

        [JsonProperty("front_default")]
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_gray")]
        [JsonPropertyName("front_gray")]
        public string front_gray { get; set; }

        [JsonProperty("front_transparent")]
        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

}
