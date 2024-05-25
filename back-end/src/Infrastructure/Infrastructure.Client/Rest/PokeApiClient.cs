using Newtonsoft.Json;

namespace Infrastructure.Client.Rest
{
    public class PokeApiClient : IDisposable
    {
        string host = "https://pokeapi.co";
        private static readonly HttpClient client = new HttpClient();

        public async Task<Domain.DTOs.PokemonResponse> GetAllAsync(Domain.DTOs.PokemonRequest request)
        {
            
            string url = $"{this.host}/api/v2/pokemon/?limit={request.Limit}&offset={request.Offset}";
            HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Domain.DTOs.PokemonResponse pokemonResponse = JsonConvert.DeserializeObject<Domain.DTOs.PokemonResponse>(responseBody);

            pokemonResponse.CleanHost(this.host);

            return pokemonResponse;
        }

        public async Task<Domain.DTOs.PokemonDetailResponse> GetByIDAsync(Domain.DTOs.PokemonDetailRequest request)
        {

            string url = $"{this.host}/api/v2/pokemon/{request.Id}";
            HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Domain.DTOs.PokemonDetailResponse pokemonResponse = JsonConvert.DeserializeObject<Domain.DTOs.PokemonDetailResponse>(responseBody);

            return pokemonResponse;
        }

        public void Dispose()
        {
        }
    }
}
