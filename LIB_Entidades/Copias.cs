using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_Entidades
{
    public class Copias
    {
        [Key] public int Id { get; set; }
        public string? Notas { get; set; }
        public bool? Estado { get; set; }
        public int Libro { get; set; }

        [ForeignKey("Libro")] public virtual Libros? _Libros { get; set; }
    }
}
