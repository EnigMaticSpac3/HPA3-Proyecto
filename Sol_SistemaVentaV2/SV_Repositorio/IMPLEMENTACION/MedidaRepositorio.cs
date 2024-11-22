using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class MedidaRepositorio : IMedidaRepositorio
    {
        private readonly Conexion _conexion;

        public MedidaRepositorio(Conexion conexion)//Metodo constructor
        {
            _conexion = conexion;
        }

        public async Task<List<Medida>> listaMedida()
        {
            List<Medida> lista = new List<Medida>();
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();           //nombre del procedure en SQL
                var cmd = new SqlCommand("sp_listarMedida",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //dr = dataReader
                using (var dr = await cmd.ExecuteReaderAsync())//ejecuta de manera asincrona
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Medida
                        {
                            IdMedida = Convert.ToInt32(dr["IdMedida"]),
                            NomMedida = Convert.ToString(dr["NomMedida"])!,
                            Abreviatura = Convert.ToString(dr["Abreviatura"])!,
                            Equivalente = Convert.ToString(dr["Equivalente"])!,
                            Valor = Convert.ToInt32(dr["Valor"])
                        }); 
                    }
                }
                return lista;

            }

        }
    }
}
