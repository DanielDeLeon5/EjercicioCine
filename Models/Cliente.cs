using System.ComponentModel.DataAnnotations;

namespace Cine.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public int Asiento { get; set; }
        public string Nit { get; set; } = string.Empty;
        public int idSala { get; set; }
        public int idPelicula { get; set; }
    }
}
