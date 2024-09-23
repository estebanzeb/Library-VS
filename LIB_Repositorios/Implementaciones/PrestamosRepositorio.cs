using LIB_Entidades;
using LIB_Repositorios.Interfaces;
using System.Linq.Expressions;

namespace LIB_Repositorios.Implementaciones
{
    public class PrestamosRepositorio : IPrestamosRepositorio
    {
        private Conexion? conexion;

        public PrestamosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Prestamos> Listar()
        {
            return conexion!.Listar<Prestamos>();
        }

        public List<Prestamos> Buscar(Expression<Func<Prestamos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Prestamos Guardar(Prestamos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Prestamos Modificar(Prestamos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Prestamos Borrar(Prestamos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Prestamos, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}