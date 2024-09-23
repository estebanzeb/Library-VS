using LIB_Entidades;
using LIB_Repositorios;
using LIB_Repositorios.Implementaciones;
using LIB_Repositorios.Interfaces;
using mst_Pruebas_Unitarias.Nucleo;
using mst_unittests.Nucleo;

namespace mst_Pruebas_Unitarias.Repositorios
{
    [TestClass]
    public class UsuariosUnitTest
    {
        private IUsuariosRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Usuarios? entidad = null;
        private List<Usuarios>? lista = null;

        public UsuariosUnitTest()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new UsuariosRepositorio(conexion);
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
            //entidad = EntidadesHelper.ObtenerPersonas();
            lista = iRepositorio!.Buscar(x => x.Cod_Usuario != entidad!.Cod_Usuario);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            entidad = EntidadesHelper_Usuarios.ObtenerUsuarios();
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.Cod_Usuario != 0);
        }

        public void Modificar()
        {
            entidad!.Correo = entidad.Correo + " " + DateTime.Now.ToString();
            entidad = iRepositorio!.Modificar(entidad!);

            lista = iRepositorio!.Buscar(x => x.Cod_Usuario == entidad.Cod_Usuario);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Cod_Usuario == entidad!.Cod_Usuario);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}
