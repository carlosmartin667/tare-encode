using BackEndActividadUsuarios.DTOs;
using BackEndActividadUsuarios.Servicios.ActividadesUsuario;
using Microsoft.AspNetCore.Mvc;

namespace BackEndActividadUsuarios.Controllers
{
    [ApiController]
    [Route("api/ActividadesUsuario")]
    public class ActividadesUsuarioController : ControllerBase
    {
        private readonly IActividadesUsuarioServices _actividadesUsuarioServices;

        public ActividadesUsuarioController(IActividadesUsuarioServices actividadesUsuarioServices)
        {
            this._actividadesUsuarioServices = actividadesUsuarioServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<ActividadesUsuarioDTO>>> Get()
        {
            var resultado = await _actividadesUsuarioServices.GetActividadesUsuarios();
            return resultado;
        }

        [HttpGet("{id_usuario:int}")]
        public async Task<ActionResult<List<ActividadesUsuarioDTO>>> Get([FromRoute] int id_usuario)
        {
            var resultado = await _actividadesUsuarioServices.GetActividadesUsuario(id_usuario);
            return resultado;
        }

    }
}
