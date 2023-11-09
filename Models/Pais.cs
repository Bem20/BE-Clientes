using System.ComponentModel.DataAnnotations;

namespace ApiBE.Models
{
    public class Pais
    {
        [Key]
        public int Codigo { get; set; }
        public string ?Descripcion { get; set; }
    }
}
