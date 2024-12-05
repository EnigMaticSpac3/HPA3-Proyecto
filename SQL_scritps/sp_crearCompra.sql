CREATE PROCEDURE sp_crearCompra
(
    @NumeroVenta      VARCHAR(10),
    @IdUsuarioRegistro INT,
    @NombreCliente    VARCHAR(60),
    @PrecioTotal      DECIMAL(10,2),
    @PagoCon          DECIMAL(10,2),
    @Cambio           DECIMAL(10,2),
    @MsjError         VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si el numero de venta ya existe
    IF EXISTS (SELECT 1 FROM Venta WHERE NumeroVenta = @NumeroVenta)
    BEGIN
        SET @MsjError = 'El numero de venta ya existe.'
        RETURN
    END 

    -- Insertar nueva compra
    INSERT INTO Venta (NumeroVenta, IdUsuarioRegistro, NombreCliente, PrecioTotal, PagoCon, Cambio)
    VALUES (@NumeroVenta, @IdUsuarioRegistro, @NombreCliente, @PrecioTotal, @PagoCon, @Cambio)
END;
GO