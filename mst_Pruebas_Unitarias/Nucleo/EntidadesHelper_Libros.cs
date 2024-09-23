using LIB_Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mst_Pruebas_Unitarias.Nucleo
{
    public class EntidadesHelper_Libros
    {
        public static Libros ObtenerLibros()
        {
            DateTime fecha = Convert.ToDateTime("1990/01/01", CultureInfo.InvariantCulture);
            return new Libros()
            {
                Cod_Libro=12423,
                Nombre_Libro="qfewf",
                Fecha_Publicacion = fecha,
                Autor ="Yo"
            };
        }
    }
}
