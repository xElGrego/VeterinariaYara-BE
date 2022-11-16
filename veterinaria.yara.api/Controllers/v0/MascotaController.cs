using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using veterinaria.yara.application.interfaces.services;
using veterinaria.yara.application.models.dtos;
using veterinaria.yara.domain.entities;

namespace veterinaria.yara.api.Controllers.v0
{
    [Tags("Mascota")]
    [ApiController]
    public class MascotaController : BaseApiController
    {
        private readonly IMascotaRepository _razaRepository;
        public MascotaController(IMascotaRepository razaRestRepository)
        {
            this._razaRepository = razaRestRepository;
        }


        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MsDtoResponse<Mascota>), 200)]
        [ProducesResponseType(typeof(MsDtoResponseError), 400)]
        [ProducesResponseType(typeof(MsDtoResponseError), 500)]
        [Route("/veterinaria-yara/consulta-mascotas")]
        public async Task<ActionResult<List<MsDtoResponse<List<Mascota>>>>> ConsultarMascotas() /*[FromHeader][Required]*/
        {
            var response = await _razaRepository.ConsultarMascotas();
            return Ok(new MsDtoResponse<List<Mascota>>(response));
        }


    }


}
