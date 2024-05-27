using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAPI.Controllers
{
    [Route("api/v2/")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet("type/")]
        public async Task<IActionResult> GetTypes()
        {
            try
            {
                using (var client = new Infrastructure.Client.Rest.PokeApiClient())
                {
                    var response = await client.GetTypesAsync();

                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return BadRequest("fail get all types");
            }
        }

        [HttpGet("pokemon/")]
        public async Task<IActionResult> GetAll([FromQuery] Domain.DTOs.PokemonRequest request)
        {
            try
            {
                using (var client = new Infrastructure.Client.Rest.PokeApiClient()) {
                    var response = await client.GetAllAsync(request);
                    
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return BadRequest("fail get all pokemon");
            }
        }


        [HttpGet("pokemon/{Name}")]
        public async Task<IActionResult> GetByName([FromRoute] Domain.DTOs.PokemonDetailRequest request)
        {
            try
            {
                using (var client = new Infrastructure.Client.Rest.PokeApiClient())
                {
                    var response = await client.GetByNameAsync(request);

                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return BadRequest("fail get pokemon by id");
            }
        }
    }
}
