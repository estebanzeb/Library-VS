using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_Entidades
{
    public class Detalles
    {
        [Key] public int Id { get; set; }
        public DateTime Fecha_entrega { get; set; }
        public int Prestamo { get; set; } [ForeignKey("Prestamo")] public virtual Prestamos? _Prestamos { get; set; }
        public int Copia { get; set; } [ForeignKey("Copia")] public virtual Copias? _Copias { get; set; }

    }
}
