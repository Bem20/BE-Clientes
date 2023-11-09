using System.ComponentModel.DataAnnotations;

namespace ApiBE.Models
{
    public class Cliente
    {
        [Key]
        public decimal IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int CodigoPais { get; set; }
        public string Descripcion { get; set; }
    }
}
