CREATE PROCEDURE sp_listarMenuRol
(
    @Buscar VARCHAR(50) = ' '
)
AS
BEGIN
    SELECT 
        mr.IdMenuRol,
        mr.Activo,
        r.IdRol,
        r.NombreRol,
        m.IdMenu,
        m.NombreMenu
    FROM 
        MenuRol mr
        INNER JOIN Rol r ON mr.IdRol = r.IdRol
        INNER JOIN Menu m ON mr.IdMenu = m.IdMenu
    WHERE 
        CONCAT(r.NombreRol, m.NombreMenu, 
               CASE WHEN mr.Activo = 1 THEN 'SI' ELSE 'NO' END) LIKE '%' + @Buscar + '%'
END;
GO