using veterinaria.yara.application.interfaces.repositories;
using veterinaria.yara.domain.entities;
using veterinaria.yara.application.interfaces.services;

namespace veterinaria.yara.application.services
{
    public class InfoRazaRepository : IRazaRepository
    {
        private readonly IRazaRestRepository _razaRestRepository;

        public InfoRazaRepository(IRazaRestRepository razaRestRepository)
        {
            this._razaRestRepository = razaRestRepository;
        }

        public async Task<Raza> ConsultarRazaId(int idRaza)
        {
            return await _razaRestRepository.ConsultarRazaId(idRaza);
        }

        public async Task<List<Raza>> ConsultarRazas()
        {
            return await _razaRestRepository.ConsultarRazas();
        }

        public async Task<CrearResponse> CrearRaza(Raza raza)
        {
            return await _razaRestRepository.CrearRaza(raza);
        }

        public async Task<CrearResponse> EditarRaza(Raza raza)
        {
            return await _razaRestRepository.EditarRaza(raza);
        }

        public async Task<CrearResponse> EliminarRaza(int idRaza)
        {
            return await _razaRestRepository.EliminarRaza(idRaza);
        }
    }
}
