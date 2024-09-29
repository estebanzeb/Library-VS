using LIB_Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mst_Pruebas_Unitarias.Nucleo
{
    public class EntidadesHelper_Detalles
    {
        public static Detalles ObtenerDetalles()
        {
            DateTime fecha = Convert.ToDateTime("2012/04/09", CultureInfo.InvariantCulture);

            return new Detalles()
            {
                Fecha_entrega = fecha,
                Prestamo=5,
                Copia=5
            };
        }
    }
}
