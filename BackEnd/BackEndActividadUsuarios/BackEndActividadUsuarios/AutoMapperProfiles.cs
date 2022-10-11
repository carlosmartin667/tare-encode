using AutoMapper;
using DTO;
using Entidades;

namespace BackEndActividadUsuarios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CredencialesUsuarioDTO, CredencialesUsuarioModel>();
            CreateMap<CredencialesUsuarioModel, CredencialesUsuarioDTO>();

            CreateMap<ActividadesUsuarioDTO, ActividadesUsuarioModel>();
            CreateMap<ActividadesUsuarioModel, ActividadesUsuarioDTO>();

        }
    }
}
