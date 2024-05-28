using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.DTOs
{
         public class Chain
    {
        [JsonProperty("evolution_details")]
        [JsonPropertyName("evolution_details")]
        public List<object> evolution_details { get; set; }

        [JsonProperty("evolves_to")]
        [JsonPropertyName("evolves_to")]
        public List<EvolvesTo> evolves_to { get; set; }

        [JsonProperty("is_baby")]
        [JsonPropertyName("is_baby")]
        public bool is_baby { get; set; }

        [JsonProperty("species")]
        [JsonPropertyName("species")]
        public Species species { get; set; }
    }

    public class EvolutionDetail
    {
        [JsonProperty("gender")]
        [JsonPropertyName("gender")]
        public object gender { get; set; }

        [JsonProperty("held_item")]
        [JsonPropertyName("held_item")]
        public object held_item { get; set; }

        [JsonProperty("item")]
        [JsonPropertyName("item")]
        public object item { get; set; }

        [JsonProperty("known_move")]
        [JsonPropertyName("known_move")]
        public object known_move { get; set; }

        [JsonProperty("known_move_type")]
        [JsonPropertyName("known_move_type")]
        public object known_move_type { get; set; }

        [JsonProperty("location")]
        [JsonPropertyName("location")]
        public object location { get; set; }

        [JsonProperty("min_affection")]
        [JsonPropertyName("min_affection")]
        public object min_affection { get; set; }

        [JsonProperty("min_beauty")]
        [JsonPropertyName("min_beauty")]
        public object min_beauty { get; set; }

        [JsonProperty("min_happiness")]
        [JsonPropertyName("min_happiness")]
        public object min_happiness { get; set; }

        [JsonProperty("min_level")]
        [JsonPropertyName("min_level")]
        public int min_level { get; set; }

        [JsonProperty("needs_overworld_rain")]
        [JsonPropertyName("needs_overworld_rain")]
        public bool needs_overworld_rain { get; set; }

        [JsonProperty("party_species")]
        [JsonPropertyName("party_species")]
        public object party_species { get; set; }

        [JsonProperty("party_type")]
        [JsonPropertyName("party_type")]
        public object party_type { get; set; }

        [JsonProperty("relative_physical_stats")]
        [JsonPropertyName("relative_physical_stats")]
        public object relative_physical_stats { get; set; }

        [JsonProperty("time_of_day")]
        [JsonPropertyName("time_of_day")]
        public string time_of_day { get; set; }

        [JsonProperty("trade_species")]
        [JsonPropertyName("trade_species")]
        public object trade_species { get; set; }

        [JsonProperty("trigger")]
        [JsonPropertyName("trigger")]
        public Trigger trigger { get; set; }

        [JsonProperty("turn_upside_down")]
        [JsonPropertyName("turn_upside_down")]
        public bool turn_upside_down { get; set; }
    }

    public class EvolvesTo
    {
        [JsonProperty("evolution_details")]
        [JsonPropertyName("evolution_details")]
        public List<EvolutionDetail> evolution_details { get; set; }

        [JsonProperty("evolves_to")]
        [JsonPropertyName("evolves_to")]
        public List<EvolvesTo> evolves_to { get; set; }

        [JsonProperty("is_baby")]
        [JsonPropertyName("is_baby")]
        public bool is_baby { get; set; }

        [JsonProperty("species")]
        [JsonPropertyName("species")]
        public Species species { get; set; }
    }

    public class PokemonEvolutionResponse
    {
        [JsonProperty("baby_trigger_item")]
        [JsonPropertyName("baby_trigger_item")]
        public object baby_trigger_item { get; set; }

        [JsonProperty("chain")]
        [JsonPropertyName("chain")]
        public Chain chain { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int id { get; set; }
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

    public class Trigger
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }




}
