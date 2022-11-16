using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using veterinaria.yara.application.interfaces.repositories;
using veterinaria.yara.domain.entities;


namespace veterinaria.yara.infrastructure.data.repositories
{

    public class RazaRestRepository : IRazaRestRepository

    {
        private readonly IConfiguration _configuration;
        //private readonly IMapper _mapper;
        private readonly DataContext _dataContext;

        public RazaRestRepository(IConfiguration configuration,/*IMapper mapper, */DataContext dataContext)
        {
            _configuration = configuration;
            //_mapper = mapper;
            _dataContext = dataContext;

        }

        public async Task<List<Raza>> ConsultarRazas()
        {
            List<Raza> result = new();

            try
            {
                var searchData = await _dataContext.Razas.Where(X => X.IdRaza == 1 && X.Estado == true ).ToListAsync();

                foreach (var item in searchData)
                {
                    Raza raza = new()
                    {
                        IdRaza = item.IdRaza,
                        Nombre = item.Nombre,
                        Descripcion = item.Descripcion,
                        Estado = item.Estado,
                    };
                    result.Add(raza);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public async Task<Raza> ConsultarRazaId(int idRaza)
        {
            Raza result = new();

            try
            {
                var searchData = await _dataContext.Razas.Where(X => X.IdRaza == idRaza).FirstOrDefaultAsync();
                if(searchData == null)
                {
                    throw new Exception("La raza que estás buscando no existe");
                }

                result.Nombre = searchData.Nombre;
                result.Descripcion = searchData.Descripcion;
                result.IdRaza = searchData.IdRaza;
                result.Estado = searchData.Estado;
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }


        public async Task<CrearResponse> CrearRaza(Raza raza)
        {
            try
            {
                var request = new Raza
                {
                    Nombre = raza.Nombre,
                    Descripcion = raza.Descripcion,
                    Estado = raza.Estado,
                };

                _dataContext.Razas.Add(request);
                await _dataContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


            var response = new CrearResponse
            {
                Response = "La raza fue creada con éxito"
            };

            return response;
        }

        public async Task<CrearResponse> EditarRaza(Raza raza)
        {
      
            try
            {
                var searchData = await _dataContext.Razas.Where(X => X.IdRaza == raza.IdRaza).FirstOrDefaultAsync();
                if (searchData == null)
                {
                    throw new Exception("La raza que estás buscando no existe");
                }

                searchData.Nombre = raza.Nombre;
                searchData.Descripcion = raza.Descripcion;
                searchData.IdRaza = raza.IdRaza;
                searchData.Estado = raza.Estado;

                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            var response = new CrearResponse
            {
                Response = "La raza fue editada con éxito"
            };

            return response;
        }

        public async Task<CrearResponse> EliminarRaza(int idRaza)
        {

            try
            {
                var searchData = await _dataContext.Razas.Where(X => X.IdRaza == idRaza && X.Estado == true).FirstOrDefaultAsync();
                if (searchData == null)
                {
                    throw new Exception("La raza que estás buscando no existe");
                }
                searchData.Estado = false;
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            var response = new CrearResponse
            {
                Response = "La raza fue eliminada con éxito"
            };

            return response;
        }
    }

}