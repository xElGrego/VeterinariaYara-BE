using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria.yara.application.interfaces.repositories;
using veterinaria.yara.application.interfaces.services;
using veterinaria.yara.domain.entities;

namespace veterinaria.yara.application.services
{
    public class InfoMascotaRepository : IMascotaRepository
    {
        private readonly IMascotaRestRepository _mascotaRestRepository;

        public InfoMascotaRepository(IMascotaRestRepository mascotaRestRepository)
        {
            _mascotaRestRepository = mascotaRestRepository;
        }
        public async Task<List<Mascota>> ConsultarMascotas()
        {
            return await _mascotaRestRepository.ConsultarMascotas();
        }

        public async Task<Mascota> ConsultarMascotaId(int idMascota)
        {
            return await _mascotaRestRepository.ConsultarMascotaId(idMascota);

        }

        public async Task<CrearResponse> CrearMascota(Mascota raza)
        {
            return await _mascotaRestRepository.CrearMascota(raza);
        }

        public async Task<CrearResponse> EditarMascota(Mascota raza)
        {
            return await _mascotaRestRepository.EditarMascota(raza);
        }

        public async Task<CrearResponse> EliminarMascota(int idRaza)
        {
            return await _mascotaRestRepository.EliminarMascota(idRaza);
        }
    }
}
