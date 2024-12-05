using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SV_Servicios.IMPLEMENTACION
{
    public class MenuRolServicios : IMenuRolServicios
    {
        private readonly IMenuRolRepositorio _menuRolRepositorio;

        public MenuRolServicios(IMenuRolRepositorio menuRolRepositorio)
        {
            _menuRolRepositorio = menuRolRepositorio;
        }

        public async Task<List<MenuRol>> ListarMenuRoles(string buscar = "")
        {
            return await _menuRolRepositorio.ListarMenuRoles(buscar);
        }

        public async Task<string> CrearMenuRol(MenuRol objeto)
        {
            return await _menuRolRepositorio.CrearMenuRol(objeto);
        }

        public async Task<string> EditarMenuRol(MenuRol objeto)
        {
            return await _menuRolRepositorio.EditarMenuRol(objeto);
        }
    }
}
