-- 1.1 Crear la base de datos
CREATE DATABASE Prestamosdatabase;
GO

USE Prestamosdatabase;
GO

-- 1.2 Tabla Cliente  
-- Contiene la información de los clientes (incluye datos para login, información personal, sueldo y garantía)
CREATE TABLE Cliente (
    ClienteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NULL,
    Direccion NVARCHAR(200) NULL,
    Usuario NVARCHAR(50) NOT NULL,
    Contraseña NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(20) NOT NULL,         -- Ejemplo: "Cliente" o "Administrador"
    Sueldo DECIMAL(15,2) NOT NULL,       -- Para la regla de préstamo (máximo 4 veces el sueldo)
    Garantia NVARCHAR(100) NOT NULL      -- Objeto ofrecido como garantía
);
GO

-- 1.3 Tabla Prestamo  
-- Registra la información de cada préstamo
CREATE TABLE Prestamo (
    PrestamoID INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT NOT NULL,
    MontoPrestamo DECIMAL(15,2) NOT NULL,   -- Capital adquirido
    TiempoMeses INT NOT NULL,               -- Plazo del préstamo en meses
    InteresGenerado DECIMAL(15,2) NOT NULL,   -- Interés calculado para el préstamo
    MontoTotal DECIMAL(15,2) NOT NULL,        -- MontoTotal = MontoPrestamo + InteresGenerado
    MontoPendiente DECIMAL(15,2) NOT NULL,    -- Monto aún por pagar
    FechaInicio DATE NOT NULL,
    ProximaFechaPago DATE NOT NULL,
    CONSTRAINT FK_Prestamo_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID)
);
GO

-- 1.4 Tabla Pagos  
-- Registra cada pago realizado
CREATE TABLE Pagos (
    PagoID INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT NOT NULL,
    PrestamoID INT NOT NULL,
    MontoAnterior DECIMAL(15,2) NOT NULL,  -- Saldo antes del pago
    InteresPagado DECIMAL(15,2) NOT NULL,   -- Interés pagado en este abono
    InteresAPagar DECIMAL(15,2) NOT NULL,   -- Interés que se debía pagar
    MontoAbonado DECIMAL(15,2) NOT NULL,      -- Monto efectivamente abonado (incluyendo mora, si se aplica)
    MontoPendiente DECIMAL(15,2) NOT NULL,    -- Nuevo saldo pendiente
    FechaPago DATE NOT NULL,
    CONSTRAINT FK_Pagos_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    CONSTRAINT FK_Pagos_Prestamo FOREIGN KEY (PrestamoID) REFERENCES Prestamo(PrestamoID)
);
GO

-- 1.5 Tabla Amortizacion  
-- Genera la tabla de amortización (cuotas fijas) para cada préstamo
CREATE TABLE Amortizacion (
    AmortizacionID INT IDENTITY(1,1) PRIMARY KEY,
    PrestamoID INT NOT NULL,
    NumeroCuota INT NOT NULL,
    Cuota DECIMAL(15,2) NOT NULL,            -- Cuota mensual calculada
    Interes DECIMAL(15,2) NOT NULL,            -- Interés de la cuota
    AmortizacionCapital DECIMAL(15,2) NOT NULL,  -- Parte de la cuota destinada a amortizar el capital
    SaldoPendiente DECIMAL(15,2) NOT NULL,      -- Saldo pendiente tras la cuota
    FechaCuota DATE NOT NULL,                  -- Fecha de vencimiento de la cuota
    CONSTRAINT FK_Amortizacion_Prestamo FOREIGN KEY (PrestamoID) REFERENCES Prestamo(PrestamoID)
);
GO

-- 1.6 Tabla Moras  
-- Registra la cantidad de moras acumuladas por cada cliente
CREATE TABLE Moras (
    MoraID INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT NOT NULL,
    CantidadMoras INT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Moras_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID)
);
GO

-- 1.7 Tabla Fondo  
-- Contiene el fondo base para préstamos (por defecto 5 millones)
CREATE TABLE Fondo (
    FondoID INT IDENTITY(1,1) PRIMARY KEY,
    MontoDisponible DECIMAL(15,2) NOT NULL DEFAULT 5000000
);
GO

-- 1.8 Trigger para Fondos  
-- Al insertar un préstamo, se descuenta el monto del fondo. Se evita prestar más dinero del que se posee.
CREATE TRIGGER trg_Prestamo_Fondo
ON Prestamo
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @MontoPrestamo DECIMAL(15,2);
    SELECT @MontoPrestamo = SUM(MontoPrestamo) FROM inserted;
    
    DECLARE @FondoActual DECIMAL(15,2);
    SELECT @FondoActual = MontoDisponible FROM Fondo WHERE FondoID = 1;
    
    IF (@MontoPrestamo > @FondoActual)
    BEGIN
        RAISERROR('No hay fondos suficientes para prestar este monto.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        UPDATE Fondo
        SET MontoDisponible = MontoDisponible - @MontoPrestamo
        WHERE FondoID = 1;
    END
END;
GO
