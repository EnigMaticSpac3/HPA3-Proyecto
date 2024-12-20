﻿using SV_Repositorio.ENTIDADES;

namespace SV_Repositorio.INTERFACES
{
    public interface IProductoRepositorio
    {
        Task<List<Producto>> listaProducto(string buscar = "");
        Task<string> CrearProducto(Producto producto);
        Task<string> EditarProducto(Producto producto);
    }
}
