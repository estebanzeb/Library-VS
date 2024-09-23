using LIB_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mst_Pruebas_Unitarias.Nucleo
{
    public class EntidadesHelper_Copias
    {
        public static Copias ObtenerCopias()
        {
            return new Copias()
            {
                Notas="Hola",
                Estado=true,
                Libro=4,
            };
        }
    }
}
