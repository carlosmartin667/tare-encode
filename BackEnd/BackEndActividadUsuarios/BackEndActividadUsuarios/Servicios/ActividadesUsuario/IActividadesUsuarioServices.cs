using BackEndActividadUsuarios.DTOs;

namespace BackEndActividadUsuarios.Servicios.ActividadesUsuario
{
    public interface IActividadesUsuarioServices
    {
        public Task<bool>ActividadesUsuarios(int id, string actividad);
        public Task<List<ActividadesUsuarioDTO>> GetActividadesUsuarios();
        public Task<List<ActividadesUsuarioDTO>> GetActividadesUsuario(int id_usuario);
    }
}
