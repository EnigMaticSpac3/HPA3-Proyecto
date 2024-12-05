CREATE PROCEDURE sp_listarCompra
(
    @Buscar VARCHAR(50) = ' '
)
AS
BEGIN
    SELECT 
        v.IdVenta,
        v.NumeroVenta,
        v.NombreCliente,
        v.PrecioTotal,
        v.PagoCon,
        v.Cambio,
        v.FechaRegistro,
        v.Activo,
        u.IdUsuario,
        u.NombreCompleto AS UsuarioRegistro
    FROM 
        Venta v
        INNER JOIN Usuario u ON v.IdUsuarioRegistro = u.IdUsuario
    WHERE 
        CONCAT(v.NumeroVenta, v.NombreCliente, u.NombreCompleto, 
               CASE WHEN v.Activo = 1 THEN 'SI' ELSE 'NO' END) LIKE '%' + @Buscar + '%'
END;
GO