-- Actualizar Producto
CREATE PROCEDURE sp_editarProducto
    @IdProducto INT,
    @Codigo VARCHAR(50),
    @Descripcion VARCHAR(150),
    @PrecioCompra DECIMAL(10,2),
    @PrecioVenta DECIMAL(10,2),
    @Cantidad INT,
    @IdCategoria INT,
    @Activo BIT,
    @Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    SET @Mensaje = ''
    IF EXISTS (SELECT 1 FROM Producto WHERE Codigo = @Codigo AND IdProducto != @IdProducto)
    BEGIN
        SET @Mensaje = 'El producto ya existe.'
        RETURN
    END

    UPDATE Producto
    SET Codigo = @Codigo,
        Descripcion = @Descripcion,
        PrecioCompra = @PrecioCompra,
        PrecioVenta = @PrecioVenta,
        Cantidad = @Cantidad,
        IdCategoria = @IdCategoria,
        Activo = @Activo
    WHERE IdProducto = @IdProducto;

    SET @Mensaje = 'Producto actualizado correctamente.'
END;
