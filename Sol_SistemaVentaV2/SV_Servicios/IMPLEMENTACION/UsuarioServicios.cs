using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class UsuarioServicios : IUsuarioServicios
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServicios(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<List<Usuario>> ListarUsuarios(string buscar = "")
        {
            return await _usuarioRepositorio.ListarUsuarios(buscar);
        }

        public async Task<string> CrearUsuario(Usuario objeto)
        {
            return await _usuarioRepositorio.CrearUsuario(objeto);
        }

        public async Task<string> EditarUsuario(Usuario objeto)
        {
            return await _usuarioRepositorio.EditarUsuario(objeto);
        }
    }
}
