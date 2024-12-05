using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class CompraRepositorio : ICompraRepositorio
    {
        private readonly Conexion _conexion;

        public CompraRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Compra>> ListarCompras(string buscar = "")
        {
            List<Compra> listaCompras = new List<Compra>();

            using (var cn = _conexion.ObtenerSql())
            {
                await cn.OpenAsync();
                using (var cmd = new SqlCommand("sp_listarCompras", cn))
                {
                    cmd.Parameters.AddWithValue("@Buscar", buscar);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            listaCompras.Add(new Compra
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                FechaCompra = Convert.ToDateTime(dr["FechaCompra"]),
                                Total = Convert.ToDecimal(dr["Total"]),
                                RefUsuario = new Usuario
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    NombreUsuario = dr["NombreUsuario"].ToString()!,
                                }
                            });
                        }
                    }
                }
            }

            return listaCompras;
        }

        public async Task<string> CrearCompra(Compra compra)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();
                    using (var cmd = new SqlCommand("sp_crearCompra", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdUsuario", compra.IdUsuario);
                        cmd.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                        cmd.Parameters.AddWithValue("@Total", compra.Total);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "Compra creada exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al crear la compra: {ex.Message}";
            }
        }

        public async Task<string> EditarCompra(Compra compra)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();
                    using (var cmd = new SqlCommand("sp_editarCompra", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdCompra", compra.IdCompra);
                        cmd.Parameters.AddWithValue("@IdUsuario", compra.IdUsuario);
                        cmd.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                        cmd.Parameters.AddWithValue("@Total", compra.Total);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "Compra actualizada exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al editar la compra: {ex.Message}";
            }
        }
    }
}
