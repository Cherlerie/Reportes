CREATE OR ALTER PROCEDURE sp_RegistrarPago
    @ClienteID INT,
    @PrestamoID INT,
    @MontoPago DECIMAL(15,2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @MontoPendiente DECIMAL(15,2);
    DECLARE @MontoTotal DECIMAL(15,2);
    DECLARE @InteresAPagar DECIMAL(15,2);
    DECLARE @FechaProximoPago DATE;
    DECLARE @Mora DECIMAL(15,2);
    DECLARE @PagoCalculado DECIMAL(15,2);

    -- Obtener la información actual del préstamo
    SELECT 
        @MontoPendiente = MontoPendiente, 
        @MontoTotal = MontoTotal, 
        @InteresAPagar = InteresGenerado,
        @FechaProximoPago = ProximaFechaPago
    FROM Prestamo
    WHERE PrestamoID = @PrestamoID;

    -- Si el pago se realiza después de la fecha de pago, se calcula una mora del 10% del monto total a pagar
    IF (GETDATE() > @FechaProximoPago)
        SET @Mora = @MontoTotal * 0.10;
    ELSE
        SET @Mora = 0;

    SET @PagoCalculado = @MontoPago + @Mora;

    -- Insertar el registro del pago
    INSERT INTO Pagos 
       (ClienteID, PrestamoID, MontoAnterior, InteresPagado, InteresAPagar, MontoAbonado, MontoPendiente, FechaPago)
    VALUES 
       (@ClienteID, @PrestamoID, @MontoPendiente, @InteresAPagar, @InteresAPagar, @PagoCalculado, (@MontoPendiente - @PagoCalculado), GETDATE());

    -- Actualizar el monto pendiente del préstamo
    UPDATE Prestamo
    SET MontoPendiente = MontoPendiente - @PagoCalculado
    WHERE PrestamoID = @PrestamoID;

    SELECT 1 AS Resultado;  -- Retorna 1 si fue exitoso
END;
GO
