using LIB_Entidades;
using LIB_Repositorios;
using LIB_Repositorios.Implementaciones;
using LIB_Repositorios.Interfaces;
using mst_Pruebas_Unitarias.Nucleo;
using mst_unittests.Nucleo;

namespace mst_Pruebas_Unitarias.Repositorios
{
    [TestClass]
        public class LibrosUnitTest
        {
            private ILibrosRepositorio? iRepositorio = null;
            private Conexion? conexion = null;
            private Libros? entidad = null;
            private List<Libros>? lista = null;

            public LibrosUnitTest()
            {
                conexion = new Conexion();
                conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
                iRepositorio = new LibrosRepositorio(conexion);
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
                entidad = EntidadesHelper_Libros.ObtenerLibros();
                entidad = iRepositorio!.Guardar(entidad!);
                Assert.IsTrue(entidad.Id != 0);
            }

            public void Modificar()
            {
                entidad!.Nombre_Libro = entidad.Nombre_Libro + " " + DateTime.Now.ToString();
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
