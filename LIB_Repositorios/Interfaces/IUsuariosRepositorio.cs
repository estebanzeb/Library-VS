using LIB_Entidades;
using System.Linq.Expressions;

namespace LIB_Repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        void Configurar(string string_conexion);
        List<Usuarios> Listar();
        List<Usuarios> Buscar(Expression<Func<Usuarios, bool>> condiciones);
        Usuarios Guardar(Usuarios entidad);
        Usuarios Modificar(Usuarios entidad);
        Usuarios Borrar(Usuarios entidad);
        bool Existe(Expression<Func<Usuarios, bool>> condiciones);
    }
}