using SV_Repositorio.ENTIDADES;

namespace SV_Repositorio.INTERFACES
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> ListarUsuarios(string buscar = "");
        Task<string> CrearUsuario(Usuario objeto);
        Task<string> EditarUsuario(Usuario objeto);
    }
}
