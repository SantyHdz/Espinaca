using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        [Display(Name = "Fecha De Lanzamiento")]

        [DataType(DataType.Date)]
        public DateTime Fechalanzamiento { get; set; }
        public string Genero { get; set; } = string.Empty;
        [Display(Name = "Codigo De Album")]
        public decimal Codigodealbum { get; set; }
    }
}