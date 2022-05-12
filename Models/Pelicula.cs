using System.ComponentModel.DataAnnotations;

namespace Cine.Models
{
    public class Pelicula
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;

        public string Genero { get; set; } = string.Empty;
    }
}
