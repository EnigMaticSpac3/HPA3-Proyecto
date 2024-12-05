-- Listar Ventas
CREATE PROCEDURE sp_listaVenta
    @Buscar VARCHAR(60) = ''
AS
BEGIN
    SELECT v.IdVenta, v.NumeroVenta, v.IdUsuarioRegistro, u.NombreCompleto AS UsuarioRegistro, 
           v.NombreCliente, v.PrecioTotal, v.PagoCon, v.Cambio, v.FechaRegistro, v.Activo
    FROM Venta v
    INNER JOIN Usuario u ON v.IdUsuarioRegistro = u.IdUsuario
    WHERE v.NombreCliente LIKE '%' + @Buscar + '%';
END;
