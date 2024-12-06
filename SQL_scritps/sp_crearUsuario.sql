CREATE PROCEDURE sp_crearUsuario
(
    @IdRol           INT,
    @NombreCompleto  VARCHAR(50),
    @Correo          VARCHAR(50),
    @NombreUsuario   VARCHAR(50),
    @Clave           VARCHAR(100),
    @MsjError        VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si el nombre de usuario ya existe
    IF EXISTS (SELECT 1 FROM Usuario WHERE NombreUsuario = @NombreUsuario)
    BEGIN
        SET @MsjError = 'El nombre de usuario ya existe.'
        RETURN
    END 

    -- Insertar nuevo usuario
    INSERT INTO Usuario (IdRol, NombreCompleto, Correo, NombreUsuario, Clave, ResetearClave, Activo)
    VALUES (@IdRol, @NombreCompleto, @Correo, @NombreUsuario, @Clave, 1, 1)
END;
GO