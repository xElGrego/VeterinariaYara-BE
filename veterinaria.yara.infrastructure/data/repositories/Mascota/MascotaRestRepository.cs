
using Microsoft.Extensions.Configuration;
using veterinaria.yara.application.interfaces.repositories;
using veterinaria.yara.domain.entities;

namespace veterinaria.yara.infrastructure.data.repositories
{
    public class MascotaRestRepository : IMascotaRestRepository
    {

        private readonly IConfiguration _configuration;
        //private readonly IMapper _mapper;
        private readonly DataContext _dataContext;

        public MascotaRestRepository(IConfiguration configuration,DataContext dataContext)
        {
            _configuration = configuration;
            _dataContext = dataContext;

        }

        public async Task<List<Mascota>> ConsultarMascotas()
        {
            List<Mascota> mascotas = new();


            try
            {
                var searchData = from mascota in _dataContext.Mascota select mascota;

                foreach (var item in searchData)
                {
                    Mascota mascota = new()
                    {
                        IdRaza = item.IdRaza,
                        Nombre = item.Nombre,
                        Mote = item.Mote,
                        Edad = item.Edad,
                        Peso = item.Peso,
                   
                    };
                    mascotas.Add(mascota);
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mascotas;
        }
        public async Task<Mascota> ConsultarMascotaId(int idMascota)
        {
            Mascota result = new();

            try
            {
                var searchData = from mascota in _dataContext.Mascota select mascota;


                result = (Mascota)searchData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

      

        public Task<CrearResponse> CrearMascota(Mascota mascota)
        {
            throw new NotImplementedException();
        }

        public Task<CrearResponse> EditarMascota(Mascota mascota)
        {
            throw new NotImplementedException();

            //using (var db = new DbNorthwind())
            //{
            //    db.Product
            //       .Where(p => p.ProductID == product.ProductID)
            //       .Set(p => p.Name, product.Name)
            //       .Set(p => p.UnitPrice, product.UnitPrice)
            //      .Update();
            //}
        }

        public Task<CrearResponse> EliminarMascota(int idMascota)
        {
            throw new NotImplementedException();
        }
    }
}
