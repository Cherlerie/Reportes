CREATE OR ALTER PROCEDURE sp_CalcularAmortizacion
    @PrestamoID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @P DECIMAL(15,2), @n INT, @i DECIMAL(15,5), @M DECIMAL(15,2);
    DECLARE @saldo DECIMAL(15,2);
    DECLARE @cuota INT = 1;

    -- Obtener datos del préstamo
    SELECT @P = MontoPrestamo, @n = TiempoMeses, @saldo = MontoPrestamo
    FROM Prestamo
    WHERE PrestamoID = @PrestamoID;

    -- Determinar la tasa mensual según el plazo
    IF (@n BETWEEN 1 AND 3)
        SET @i = 0.10/12;
    ELSE IF (@n BETWEEN 4 AND 6)
        SET @i = 0.08/12;
    ELSE IF (@n BETWEEN 7 AND 12)
        SET @i = 0.07/12;
    ELSE
        SET @i = 0.05/12;

    -- Calcular la cuota fija M = P * (i*(1+i)^n)/((1+i)^n - 1)
    SET @M = @P * ((@i * POWER(1 + @i, @n)) / (POWER(1 + @i, @n) - 1));

    -- Borrar amortizaciones previas para este préstamo
    DELETE FROM Amortizacion WHERE PrestamoID = @PrestamoID;

    WHILE @cuota <= @n
    BEGIN
        DECLARE @interes DECIMAL(15,2) = @saldo * @i;
        DECLARE @amortizacion DECIMAL(15,2) = @M - @interes;
        SET @saldo = @saldo - @amortizacion;

        INSERT INTO Amortizacion (PrestamoID, NumeroCuota, Cuota, Interes, AmortizacionCapital, SaldoPendiente, FechaCuota)
        VALUES (@PrestamoID, @cuota, @M, @interes, @amortizacion, CASE WHEN @saldo < 0 THEN 0 ELSE @saldo END, DATEADD(MONTH, @cuota, GETDATE()));

        SET @cuota = @cuota + 1;
    END;

    SELECT * FROM Amortizacion WHERE PrestamoID = @PrestamoID ORDER BY NumeroCuota;
END;
GO
