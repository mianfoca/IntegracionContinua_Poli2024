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
        [JsonProperty("evolution_details", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("evolution_details")]
        public List<object> evolution_details { get; set; }

        [JsonProperty("evolves_to", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("evolves_to")]
        public List<EvolvesTo> evolves_to { get; set; }

        [JsonProperty("is_baby", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("is_baby")]
        public bool? is_baby { get; set; }

        [JsonProperty("species", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("species")]
        public Species species { get; set; }
    }

    public class EvolutionDetail
    {
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("gender")]
        public object gender { get; set; }

        [JsonProperty("held_item", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("held_item")]
        public object held_item { get; set; }

        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("item")]
        public object item { get; set; }

        [JsonProperty("known_move", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("known_move")]
        public object known_move { get; set; }

        [JsonProperty("known_move_type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("known_move_type")]
        public object known_move_type { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("location")]
        public object location { get; set; }

        [JsonProperty("min_affection", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("min_affection")]
        public object min_affection { get; set; }

        [JsonProperty("min_beauty", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("min_beauty")]
        public object min_beauty { get; set; }

        [JsonProperty("min_happiness", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("min_happiness")]
        public object min_happiness { get; set; }

        [JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("min_level")]
        public int? min_level { get; set; }

        [JsonProperty("needs_overworld_rain", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("needs_overworld_rain")]
        public bool? needs_overworld_rain { get; set; }

        [JsonProperty("party_species", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("party_species")]
        public object party_species { get; set; }

        [JsonProperty("party_type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("party_type")]
        public object party_type { get; set; }

        [JsonProperty("relative_physical_stats", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("relative_physical_stats")]
        public object relative_physical_stats { get; set; }

        [JsonProperty("time_of_day", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("time_of_day")]
        public string time_of_day { get; set; }

        [JsonProperty("trade_species", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("trade_species")]
        public object trade_species { get; set; }

        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("trigger")]
        public Trigger trigger { get; set; }

        [JsonProperty("turn_upside_down", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("turn_upside_down")]
        public bool? turn_upside_down { get; set; }
    }

    public class EvolvesTo
    {
        [JsonProperty("evolution_details", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("evolution_details")]
        public List<EvolutionDetail> evolution_details { get; set; }

        [JsonProperty("evolves_to", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("evolves_to")]
        public List<EvolvesTo> evolves_to { get; set; }

        [JsonProperty("is_baby", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("is_baby")]
        public bool? is_baby { get; set; }

        [JsonProperty("species", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("species")]
        public Species species { get; set; }
    }

    public class PokemonEvolutionResponse
    {
        [JsonProperty("baby_trigger_item", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("baby_trigger_item")]
        public object baby_trigger_item { get; set; }

        [JsonProperty("chain", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("chain")]
        public Chain chain { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int? id { get; set; }
    }

    public class Trigger
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("url")]
        public string url { get; set; }
    }


}
