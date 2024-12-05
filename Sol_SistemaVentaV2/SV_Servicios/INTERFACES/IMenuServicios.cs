using SV_Repositorio.Entidades;

namespace SV_Servicios.INTERFACES
{
    public interface IMenuServicio
    {
        Task<IEnumerable<Menu>> ObtenerTodosMenusAsync();
        Task<Menu> ObtenerMenuByIdAsync(int id);
        Task AgregarMenuAsync(Menu menu);
        Task ActualizarMenuAsync(Menu menu);
    }
}
