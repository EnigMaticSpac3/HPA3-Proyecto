﻿using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.Entidades;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class VentaRepositorio : IVentaRepositorio
    {
        private readonly Conexion _conexion;

        public VentaRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<string> CrearVenta(Venta venta)
        {
            string respuesta = "";
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_crearVenta", cn);
                cmd.Parameters.AddWithValue("@NumeroVenta", venta.NumeroVenta);
                cmd.Parameters.AddWithValue("@IdUsuarioRegistro", venta.RefUsuarioRegistro.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreCliente", venta.NombreCliente);
                cmd.Parameters.AddWithValue("@PrecioTotal", venta.PrecioTotal);
                cmd.Parameters.AddWithValue("@PagoCon", venta.PagoCon);
                cmd.Parameters.AddWithValue("@Cambio", venta.Cambio);
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                await cmd.ExecuteNonQueryAsync();
                respuesta = cmd.Parameters["@Mensaje"].Value.ToString()!;
            }
            return respuesta;
        }

        public async Task<List<Venta>> listaVenta(string buscar = "")
        {
            List<Venta> lista = new List<Venta>();
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_listaVenta", cn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Venta
                        {
                            IdVenta = Convert.ToInt32(dr["IdVenta"]),
                            NumeroVenta = dr["NumeroVenta"].ToString()!,
                            RefUsuarioRegistro = new Usuario
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuarioRegistro"]),
                                NombreCompleto = dr["UsuarioRegistro"].ToString()!
                            },
                            NombreCliente = dr["NombreCliente"].ToString()!,
                            PrecioTotal = Convert.ToDecimal(dr["PrecioTotal"]),
                            PagoCon = Convert.ToDecimal(dr["PagoCon"]),
                            Cambio = Convert.ToDecimal(dr["Cambio"]),
                            FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}