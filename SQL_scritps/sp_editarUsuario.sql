CREATE PROCEDURE sp_editarUsuario
(
    @IdUsuario       INT,
    @IdRol           INT,
    @NombreCompleto  VARCHAR(50),
    @Correo          VARCHAR(50),
    @NombreUsuario   VARCHAR(50),
    @Clave           VARCHAR(100),
    @ResetearClave   BIT,
    @Activo          BIT,
    @MsjError        VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si el nombre de usuario ya existe en otro registro
    IF EXISTS (SELECT 1 FROM Usuario WHERE NombreUsuario = @NombreUsuario AND IdUsuario != @IdUsuario)
    BEGIN
        SET @MsjError = 'El nombre de usuario ya existe.'
        RETURN
    END 

    -- Actualizar datos del usuario
    UPDATE Usuario
    SET 
        IdRol = @IdRol,
        NombreCompleto = @NombreCompleto,
        Correo = @Correo,
        NombreUsuario = @NombreUsuario,
        Clave = @Clave,
        ResetearClave = @ResetearClave,
        Activo = @Activo
    WHERE IdUsuario = @IdUsuario
END;
GO