using AutoMapper;
using BackEndActividadUsuarios.DTOs;
using BackEndActividadUsuarios.Entidades;
using BackEndActividadUsuarios.Servicios.ActividadesUsuario;
using Microsoft.EntityFrameworkCore;

namespace BackEndActividadUsuarios.Servicios.CredencialesUsuario
{
    public class CredencialesUsuarioServices : ICredencialesUsuarioServices
    {
        public ApplicationDbContext _context { get; }
        public IMapper _mapper { get; }
        public IActividadesUsuarioServices _actividadesUsuarioServices { get; }

        public CredencialesUsuarioServices(ApplicationDbContext context, IMapper mapper, IActividadesUsuarioServices actividadesUsuarioServices)
        {
            _context = context;
            _mapper = mapper;
            _actividadesUsuarioServices = actividadesUsuarioServices;
        }

        public async Task<bool> DeleteCredencialesUsuario(int id)
        {
            try
            {
                _context.Remove(new CredencialesUsuarioModel() { Id = id });

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public async Task<List<CredencialesUsuarioDTO>> GetCredencialesUsuario()
        {
            try
            {
                var Usuarios = await _context.Usuario.ToListAsync();
                return _mapper.Map<List<CredencialesUsuarioDTO>>(Usuarios);
            }
            catch (Exception ex)
            {

                throw;
            }
    
        }

        public async Task<CredencialesUsuarioDTO> GetCredencialesUsuario(int id)
        {
            try
            {
                var usuario = await _context.Usuario.FirstOrDefaultAsync(autorBD => autorBD.Id == id);

                var resultado = _mapper.Map<CredencialesUsuarioDTO>(usuario);
                return resultado;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<bool> PostCredencialesUsuario(CredencialesUsuarioDTO credencialesUsuario)
        {
            try
            {
                var Usuario = _mapper.Map<CredencialesUsuarioModel>(credencialesUsuario);
                _context.Add(Usuario);
                await _context.SaveChangesAsync();
                await _actividadesUsuarioServices.ActividadesUsuarios(Usuario.Id, "Creacion de usuario");
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public async Task<bool> PutCredencialesUsuario(CredencialesUsuarioDTO credencialesUsuario, int id)
        {
            try
            {
                var existe = await _context.Usuario.AnyAsync(x => x.Id == id);

                var usuario = _mapper.Map<CredencialesUsuarioModel>(credencialesUsuario);
                usuario.Id = id;

                _context.Update(usuario);
                await _context.SaveChangesAsync();
                await _actividadesUsuarioServices.ActividadesUsuarios(usuario.Id, "Actualización de Usuario");
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
    
        }
    }
}
