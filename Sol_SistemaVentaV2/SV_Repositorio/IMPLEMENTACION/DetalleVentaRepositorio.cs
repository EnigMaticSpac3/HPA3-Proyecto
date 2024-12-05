using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class DetalleVentaRepositorio : IDetalleVentaRepositorio
    {
        private readonly Conexion _conexion;

        public DetalleVentaRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<DetalleVenta>> listaDetalleVenta(int idVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_listaDetalleVenta", cn);
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new DetalleVenta
                        {
                            IdDetalleVenta = Convert.ToInt32(dr["IdDetalleVenta"]),
                            RefVenta = new Venta
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"])
                            },
                            RefProducto = new Producto
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Descripcion = dr["NombreProducto"].ToString()!
                            },
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"])
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> CrearDetalleVenta(DetalleVenta detalleVenta)
        {
            string respuesta = "";
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_crearDetalleVenta", cn);
                cmd.Parameters.AddWithValue("@IdVenta", detalleVenta.RefVenta.IdVenta);
                cmd.Parameters.AddWithValue("@IdProducto", detalleVenta.RefProducto.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioVenta", detalleVenta.PrecioVenta);
                cmd.Parameters.AddWithValue("@PrecioTotal", detalleVenta.PrecioTotal);
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                await cmd.ExecuteNonQueryAsync();
                respuesta = cmd.Parameters["@Mensaje"].Value.ToString()!;
            }
            return respuesta;
        }
    }
}
