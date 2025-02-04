-- 1.1 Crear la base de datos
CREATE DATABASE Prestamosdatabase;
GO

USE Prestamosdatabase;
GO

-- 1.2 Tabla Cliente  
-- Contiene la informaci�n de los clientes (incluye datos para login, informaci�n personal, sueldo y garant�a)
CREATE TABLE Cliente (
    ClienteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NULL,
    Direccion NVARCHAR(200) NULL,
    Usuario NVARCHAR(50) NOT NULL,
    Contrase�a NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(20) NOT NULL,         -- Ejemplo: "Cliente" o "Administrador"
    Sueldo DECIMAL(15,2) NOT NULL,       -- Para la regla de pr�stamo (m�ximo 4 veces el sueldo)
    Garantia NVARCHAR(100) NOT NULL      -- Objeto ofrecido como garant�a
);
GO

-- 1.3 Tabla Prestamo  
-- Registra la informaci�n de cada pr�stamo
CREATE TABLE Prestamo (
    PrestamoID INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT NOT NULL,
    MontoPrestamo DECIMAL(15,2) NOT NULL,   -- Capital adquirido
    TiempoMeses INT NOT NULL,               -- Plazo del pr�stamo en meses
    InteresGenerado DECIMAL(15,2) NOT NULL,   -- Inter�s calculado para el pr�stamo
    MontoTotal DECIMAL(15,2) NOT NULL,        -- MontoTotal = MontoPrestamo + InteresGenerado
    MontoPendiente DECIMAL(15,2) NOT NULL,    -- Monto a�n por pagar
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
    InteresPagado DECIMAL(15,2) NOT NULL,   -- Inter�s pagado en este abono
    InteresAPagar DECIMAL(15,2) NOT NULL,   -- Inter�s que se deb�a pagar
    MontoAbonado DECIMAL(15,2) NOT NULL,      -- Monto efectivamente abonado (incluyendo mora, si se aplica)
    MontoPendiente DECIMAL(15,2) NOT NULL,    -- Nuevo saldo pendiente
    FechaPago DATE NOT NULL,
    CONSTRAINT FK_Pagos_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    CONSTRAINT FK_Pagos_Prestamo FOREIGN KEY (PrestamoID) REFERENCES Prestamo(PrestamoID)
);
GO

-- 1.5 Tabla Amortizacion  
-- Genera la tabla de amortizaci�n (cuotas fijas) para cada pr�stamo
CREATE TABLE Amortizacion (
    AmortizacionID INT IDENTITY(1,1) PRIMARY KEY,
    PrestamoID INT NOT NULL,
    NumeroCuota INT NOT NULL,
    Cuota DECIMAL(15,2) NOT NULL,            -- Cuota mensual calculada
    Interes DECIMAL(15,2) NOT NULL,            -- Inter�s de la cuota
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
-- Contiene el fondo base para pr�stamos (por defecto 5 millones)
CREATE TABLE Fondo (
    FondoID INT IDENTITY(1,1) PRIMARY KEY,
    MontoDisponible DECIMAL(15,2) NOT NULL DEFAULT 5000000
);
GO

-- 1.8 Trigger para Fondos  
-- Al insertar un pr�stamo, se descuenta el monto del fondo. Se evita prestar m�s dinero del que se posee.
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
