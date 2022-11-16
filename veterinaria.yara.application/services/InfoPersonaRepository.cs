using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria.yara.application.interfaces.services;
using veterinaria.yara.application.interfaces.repositories;
using veterinaria.yara.domain.entities;

namespace veterinaria.yara.application.services
{
    public class InfoPersonaRepository : IPersonaRepository
    {
        private readonly IPersonaRestRepository _personaRepository;

        public InfoPersonaRepository(IPersonaRestRepository personaRepository)
        {
            this._personaRepository = personaRepository;
        }

        public async Task<List<Persona>> ConsultarPersonas()
        {
            return await _personaRepository.ConsultarPersonas();
        }


        public async Task<Persona> ConsultarPersonaId(int idPersona)
        {
            return await _personaRepository.ConsultaPersonaId(idPersona);
        }


        public async Task<CrearResponse> CrearPersona(Persona persona)
        {
            return await _personaRepository.CrearPersona(persona);

        }

        public async Task<CrearResponse> EditarPersona(Persona persona)
        {
            return await _personaRepository.EditarPersona(persona);
        }

        public async  Task<CrearResponse> EliminarPersona(int idPersona)
        {
            return await _personaRepository.EliminarPersona(idPersona);

        }
    }
}
