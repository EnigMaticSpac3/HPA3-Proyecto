using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SV_Repositorio.INTERFACES
{
    public interface IRolRepositorio
    {
        Task<List<Rol>> ListarRoles(string buscar = "");
        Task<string> CrearRol(Rol objeto);
        Task<string> EditarRol(Rol objeto);
    }
}
