using Microsoft.AspNetCore.Mvc;
using pomboCorreio.Data;
using pomboCorreio.Models;

namespace pomboCorreio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PomboCorreioController : ControllerBase
    {

        private PomboCorreioContext _context;

        public PomboCorreioController(PomboCorreioContext context)
        {
            _context = context;
        }

        [HttpPost("cadastro")]
        public IActionResult CadastrarUsuario([FromForm] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarUsuarioPorId),
                new { id = usuario.Id },
                usuario);
        }

        [HttpGet("getAllUsuarios")]
        public IEnumerable<Usuario> RecuperarUsuario([FromQuery] int skip =
            0,
                [FromQuery] int take = 50)
        {
            return _context.Usuarios.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarUsuarioPorId(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPost("logar")]

        public IActionResult LogarUsuario([FromForm]string email, [FromForm]string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Email == email && usuario.Senha == senha);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }
    }
}
