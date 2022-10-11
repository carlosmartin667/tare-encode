using AutoMapper;
using BackEndActividadUsuarios.DTOs;
using BackEndActividadUsuarios.Entidades;

namespace BackEndActividadUsuarios.Infrastructure
{
    public class AutoMapperProfiles:Profile
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
