using LIB_Entidades;

namespace mst_Pruebas_Unitarias.Nucleo
{
    public class EntidadesHelper_Usuarios
    {
        public static Usuarios ObtenerUsuarios()
        {
            return new Usuarios()
            {
                Cod_usuario=9182,
                Correo = "Example@correo.com1",
                Contraseña="2f2rg4356jk",
                Persona=5
            };
        }
    }
}
