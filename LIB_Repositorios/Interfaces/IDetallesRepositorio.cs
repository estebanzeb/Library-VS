using LIB_Entidades;
using System.Linq.Expressions;

namespace LIB_Repositorios.Interfaces
{
    public interface IDetallesRepositorio
    {
        void Configurar(string string_conexion);
        List<Detalles> Listar();
        List<Detalles> Buscar(Expression<Func<Detalles, bool>> condiciones);
        Detalles Guardar(Detalles entidad);
        Detalles Modificar(Detalles entidad);
        Detalles Borrar(Detalles entidad);
        bool Existe(Expression<Func<Detalles, bool>> condiciones);
    }
}