using LIB_Entidades;
using LIB_Repositorios.Interfaces;
using System.Linq.Expressions;

namespace LIB_Repositorios.Implementaciones
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        private Conexion? conexion;

        public UsuariosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Usuarios> Listar()
        {
            return conexion!.Listar<Usuarios>();
        }

        public List<Usuarios> Buscar(Expression<Func<Usuarios, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Usuarios Guardar(Usuarios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Usuarios Modificar(Usuarios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Usuarios Borrar(Usuarios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Usuarios, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}