using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_Entidades
{
    public class Usuarios
    {
        [Key] public int Id { get; set; }
        public int? Cod_usuario { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public int Persona { get; set; } [ForeignKey("Persona")] public virtual Personas? _Persona { get; set; }

        public void Prestar()
        {

        }
        public void Validar_persona()
        {

        }
    }
}
