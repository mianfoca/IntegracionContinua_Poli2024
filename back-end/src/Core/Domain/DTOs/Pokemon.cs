using Newtonsoft.Json;

namespace Domain.DTOs
{
    public class PokemonRequest
    {
        public int Limit { get; set; }

        public int Offset { get; set; }
    }

    public class PokemonResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string? Next { get; set; }

        [JsonProperty("previous")]
        public string? Previous { get; set; }

        [JsonProperty("results")]
        public List<PokemonResult> Results { get; set; }

        public void CleanHost(string host)
        {
            if (!string.IsNullOrEmpty(this.Next))
            {
                this.Next = this.Next.Replace(host, "");
            }
            if (!string.IsNullOrEmpty(this.Previous))
            {
                this.Previous = this.Previous.Replace(host, "");
            }

            if (this.Results != null)
            {
                foreach (var result in this.Results)
                {
                    result.Url = result.Url.Replace(host, "");
                }
            }
        }
    }

    public class PokemonResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
