using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
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

        public async Task<string> CrearProducto(Producto producto)
        {
            string respuesta = "";
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_crearProducto", cn);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.RefCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);

                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = cmd.Parameters["@MsjError"].Value.ToString()!;
                }
                catch 
                {
                    respuesta = "Error(Crear Producto), No se pudo insertar el registro";
                }

            }
            return respuesta;
        }

        public async Task<string> EditarProducto(Producto producto)
        {
            string respuesta = "";
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_editarProducto", cn);
                cmd.Parameters.AddWithValue("@IdCategoria", producto.RefCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);

                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = cmd.Parameters["@Mensaje"].Value.ToString()!;
                }
                catch
                {
                    respuesta = "Error(Editar Producto), No se pudo actualizar el registro";
                }
                
            }
            return respuesta;
        }
    }
}

