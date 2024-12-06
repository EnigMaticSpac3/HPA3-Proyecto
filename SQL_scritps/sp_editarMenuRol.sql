CREATE PROCEDURE sp_editarMenuRol
(
    @IdMenuRol INT,
    @IdMenu    INT,
    @IdRol     INT,
    @Activo    BIT,
    @MsjError  VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si la nueva relacion ya existe en otro registro
    IF EXISTS (SELECT 1 FROM MenuRol WHERE IdMenu = @IdMenu AND IdRol = @IdRol AND IdMenuRol != @IdMenuRol)
    BEGIN
        SET @MsjError = 'La relacion entre el menu y el rol ya existe.'
        RETURN
    END 

    -- Actualizar la relacion MenuRol
    UPDATE MenuRol
    SET 
        IdMenu = @IdMenu,
        IdRol = @IdRol,
        Activo = @Activo
    WHERE IdMenuRol = @IdMenuRol
END;
GO