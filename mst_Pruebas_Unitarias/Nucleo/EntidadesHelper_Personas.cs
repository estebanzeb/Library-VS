using LIB_Entidades;

namespace mst_Pruebas_Unitarias.Nucleo
{
    public class EntidadesHelper_Personas
    {
        public static Personas ObtenerPersonas()
        {
            return new Personas()
            {
                Cedula = "a001teghdr4",
                Nombre = "Reyban",
                Numero= 11225
            };
        }
    }
}