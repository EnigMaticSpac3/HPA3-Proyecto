-- Insertar Detalle de Venta
CREATE PROCEDURE sp_crearDetalleVenta
    @IdVenta INT,
    @IdProducto INT,
    @Cantidad INT,
    @PrecioVenta DECIMAL(10,2),
    @PrecioTotal DECIMAL(10,2),
    @Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    SET @Mensaje = ''
    BEGIN TRY
        INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioVenta, PrecioTotal)
        VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioVenta, @PrecioTotal);

        SET @Mensaje = 'Detalle de venta registrado correctamente.'
    END TRY
    BEGIN CATCH
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END;


