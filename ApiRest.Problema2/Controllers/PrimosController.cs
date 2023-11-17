using ApiRest.Problema2.DTOS.Persistence;
using ApiRest.Problema2.DTOS.Primos;
using ApiRest.Problema2.PatronDiseño;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace ApiRest.Problema2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrimosController : ControllerBase
    {
        public PrimosController()
        {
        }

        /// <summary>
        /// Buscar numeros Primos a partir de un valor hasta otro valor suministrado
        /// </summary>
        /// <param name="paramsDTO">objecto de busquedad de numeros primeros </param>
        /// <response code="400">BadRequest, Ocurrio un error con los valore suministrados.</response>
        /// <response code="404">NotFound. No existe data para mostrar.</response>              
        /// <response code="200">OK. Devuelve los impares solicitado.</response>        

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult FindPrimos(GetPrimosParamsDTO paramsDTO)
        {
            if (paramsDTO.MaxValue <= 0)
                return BadRequest("El valor maximo de la cantidad resultados debe ser mayor a 0.");

            List<int?> values = new();

            // se busca los numeros primos hasta el maximo introducido
            for (int i = paramsDTO.InitialValue; values.Count < paramsDTO.MaxValue; i++)
            {
                if ((i % 2) != 0)
                    values.Add(i);
            }

            if (!values.Any())
                return NotFound("No existe data para mostrar.");

            var dto = new GetPrimosDTO(values);
            string serializer = JsonSerializer.Serialize(dto);

            if (Singleton.Instance.Any())
            {
                var persistence = HelpPersistence.FillPersistence(request: paramsDTO.ToString(), string.Join(",", values), paramsDTO.UserName,isFirst:false);
                Singleton.Instance.Add(persistence);
            }
            else
            {
                var persistence = HelpPersistence.FillPersistence(request: paramsDTO.ToString(), string.Join(",", values), paramsDTO.UserName, true);
                Singleton.Instance.Add(persistence);
            }

            return Ok(serializer);
        }
    }
}