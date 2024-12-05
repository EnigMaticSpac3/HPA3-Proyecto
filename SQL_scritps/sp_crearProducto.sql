-- Insertar Producto
CREATE PROCEDURE sp_crearProducto
    @Codigo VARCHAR(50),
    @Descripcion VARCHAR(150),
    @PrecioCompra DECIMAL(10,2),
    @PrecioVenta DECIMAL(10,2),
    @Cantidad INT,
    @IdCategoria INT,
    @Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    SET @Mensaje = ''
    IF EXISTS (SELECT 1 FROM Producto WHERE Codigo = @Codigo)
    BEGIN
        SET @Mensaje = 'El producto ya existe.'
        RETURN
    END

    INSERT INTO Producto (Codigo, Descripcion, PrecioCompra, PrecioVenta, Cantidad, IdCategoria, Activo)
    VALUES (@Codigo, @Descripcion, @PrecioCompra, @PrecioVenta, @Cantidad, @IdCategoria, 1);

    SET @Mensaje = 'Producto creado correctamente.'
END;

