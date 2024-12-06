CREATE PROCEDURE sp_listarUsuario
(
    @Buscar VARCHAR(50) = ' '
)
AS
BEGIN
    SELECT 
        u.IdUsuario,
        u.NombreCompleto,
        u.Correo,
        u.NombreUsuario,
        u.ResetearClave,
        u.Activo,
        r.IdRol,
        r.NombreRol
    FROM 
        Usuario u
        INNER JOIN Rol r ON u.IdRol = r.IdRol
    WHERE 
        CONCAT(u.NombreCompleto, u.Correo, u.NombreUsuario, r.NombreRol, 
               CASE WHEN u.Activo = 1 THEN 'SI' ELSE 'NO' END) LIKE '%' + @Buscar + '%'
END;
GO