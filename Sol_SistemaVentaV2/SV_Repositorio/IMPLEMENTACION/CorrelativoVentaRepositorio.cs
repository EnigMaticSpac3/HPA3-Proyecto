using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.Entidades;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class CorrelativoVentaRepositorio : ICorrelativoVentaRepositorio
    {
        private readonly Conexion _conexion;

        public CorrelativoVentaRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<CorrelativoVenta> ObtenerCorrelativoVenta()
        {
            CorrelativoVenta correlativo = null;
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_obtenerCorrelativoVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        correlativo = new CorrelativoVenta
                        {
                            Serie = dr["Serie"].ToString()!,
                            Numero = Convert.ToInt32(dr["Numero"]),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        };
                    }
                }
            }
            return correlativo!;
        }

        public async Task<string> ActualizarCorrelativo(CorrelativoVenta correlativoVenta)
        {
            string respuesta = "";
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_actualizarCorrelativoVenta", cn);
                cmd.Parameters.AddWithValue("@Serie", correlativoVenta.Serie);
                cmd.Parameters.AddWithValue("@Numero", correlativoVenta.Numero);
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                await cmd.ExecuteNonQueryAsync();
                respuesta = cmd.Parameters["@Mensaje"].Value.ToString()!;
            }
            return respuesta;
        }
    }

}
