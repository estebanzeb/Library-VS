using LIB_Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mst_Pruebas_Unitarias.Nucleo
{
    public class EntidadesHelper_Prestamos
    {
        public static Prestamos ObtenerPrestamos()
        {
            DateTime fecha = Convert.ToDateTime("1990/01/01", CultureInfo.InvariantCulture);
            return new Prestamos()
            {
            Fecha_Inicio=fecha,
            Usuario= 9005566
            };
        }
    }
}
