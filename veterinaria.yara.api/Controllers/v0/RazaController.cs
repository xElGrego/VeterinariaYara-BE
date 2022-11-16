using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using veterinaria.yara.application.interfaces.services;
using veterinaria.yara.application.models.dtos;
using veterinaria.yara.domain.entities;

namespace veterinaria.yara.api.Controllers.v0
{
    [Tags("Raza")]
    [ApiController]
    public class RazaController : BaseApiController
    {
        private readonly IRazaRepository _razaRepository;

        public RazaController(IRazaRepository razaRestRepository)
        {
            this._razaRepository = razaRestRepository;
        }


        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<Raza>), 200)]
        [ProducesResponseType(typeof(MsDtoResponseError), 400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/consulta-razas")]
        public async Task<ActionResult<List<MsDtoResponse<List<Raza>>>>> ConsultaRazas() /*[FromHeader][Required]*/
        {
            var response = await _razaRepository.ConsultarRazas();
            return Ok(new MsDtoResponse<List<Raza>>(response));
        }



        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<Raza>),200)]
        [ProducesResponseType(typeof(MsDtoResponseError),400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/consulta-razas-id")]
        public async Task<ActionResult<List<MsDtoResponse<List<Raza>>>>> ConsultaRazasId([FromHeader][Required]  int idRaza) 
        {
            var response = await _razaRepository.ConsultarRazaId(idRaza);
            return Ok(new MsDtoResponse<Raza>(response));
        }

        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<CrearResponse>), 200)]
        [ProducesResponseType(typeof(MsDtoResponseError), 400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/crear-raza")]
        public async Task<ActionResult<MsDtoResponse<CrearResponse>>> CrearRaza([FromBody][Required] Raza raza)
        
        {
            var response = await _razaRepository.CrearRaza(raza);
            return Ok(new MsDtoResponse<CrearResponse>(response));
        }


        [HttpPut]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<CrearResponse>), 200)]
        [ProducesResponseType(typeof(MsDtoResponseError), 400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/editar-raza")]
        public async Task<ActionResult<MsDtoResponse<CrearResponse>>> EditarRaza([FromBody][Required] Raza raza)

        {
            var response = await _razaRepository.EditarRaza(raza);
            return Ok(new MsDtoResponse<CrearResponse>(response));
        }

        [HttpDelete]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<CrearResponse>), 200)]
        [ProducesResponseType(typeof(MsDtoResponseError), 400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/eliminar-raza")]
        public async Task<ActionResult<MsDtoResponse<CrearResponse>>> EliminarRaza([FromHeader][Required] int idRaza)

        {
            var response = await _razaRepository.EliminarRaza(idRaza);
            return Ok(new MsDtoResponse<CrearResponse>(response));
        }

    }
}