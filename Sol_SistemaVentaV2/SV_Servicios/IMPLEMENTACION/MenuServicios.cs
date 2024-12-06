using SV_Repositorio.Entidades;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class MenuServicio : IMenuServicio
    {
        private readonly IMenuRepositorio _menuRepositorio;

        public MenuServicio(IMenuRepositorio menuRepositorio)
        {
            _menuRepositorio = menuRepositorio;
        }

        public async Task<IEnumerable<Menu>> ObtenerTodosMenusAsync()
        {
            return await _menuRepositorio.ObtenerTodosMenusAsync();
        }

        public async Task<Menu> ObtenerMenuByIdAsync(int id)
        {
            return await _menuRepositorio.ObtenerMenuByIdAsync(id);
        }

        public async Task AgregarMenuAsync(Menu menu)
        {
            await _menuRepositorio.AgregarMenuAsync(menu);
        }

        public async Task ActualizarMenuAsync(Menu menu)
        {
            await _menuRepositorio.ActualizarMenuAsync(menu);
        }
    }
}
