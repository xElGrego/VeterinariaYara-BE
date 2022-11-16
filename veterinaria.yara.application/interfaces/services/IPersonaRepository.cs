using veterinaria.yara.domain.entities;

namespace veterinaria.yara.application.interfaces.services
{
    public interface IPersonaRepository
    {
        Task<List<Persona>> ConsultarPersonas();
        Task<Persona> ConsultarPersonaId(int idPersona);
        Task<CrearResponse> CrearPersona(Persona persona);
        Task<CrearResponse> EditarPersona(Persona persona);
        Task<CrearResponse> EliminarPersona(int idPersona);
    }
}
