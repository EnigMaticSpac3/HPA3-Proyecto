CREATE PROCEDURE sp_listaProducto
    @Buscar VARCHAR(50) = ''
AS
BEGIN
    SELECT p.IdProducto, p.Codigo, p.Descripcion, p.PrecioCompra, p.PrecioVenta, 
           p.Cantidad, p.IdCategoria, p.Activo, c.NombreCategoria
    FROM Producto p
    INNER JOIN Categoria c ON p.IdCategoria = c.IdCategoria
    WHERE p.Descripcion LIKE '%' + @Buscar + '%';
END;
