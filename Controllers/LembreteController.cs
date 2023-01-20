using Microsoft.AspNetCore.Mvc;
using pomboCorreio.Data;
using pomboCorreio.Models;

namespace pomboCorreio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LembreteController : ControllerBase
    {
        private PomboCorreioContext _context;

        public LembreteController(PomboCorreioContext context)
        {
            _context = context;
        }

        [HttpPost("createlembrete")]
        public IActionResult CriarLembrete([FromForm] Lembrete lembrete)
        {
            _context.Lembrete.Add(lembrete);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarUsuarioPorId),
                new { id = lembrete.Id },
                lembrete);
        }

        [HttpGet("getAllLembretesPorusuario")]
        public IEnumerable<Lembrete> RecuperarLembrete([FromQuery] int skip =
            0,
                [FromQuery] int take = 50)
        {
            return _context.Lembrete.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarUsuarioPorId(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }
    }
}

