using SV_Repositorio.Entidades;

namespace SV_Repositorio.INTERFACES
{
    public interface IMenuRolRepositorio
    {
        Task<List<MenuRol>> ListarMenuRoles(string buscar = "");
        Task<string> CrearMenuRol(MenuRol objeto);
        Task<string> EditarMenuRol(MenuRol objeto);
    }
}
