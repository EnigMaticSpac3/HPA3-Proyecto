using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SV_Servicios.INTERFACES
{
    public interface IMenuRolServicios
    {
        Task<List<MenuRol>> ListarMenuRoles(string buscar = "");
        Task<string> CrearMenuRol(MenuRol objeto);
        Task<string> EditarMenuRol(MenuRol objeto);
    }
}
