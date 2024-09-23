using LIB_Entidades;
using System.Linq.Expressions;

namespace LIB_Repositorios.Interfaces
{
    public interface ILibrosRepositorio
    {
        void Configurar(string string_conexion);
        List<Libros> Listar();
        List<Libros> Buscar(Expression<Func<Libros, bool>> condiciones);
        Libros Guardar(Libros entidad);
        Libros Modificar(Libros entidad);
        Libros Borrar(Libros entidad);
        bool Existe(Expression<Func<Libros, bool>> condiciones);
    }
}