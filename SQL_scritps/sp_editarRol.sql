CREATE PROCEDURE sp_editarRol
(
    @IdRol     INT,
    @NombreRol VARCHAR(50),
    @MsjError  VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si el nuevo nombre del rol ya existe en otro registro
    IF EXISTS (SELECT 1 FROM Rol WHERE NombreRol = @NombreRol AND IdRol != @IdRol)
    BEGIN
        SET @MsjError = 'El nombre del rol ya existe.'
        RETURN
    END 

    -- Actualizar datos del rol
    UPDATE Rol
    SET 
        NombreRol = @NombreRol
    WHERE IdRol = @IdRol
END;
GO