using SV_Repositorio.ENTIDADES;
using SV_Repositorio.IMPLEMENTACION;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class CategoriaServicios : ICategoriaServicios
    {
        private readonly CategoriaRepositorio _categoriaRepositorio;
        public CategoriaServicios(CategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<List<Categoria>> listaCategoria(string buscar = "")
        {
            return await _categoriaRepositorio.listaCategoria(buscar);
        }

        public async Task<string> CrearCategoria(Categoria objeto)
        {
            return await _categoriaRepositorio.CrearCategoria(objeto);
        }

        public async Task<string> EditarCategoria(Categoria objeto)
        {
            return await _categoriaRepositorio.EditarCategoria(objeto);
        }
    }
}
