﻿using SV_Repositorio.ENTIDADES;

namespace SV_Servicios.INTERFACES
{
    public interface ICategoriaServicios
    {
        Task<List<Categoria>> listaCategoria(string buscar = "");//Nombre del objeto
        Task<string> CrearCategoria(Categoria objeto);
        Task<string> EditarCategoria(Categoria objeto);
        Task<Categoria> ObtenerCategoriaPorId(int idCategoria);

        Task<List<Categoria>> ObtenerCategorias();
    }
}
