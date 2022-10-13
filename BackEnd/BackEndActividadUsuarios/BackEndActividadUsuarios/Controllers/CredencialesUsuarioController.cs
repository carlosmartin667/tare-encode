using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Servicios.CredencialesUsuario;

namespace BackEndActividadUsuarios.Controllers
{
    [ApiController]
    [Route("api/CredencialesUsuario")]
    [EnableCors]
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CredencialesUsuarioDTO))]
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> Post([FromBody] CredencialesUsuarioDTO credencialesUsuarioModel)
        {
            await _credencialesUsuarioServices.PostCredencialesUsuario(credencialesUsuarioModel);
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
