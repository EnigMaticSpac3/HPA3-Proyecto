using SV_Repositorio.Entidades;

namespace SV_Servicios.INTERFACES
{
    public interface IMenuRolServicios
    {
        Task<List<MenuRol>> ListarMenuRoles(string buscar = "");
        Task<string> CrearMenuRol(MenuRol objeto);
        Task<string> EditarMenuRol(MenuRol objeto);
    }
}
