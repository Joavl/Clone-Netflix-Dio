using CRUD_DIO.Context;
using CRUD_DIO.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.ObjectiveC;

namespace CRUD_DIO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatosController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatosController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPorId),new {id = contato.Id} ,  contato);
        }

        [HttpGet("{id}")]

        public IActionResult GetPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato is null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]

        public IActionResult GetPorNome(string nome)
        {
            var contato = _context.Contatos.Where(x=>x.Nome.Contains(nome));
            if (contato is null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpPut("{id}")]

        public IActionResult Update(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return Ok(contato);

        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }
            _context.Contatos.Remove(contato); 
            _context.SaveChanges();
            return NoContent();
        }
    }
}
