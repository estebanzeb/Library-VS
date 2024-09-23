using LIB_Entidades;
using System.Linq.Expressions;

namespace LIB_Repositorios.Interfaces
{
    public interface IPrestamosRepositorio
    {
        void Configurar(string string_conexion);
        List<Prestamos> Listar();
        List<Prestamos> Buscar(Expression<Func<Prestamos, bool>> condiciones);
        Prestamos Guardar(Prestamos entidad);
        Prestamos Modificar(Prestamos entidad);
        Prestamos Borrar(Prestamos entidad);
        bool Existe(Expression<Func<Prestamos, bool>> condiciones);
    }
}