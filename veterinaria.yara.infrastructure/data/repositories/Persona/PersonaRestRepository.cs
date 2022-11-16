using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria.yara.application.interfaces.repositories;
using veterinaria.yara.domain.entities;


namespace veterinaria.yara.infrastructure.data.repositories
{
    public class PersonaRestRepository : IPersonaRestRepository
    {
        private readonly IConfiguration _configuration;
        //private readonly IMapper _mapper;
        private readonly DataContext _dataContext;

        public PersonaRestRepository(IConfiguration configuration,DataContext dataContext)
        {
            _configuration = configuration;
            _dataContext = dataContext;

        }
        public Task<Persona> ConsultaPersonaId(int idPersona)
        {
            throw new NotImplementedException();
        }

        public Task<List<domain.entities.Persona>> ConsultarPersonas()
        {
            throw new NotImplementedException();
        }

        public Task<CrearResponse> CrearPersona(domain.entities.Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task<CrearResponse> EditarPersona(domain.entities.Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task<CrearResponse> EliminarPersona(int idPersona)
        {
            throw new NotImplementedException();
        }
    }
}
