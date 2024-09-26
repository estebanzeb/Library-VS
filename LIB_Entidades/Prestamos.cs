using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_Entidades
{
    public class Prestamos
    {
        [Key] public int Id { get; set; }
        public DateTime Fecha_Prestamo { get; set; }
        public int Usuario { get; set; } [ForeignKey("Usuario")] public virtual Usuarios? _Usuarios { get; set; }

    }
}
