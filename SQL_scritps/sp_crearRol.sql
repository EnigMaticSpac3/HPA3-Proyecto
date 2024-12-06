CREATE PROCEDURE sp_crearRol
(
    @NombreRol VARCHAR(50),
    @MsjError  VARCHAR(100) OUTPUT
)
AS
BEGIN
    SET @MsjError = '' 

    -- Validar si el nombre del rol ya existe
    IF EXISTS (SELECT 1 FROM Rol WHERE NombreRol = @NombreRol)
    BEGIN
        SET @MsjError = 'El nombre del rol ya existe.'
        RETURN
    END 

    -- Insertar nuevo rol
    INSERT INTO Rol (NombreRol)
    VALUES (@NombreRol)
END;
GO