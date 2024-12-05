using SV_Repositorio.Entidades;

namespace SV_Servicios.INTERFACES
{
    public interface IRolServicios
    {
        Task<List<Rol>> ListarRoles(string buscar = "");
        Task<string> CrearRol(Rol objeto);
        Task<string> EditarRol(Rol objeto);
    }
}

