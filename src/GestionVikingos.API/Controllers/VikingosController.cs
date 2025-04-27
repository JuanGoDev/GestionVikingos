namespace GestionVikingos.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using GestionVikingos.API.Models;
    using GestionVikingos.API.Services;

    [ApiController]
    [Route("api/[controller]")]
    public class VikingosController : ControllerBase
    {
        private readonly VikingoService _vikingoService;

        public VikingosController(VikingoService vikingoService)
        {
            _vikingoService = vikingoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vikingo>> ObtenerTodos()
        {
            return Ok(_vikingoService.ObtenerTodos());
        }

        [HttpGet("{id}")]
        public ActionResult<Vikingo> ObtenerPorId(int id)
        {
            var vikingo = _vikingoService.ObtenerPorId(id);
            if (vikingo == null)
                return NotFound();

            return Ok(vikingo);
        }

        [HttpPost]
        public ActionResult<Vikingo> Crear(Vikingo vikingo)
        {
            var vikingoCreado = _vikingoService.Crear(vikingo);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = vikingoCreado.Id }, vikingoCreado);
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, Vikingo vikingo)
        {
            var vikingoActualizado = _vikingoService.Actualizar(id, vikingo);
            if (vikingoActualizado == null)
                return NotFound();

            return Ok(vikingoActualizado);
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var resultado = _vikingoService.Eliminar(id);
            if (!resultado)
                return NotFound();

            return NoContent();
        }
    }
} 