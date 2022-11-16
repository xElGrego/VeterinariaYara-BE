using veterinaria.yara.domain.entities;

namespace veterinaria.yara.application.interfaces.services
{
    public interface IRazaRepository
    {
        Task<List<Raza>> ConsultarRazas();
        Task<Raza> ConsultarRazaId(int idRaza);
        Task<CrearResponse> CrearRaza(Raza raza);
        Task<CrearResponse> EditarRaza(Raza raza);
        Task<CrearResponse> EliminarRaza(int idRaza);
    }
}
