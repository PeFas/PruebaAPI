using PruebaAPI.Models;
using PruebaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RutinaController : ControllerBase
    {
        public RutinaController()
        {
        }

        [HttpGet]
        public ActionResult<List<Rutina>> GetAll() =>
            RutinaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Rutina> Get(int id)
        {
            var rutina = RutinaService.Get(id);

            if (rutina == null)
                return NotFound();

            return rutina;
        }
        [HttpPost]
        public IActionResult Create(Rutina rutina)
        {
            RutinaService.Add(rutina);
            return CreatedAtAction(nameof(Get), new { id = rutina.Id }, rutina);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, Rutina rutina)
        {
            if (id != rutina.Id)
            {
                return BadRequest();
            }

            var existingRutina = RutinaService.Get(id);
            if (existingRutina is null)
            {
                return NotFound();
            }

            RutinaService.Update(rutina);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var rutina = RutinaService.Get(id);

            if (rutina is null)
            {
                return NotFound();
            }

            RutinaService.Delete(id);

            return NoContent();
        }
    }
}
