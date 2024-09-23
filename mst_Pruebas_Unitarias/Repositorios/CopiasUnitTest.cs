using LIB_Entidades;
using LIB_Repositorios;
using LIB_Repositorios.Implementaciones;
using LIB_Repositorios.Interfaces;
using mst_Pruebas_Unitarias.Nucleo;
using mst_unittests.Nucleo;

namespace mst_Pruebas_Unitarias.Repositorios
{
    [TestClass]
    public class CopiasUnitTest
    {
        private ICopiasRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Copias? entidad = null;
        private List<Copias>? lista = null;

        public CopiasUnitTest()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new CopiasRepositorio(conexion);
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
            entidad = EntidadesHelper_Copias.ObtenerCopias();
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.Id != 0);
        }

        public void Modificar()
        {
            entidad!.Notas = entidad.Notas + " " + DateTime.Now.ToString();
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
