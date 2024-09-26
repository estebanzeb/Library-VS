using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_Entidades
{
    public class Personas
    {
        [Key] public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public long Numero { get; set; }
    }
}
