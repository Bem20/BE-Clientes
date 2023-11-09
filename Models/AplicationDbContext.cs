using Microsoft.EntityFrameworkCore;

namespace ApiBE.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

        //Por cada tabla
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pais> Pais { get; set; }
    }
    
}
