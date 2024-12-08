CREATE PROCEDURE sp_obtenerCategorias
AS
BEGIN
    SELECT 
        IdCategoria,
        NombreCategoria,
        IdMedida,
        Activo
    FROM Categoria
    WHERE Activo = 1;
END;
