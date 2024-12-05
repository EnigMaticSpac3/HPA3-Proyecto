-- Listar Detalle de Venta por Venta
CREATE PROCEDURE sp_listaDetalleVenta
    @IdVenta INT
AS
BEGIN
    SELECT dv.IdDetalleVenta, dv.IdVenta, dv.IdProducto, p.Descripcion AS NombreProducto,
           dv.Cantidad, dv.PrecioVenta, dv.PrecioTotal
    FROM DetalleVenta dv
    INNER JOIN Producto p ON dv.IdProducto = p.IdProducto
    WHERE dv.IdVenta = @IdVenta;
END;