using LIB_Entidades;
using LIB_Repositorios.Interfaces;
using System.Linq.Expressions;

namespace LIB_Repositorios.Implementaciones
{
    public class DetallesRepositorio : IDetallesRepositorio
    {
        private Conexion? conexion;

        public DetallesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Detalles> Listar()
        {
            return conexion!.Listar<Detalles>();
        }

        public List<Detalles> Buscar(Expression<Func<Detalles, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Detalles Guardar(Detalles entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Detalles Modificar(Detalles entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Detalles Borrar(Detalles entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Detalles, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}