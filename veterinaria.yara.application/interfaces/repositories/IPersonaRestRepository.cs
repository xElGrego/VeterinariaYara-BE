using veterinaria.yara.domain.entities;

namespace veterinaria.yara.application.interfaces.repositories
{
    public interface IPersonaRestRepository
    {
        Task<List<Persona>> ConsultarPersonas();
        Task<Persona> ConsultaPersonaId(int idPersona);
        Task<CrearResponse> CrearPersona(Persona persona);
        Task<CrearResponse> EditarPersona(Persona persona);
        Task<CrearResponse> EliminarPersona(int idPersona);
    }
}
