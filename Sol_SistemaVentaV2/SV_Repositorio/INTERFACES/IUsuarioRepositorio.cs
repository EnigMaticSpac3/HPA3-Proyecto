using SV_Repositorio.ENTIDADES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SV_Repositorio.INTERFACES
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> ListarUsuarios(string buscar = "");
        Task<string> CrearUsuario(Usuario objeto);
        Task<string> EditarUsuario(Usuario objeto);
    }
}
