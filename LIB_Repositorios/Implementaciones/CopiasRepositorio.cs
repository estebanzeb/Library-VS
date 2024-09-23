using LIB_Entidades;
using LIB_Repositorios.Interfaces;
using System.Linq.Expressions;

namespace LIB_Repositorios.Implementaciones
{
    public class CopiasRepositorio : ICopiasRepositorio
    {
        private Conexion? conexion  =null;

        public CopiasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Copias> Listar()
        {
            return conexion!.Listar<Copias>();
        }

        public List<Copias> Buscar(Expression<Func<Copias, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Copias Guardar(Copias entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Copias Modificar(Copias entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Copias Borrar(Copias entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Copias, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}