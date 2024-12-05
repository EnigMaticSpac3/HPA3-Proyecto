-- Obtener Correlativo Actual
CREATE PROCEDURE sp_obtenerCorrelativoVenta
AS
BEGIN
    SELECT Serie, Numero, Activo
    FROM CorrelativoVenta
    WHERE Activo = 1;
END;