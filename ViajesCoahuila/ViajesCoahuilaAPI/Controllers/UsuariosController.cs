using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViajesCoahuilaAPI.Data;
using ViajesCoahuilaAPI.Validations;

namespace ViajesCoahuilaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        ViajesContext _context;
        GenericRepository<Usuario>? usuariosRepository;
        public UsuariosController(ViajesContext context)
        {
            _context= context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            usuariosRepository = new(_context);
            var usuarios = usuariosRepository.Get();
            if (usuarios==null)
            {
                return NotFound();
            }
            return Ok(usuarios);
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            usuariosRepository= new(_context);
            var usuario = usuariosRepository.GetByID(id);
            if (usuario==null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            var Validator = new UsuariosValidator();
            var result = Validator.Validate(usuario);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors.Select(x => x.ErrorMessage));
            }
            usuariosRepository = new(_context);
            usuariosRepository.Insert(usuario);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Usuario usuario)
        {
            var validator = new UsuariosValidator();
            var result = validator.Validate(usuario);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors.Select(x=>x.ErrorMessage));
            }
            usuariosRepository = new(_context);
            usuariosRepository.Update(usuario);
            _context.SaveChanges();
            return Ok();
        }
    }
}
