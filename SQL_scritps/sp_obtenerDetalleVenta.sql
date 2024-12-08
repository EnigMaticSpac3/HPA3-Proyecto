CREATE PROCEDURE sp_obtenerDetalleVenta
    @NumeroVenta VARCHAR(10)
AS
BEGIN
    SELECT 
        dv.Cantidad,
        dv.PrecioVenta,
        dv.PrecioTotal,
        p.Codigo,
        p.Descripcion
    FROM DetalleVenta dv
    INNER JOIN Producto p ON dv.IdProducto = p.IdProducto
    INNER JOIN Venta v ON dv.IdVenta = v.IdVenta
    WHERE v.NumeroVenta = @NumeroVenta;
END
