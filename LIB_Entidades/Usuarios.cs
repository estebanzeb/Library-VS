using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_Entidades
{
    public class Usuarios
    {
        [Key] public int? Cod_Usuario { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public int Persona { get; set; } [ForeignKey("Persona")] public virtual Personas? _Persona { get; set; }
    }
}
