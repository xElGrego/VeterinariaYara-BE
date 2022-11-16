using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using veterinaria.yara.application.interfaces.services;
using veterinaria.yara.application.models.dtos;
using veterinaria.yara.domain.entities;

namespace veterinaria.yara.api.Controllers.v0
{
    [Tags("Persona")]
    [ApiController]
    public class PersonaController : BaseApiController
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaController(IPersonaRepository personaRepository)
        {
            this._personaRepository = personaRepository;
        }


        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<Persona>), 200)]
        [ProducesResponseType(typeof(MsDtoResponseError), 400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/consulta-personas")]
        public async Task<ActionResult<List<MsDtoResponse<List<Persona>>>>> ConsultarPersonas() /*[FromHeader][Required]*/
        {
            var response = await _personaRepository.ConsultarPersonas();
            return Ok(new MsDtoResponse<List<Persona>>(response));
        }

        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<Persona>), 200)]
        [ProducesResponseType(typeof(MsDtoResponseError), 400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/consulta-persona-id")]
        public async Task<ActionResult<List<MsDtoResponse<List<Persona>>>>> ConsultarPersonaId([FromHeader][Required] int idPersona) 
        {
            var response = await _personaRepository.ConsultarPersonaId(idPersona);
            return Ok(new MsDtoResponse<Persona>(response));
        }

    }
}
