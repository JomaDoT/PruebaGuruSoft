using ApiRest.Problema2.DTOS.Primos;
using ApiRest.Problema2.PatronDiseño;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiRest.Problema2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersistenceController : ControllerBase
    {
        public PersistenceController()
        {
        }

        /// <summary>
        /// Buscar Informacion sobre request del api
        /// </summary>
        /// <response code="404">NotFound. No existe data para mostrar.</response>              
        /// <response code="200">OK. Devuelve la informacion solicitada.</response>        

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetData()
        {
            var dto = Singleton.Instance;

            if (dto is null || !dto.Any()) {
            return NotFound("No existe data para mostrar.");
            }
            string serializer = JsonSerializer.Serialize(dto);
            return Ok(serializer);
        }
    }
}