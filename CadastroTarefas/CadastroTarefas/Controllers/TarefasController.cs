using CadastroTarefas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTarefas.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        public TarefasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Salvar")]
        public object Salvar([FromBody] Tarefas tarefas)
        {
            try
            {
                _context.Tarefas.Add(tarefas);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }

        [HttpPost("Excluir")]
        public object Excluir(int IdTarefa)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }

        [HttpPost("Listar")]
        public object Listar()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }
    }
}
