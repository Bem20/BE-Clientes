using ApiBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_Clientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public PaisController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get() //Para usar los distintos estados
        {
            try
            {
                //Thread.Sleep(1000);
                var listPaises = await _context.Pais.ToListAsync();
                return Ok(listPaises);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
