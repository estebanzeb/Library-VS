using LIB_Entidades;
using System.Linq.Expressions;

namespace LIB_Repositorios.Interfaces
{
    public interface ICopiasRepositorio
    {
        void Configurar(string string_conexion);
        List<Copias> Listar();
        List<Copias> Buscar(Expression<Func<Copias, bool>> condiciones);
        Copias Guardar(Copias entidad);
        Copias Modificar(Copias entidad);
        Copias Borrar(Copias entidad);
        bool Existe(Expression<Func<Copias, bool>> condiciones);
    }
}