using BackEndActividadUsuarios.DTOs;

namespace BackEndActividadUsuarios.Servicios.CredencialesUsuario
{
    public interface ICredencialesUsuarioServices
    {
        public Task<List<CredencialesUsuarioDTO>> GetCredencialesUsuario();
        public Task<CredencialesUsuarioDTO> GetCredencialesUsuario(int id);
        public Task<bool> PostCredencialesUsuario(CredencialesUsuarioDTO credencialesUsuario);
        public Task<bool> PutCredencialesUsuario(CredencialesUsuarioDTO credencialesUsuario, int id);

        public Task<bool> DeleteCredencialesUsuario(int id);
    }
}
