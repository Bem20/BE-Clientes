using ApiBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_Clientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ClienteController(AplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientesWithPais()
        {
            var result = await _context.Clientes
                .FromSqlRaw("EXEC sp_GetClientesWithPais")
                .ToListAsync();

            return result;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get() //Para usar los distintos estados
        //{
        //    try
        //    {
        //        //Thread.Sleep(1000);
        //        var listClientes = await _context.Clientes.ToListAsync();
        //        return Ok(listClientes);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
