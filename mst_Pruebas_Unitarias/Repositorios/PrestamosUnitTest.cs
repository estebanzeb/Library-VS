using LIB_Entidades;
using LIB_Repositorios.Implementaciones;
using LIB_Repositorios.Interfaces;
using LIB_Repositorios;
using mst_Pruebas_Unitarias.Nucleo;
using mst_unittests.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace mst_Pruebas_Unitarias.Repositorios
{
    [TestClass]
    public class PrestamosUnitTest
    {
        private IPrestamosRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Prestamos? entidad = null;
        private List<Prestamos>? lista = null;

        public PrestamosUnitTest()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new PrestamosRepositorio(conexion);
        }

        [TestMethod]
        public void Executar()
        {
            Guardar();
            Listar();
            Buscar();
            Modificar();
            Borrar();
        }

        private void Listar()
        {
            lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        public void Buscar()
        {
            lista = iRepositorio!.Buscar(x => x.Id != entidad!.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            entidad = EntidadesHelper_Prestamos.ObtenerPrestamos();
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.Id != 0);
        }

        public void Modificar()
        {
            entidad!.Fecha_prestamo = Convert.ToDateTime("2000-12-29", CultureInfo.InvariantCulture);
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id == entidad.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}
