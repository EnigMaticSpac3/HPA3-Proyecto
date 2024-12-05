using SV_Repositorio.ENTIDADES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SV_Servicios.INTERFACES
{
    public interface IUsuarioServicios
    {
        Task<List<Usuario>> ListarUsuarios(string buscar = "");
        Task<string> CrearUsuario(Usuario objeto);
        Task<string> EditarUsuario(Usuario objeto);
    }
}
}
