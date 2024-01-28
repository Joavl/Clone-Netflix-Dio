
using API_EVENTOS.Entities;
using API_EVENTOS.Persistence;
using Microsoft.AspNetCore.Mvc;
namespace API_EVENTOS.Controllers
{
    [ApiController]
    [Route("api/controller")]

    public class EventosController : ControllerBase
    {
        private readonly EventosDbContext _context;

        public EventosController(EventosDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var evento = _context.Eventos.ToList();
            return Ok(evento);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var evento = _context.Eventos.Find(id);
            if (evento == null)
            {
                return NotFound();
            }
            return Ok(evento);
        }

        [HttpPost]
        public IActionResult Post(Eventos evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = evento.Id }, evento);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Eventos eventos)
        {
            var eventoBanco = _context.Eventos.Find(id);
            if (eventoBanco == null)
            {
                return NotFound();
            }
            eventoBanco.Update(eventos.Titulo, eventos.Descricao, eventos.DataInicio, eventos.DataFim);
            _context.Update(eventoBanco);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteById(int id)
        {
            var eventoBanco = _context.Eventos.Find(id);
            if (eventoBanco == null)
            {
                return NotFound();
            }
            _context.Eventos.Remove(eventoBanco);
            _context.SaveChanges();
            return NoContent();

        }
    }
}