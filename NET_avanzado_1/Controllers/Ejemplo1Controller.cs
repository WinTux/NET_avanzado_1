using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NET_avanzado_1.Controllers
{
    [Route("api/ejemplo1")]
    public class Ejemplo1Controller : Controller
    {
        [HttpGet("prueba1")]
        public async Task<IActionResult> prueba1()
        {
            try {
                return Ok("Esta es una prueba");
            }
            catch {
                return BadRequest();
            }
        }
        [Produces("text/html")]
        [HttpGet("prueba2")]
        public async Task<IActionResult> prueba2()
        {
            try
            {
                return Ok("<h2><b>Esta es una prueba</b></h2>");
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("prueba3/{val}")]
        public async Task<IActionResult> prueba3(string val)
        {
            try
            {
                return Ok("<h2><b>Buenas noches señor "+ val +"</b></h2>");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
