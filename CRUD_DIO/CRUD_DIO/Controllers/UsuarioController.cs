using Microsoft.AspNetCore.Mvc;
namespace CRUD_DIO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("Obter DataHora")]

        public IActionResult DataHora()
        {

            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("apresentar/{nome}")]

        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome} , seja bem vindo(a) !!!";

            return Ok(new { mensagem });
        }
    }
}
