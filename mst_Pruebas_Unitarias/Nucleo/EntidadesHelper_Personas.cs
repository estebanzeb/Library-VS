using LIB_Entidades;

namespace mst_Pruebas_Unitarias.Nucleo
{
    public class EntidadesHelper_Personas
    {
        public static Personas ObtenerPersonas()
        {
            return new Personas()
            {
                Cedula = 121337,
                Nombre = "sdvsvcsd",
                Numero= 11225
            };
        }
    }
}