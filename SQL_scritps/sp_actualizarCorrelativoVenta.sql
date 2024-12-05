-- Actualizar Correlativo de Venta
CREATE PROCEDURE sp_actualizarCorrelativoVenta
    @Serie VARCHAR(3),
    @Numero INT,
    @Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    SET @Mensaje = ''
    BEGIN TRY
        UPDATE CorrelativoVenta
        SET Numero = Numero + 1
        WHERE Serie = @Serie AND Numero = @Numero;

        SET @Mensaje = 'Correlativo actualizado correctamente.'
    END TRY
    BEGIN CATCH
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END;


