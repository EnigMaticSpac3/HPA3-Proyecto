﻿using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class CategoriaServicios : ICategoriaServicios
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public CategoriaServicios(ICategoriaRepositorio categoriaRepositorio)
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
