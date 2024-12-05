CREATE PROCEDURE sp_listarRol
(
    @Buscar VARCHAR(50) = ' '
)
AS
BEGIN
    SELECT 
        r.IdRol,
        r.NombreRol
    FROM Rol r
   WHERE 
        r.NombreRol LIKE '%' + @Buscar + '%'
END;
GO