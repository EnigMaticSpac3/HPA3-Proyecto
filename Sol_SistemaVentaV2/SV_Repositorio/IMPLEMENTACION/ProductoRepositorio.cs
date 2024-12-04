using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.ENTIDADES;
using SVRepositorio.ENTIDADES;
using SVRepositorio.INTERFACE;
using System.Data;

namespace SVRepositorio.IMPLEMENTACION
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private readonly Conexion _conexion;

        public ProductoRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Producto>> listaProducto(string buscar = "")
        {
            List<Producto> lista = new List<Producto>();

            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_listaProducto", cn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            Codigo = dr["Codigo"].ToString()!,
                            Descripcion = dr["Descripcion"].ToString()!,
                            PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            Activo = Convert.ToBoolean(dr["Activo"]),
                            RefCategoria = new Categoria
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                NombreCategoria = dr["NombreCategoria"].ToString()!
                            }
                        });
                    }
                }
                return lista;
            }
        }

        public Task<string> CrearProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
