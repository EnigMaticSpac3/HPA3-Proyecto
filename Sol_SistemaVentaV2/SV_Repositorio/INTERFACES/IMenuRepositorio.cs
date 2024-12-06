using SV_Repositorio.Entidades;

namespace SV_Repositorio.INTERFACES
{
    public interface IMenuRepositorio
    {
        Task<IEnumerable<Menu>> ObtenerTodosMenusAsync();
        Task<Menu> ObtenerMenuByIdAsync(int id);
        Task AgregarMenuAsync(Menu menu);
        Task ActualizarMenuAsync(Menu menu);
    }


}
