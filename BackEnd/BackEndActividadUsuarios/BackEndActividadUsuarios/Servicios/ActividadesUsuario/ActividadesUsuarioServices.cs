using AutoMapper;
using BackEndActividadUsuarios.DTOs;
using BackEndActividadUsuarios.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BackEndActividadUsuarios.Servicios.ActividadesUsuario
{
    public class ActividadesUsuarioServices : IActividadesUsuarioServices
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ActividadesUsuarioServices(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<bool> ActividadesUsuarios(int id, string actividad)
        {
            try
            {
                var Actividad = new ActividadesUsuarioModel();
                Actividad.Id_usuario = id;
                Actividad.Create_date = DateTime.Now;
                Actividad.Actividad = actividad;
                var Usuario = mapper.Map<ActividadesUsuarioModel>(Actividad);
                context.Add(Usuario);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<List<ActividadesUsuarioDTO>> GetActividadesUsuarios()
        {
            try
            {
                var ActividadesUsuarios = await context.Actividades.ToListAsync();
                return mapper.Map<List<ActividadesUsuarioDTO>>(ActividadesUsuarios);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<List<ActividadesUsuarioDTO>> GetActividadesUsuario(int id_usuario)
        {
            try
            {
                var autores = await context.Actividades.Where(bd => bd.Id_usuario == id_usuario).ToListAsync();

                return mapper.Map<List<ActividadesUsuarioDTO>>(autores);
            }
            catch (Exception ex)
            {

                throw;
            }

        }


    }
}
