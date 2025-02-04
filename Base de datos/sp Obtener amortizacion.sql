CREATE OR ALTER PROCEDURE sp_ObtenerAmortizacion
    @PrestamoID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Amortizacion WHERE PrestamoID = @PrestamoID ORDER BY NumeroCuota;
END;
GO
