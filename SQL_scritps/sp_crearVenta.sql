-- Insertar Venta
CREATE PROCEDURE sp_crearVenta
    @NumeroVenta VARCHAR(10),
    @IdUsuarioRegistro INT,
    @NombreCliente VARCHAR(60),
    @PrecioTotal DECIMAL(10,2),
    @PagoCon DECIMAL(10,2),
    @Cambio DECIMAL(10,2),
    @Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    SET @Mensaje = ''
    BEGIN TRY
        INSERT INTO Venta (NumeroVenta, IdUsuarioRegistro, NombreCliente, PrecioTotal, 
                           PagoCon, Cambio, FechaRegistro, Activo)
        VALUES (@NumeroVenta, @IdUsuarioRegistro, @NombreCliente, @PrecioTotal, 
                @PagoCon, @Cambio, GETDATE(), 1);

        SET @Mensaje = 'Venta registrada correctamente.'
    END TRY
    BEGIN CATCH
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END;
