CREATE PROCEDURE sp_crearMenuRol
(
    @IdMenu   INT,
    @IdRol    INT,
    @MsjError VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si ya existe la relacion entre Menu y Rol
    IF EXISTS (SELECT 1 FROM MenuRol WHERE IdMenu = @IdMenu AND IdRol = @IdRol)
    BEGIN
        SET @MsjError = 'La relacion entre el menu y el rol ya existe.'
        RETURN
    END 

    -- Insertar nueva relacion MenuRol
    INSERT INTO MenuRol (IdMenu, IdRol, Activo)
    VALUES (@IdMenu, @IdRol, 1)
END;
GO