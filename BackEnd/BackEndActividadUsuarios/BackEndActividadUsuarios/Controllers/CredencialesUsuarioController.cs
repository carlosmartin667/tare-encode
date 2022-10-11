using BackEndActividadUsuarios.DTOs;
using BackEndActividadUsuarios.Servicios.CredencialesUsuario;
using Microsoft.AspNetCore.Mvc;

namespace BackEndActividadUsuarios.Controllers
{
    [ApiController]
    [Route("api/CredencialesUsuario")]
    public class CredencialesUsuarioController : ControllerBase
    {
        public ICredencialesUsuarioServices _credencialesUsuarioServices { get; }

        public CredencialesUsuarioController(ICredencialesUsuarioServices credencialesUsuarioServices)
        {
            _credencialesUsuarioServices = credencialesUsuarioServices;
        }
        [HttpGet]
        public async Task<ActionResult<List<CredencialesUsuarioDTO>>> Get()
        {

            var resultado = await _credencialesUsuarioServices.GetCredencialesUsuario();
            return resultado;

        }

        [HttpGet("{id:int}", Name = "credencialesUsuario")]
        public async Task<ActionResult<CredencialesUsuarioDTO>> Get(int id)
        {
            var resultado = await _credencialesUsuarioServices.GetCredencialesUsuario(id);
            return resultado;
        }
        [HttpPost]
        public async Task<ActionResult> Post(CredencialesUsuarioDTO credencialesUsuario)
        {

            await _credencialesUsuarioServices.PostCredencialesUsuario(credencialesUsuario);
            return Ok();
        }
        [HttpPut("(id:int)")]
        public async Task<ActionResult> Put(CredencialesUsuarioDTO credencialesUsuario, int id)
        {
            await _credencialesUsuarioServices.PutCredencialesUsuario(credencialesUsuario, id);
            return NoContent();
        }
        [HttpDelete("(id:int)")]
        public async Task<ActionResult> Delete(int id)
        {
            await _credencialesUsuarioServices.DeleteCredencialesUsuario(id);

            return NoContent();
        }
    }
}
