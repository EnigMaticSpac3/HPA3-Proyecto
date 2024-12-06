CREATE PROCEDURE sp_editarCompra
(
    @IdVenta          INT,
    @NumeroVenta      VARCHAR(10),
    @IdUsuarioRegistro INT,
    @NombreCliente    VARCHAR(60),
    @PrecioTotal      DECIMAL(10,2),
    @PagoCon          DECIMAL(10,2),
    @Cambio           DECIMAL(10,2),
    @Activo           BIT,
    @MsjError         VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si el numero de venta ya existe en otro registro
    IF EXISTS (SELECT 1 FROM Venta WHERE NumeroVenta = @NumeroVenta AND IdVenta != @IdVenta)
    BEGIN
        SET @MsjError = 'El numero de venta ya existe.'
        RETURN
    END 

    -- Actualizar datos de la compra
    UPDATE Venta
    SET 
        NumeroVenta = @NumeroVenta,
        IdUsuarioRegistro = @IdUsuarioRegistro,
        NombreCliente = @NombreCliente,
        PrecioTotal = @PrecioTotal,
        PagoCon = @PagoCon,
        Cambio = @Cambio,
        Activo = @Activo
    WHERE IdVenta = @IdVenta
END;
GO