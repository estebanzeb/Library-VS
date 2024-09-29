using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_Entidades
{
    public class Libros
    {
        [Key] public int Id { get; set; }
        public int Cod_libro { get; set; }
        public string? Nombre_libro { get; set; }
        public DateTime Fecha_publicacion { get; set; }
        public string? Autor { get; set; }

    }
}