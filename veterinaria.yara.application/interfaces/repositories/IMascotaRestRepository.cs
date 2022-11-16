using veterinaria.yara.domain.entities;

namespace veterinaria.yara.application.interfaces.repositories
{
    public interface IMascotaRestRepository
    {
        Task<List<Mascota>> ConsultarMascotas();
        Task<Mascota> ConsultarMascotaId(int idMascota);
        Task<CrearResponse> CrearMascota(Mascota mascota);
        Task<CrearResponse> EditarMascota(Mascota mascota);
        Task<CrearResponse> EliminarMascota(int idMascota);
    }
}
