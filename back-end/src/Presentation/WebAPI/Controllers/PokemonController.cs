using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAPI.Controllers
{
    [Route("api/v2/pokemon/")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet("")]
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


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByID([FromRoute] Domain.DTOs.PokemonDetailRequest request)
        {
            try
            {
                using (var client = new Infrastructure.Client.Rest.PokeApiClient())
                {
                    var response = await client.GetByIDAsync(request);

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
