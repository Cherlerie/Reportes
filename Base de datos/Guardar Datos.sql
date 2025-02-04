USE Prestamosdatabase;
GO

------------------------------------------
-- 1. Insertar registros en la tabla Cliente
------------------------------------------
-- Se insertan 10 clientes, algunos de los cuales serán "Cliente" y otros "Administrador".
INSERT INTO Cliente (Nombre, Apellido, Correo, Telefono, Direccion, Usuario, Contraseña, Rol, Sueldo, Garantia)
VALUES 
('Juan', 'Pérez', 'juan.perez@mail.com', '555-1111', 'Av. Siempre Viva 123', 'juanp', 'pass123', 'Cliente', 10000, 'Casa'),
('María', 'López', 'maria.lopez@mail.com', '555-2222', 'Calle Falsa 456', 'marial', 'pass456', 'Cliente', 15000, 'Auto'),
('Carlos', 'Gómez', 'carlos.gomez@mail.com', '555-3333', 'Av. Libertad 789', 'carlosg', 'pass789', 'Cliente', 12000, 'Departamento'),
('Ana', 'Martínez', 'ana.martinez@mail.com', '555-4444', 'Calle 10 1010', 'anam', 'pass1010', 'Cliente', 8000, 'Terreno'),
('Luis', 'Rodríguez', 'luis.rodriguez@mail.com', '555-5555', 'Av. Central 2020', 'luisr', 'pass2020', 'Cliente', 20000, 'Casa'),
('Sofía', 'Hernández', 'sofia.hernandez@mail.com', '555-6666', 'Calle Luna 3030', 'sofia', 'pass3030', 'Cliente', 9000, 'Auto'),
('Miguel', 'Sánchez', 'miguel.sanchez@mail.com', '555-7777', 'Av. Sol 4040', 'miguels', 'pass4040', 'Administrador', 25000, 'Oficina'),
('Laura', 'Ramírez', 'laura.ramirez@mail.com', '555-8888', 'Calle Estrella 5050', 'laurar', 'pass5050', 'Cliente', 11000, 'Departamento'),
('Pedro', 'García', 'pedro.garcia@mail.com', '555-9999', 'Av. Pacifico 6060', 'pedrog', 'pass6060', 'Cliente', 13000, 'Casa'),
('Lucía', 'Torres', 'lucia.torres@mail.com', '555-0000', 'Calle Jardín 7070', 'luciatt', 'pass7070', 'Cliente', 14000, 'Terreno');
GO

------------------------------------------
-- 2. Insertar registros en la tabla Prestamo
------------------------------------------
-- Se asignan préstamos a varios clientes (un cliente puede tener más de uno)
-- Las tasas de interés y cálculos reales se manejarán en la lógica de negocio, aquí se insertan valores de ejemplo.
INSERT INTO Prestamo (ClienteID, MontoPrestamo, TiempoMeses, InteresGenerado, MontoTotal, MontoPendiente, FechaInicio, ProximaFechaPago)
VALUES 
(1, 5000, 6, 200, 5200, 5200, '2025-01-01', '2025-02-01'),
(1, 3000, 3, 150, 3150, 3150, '2025-03-01', '2025-04-01'),
(2, 10000, 12, 700, 10700, 10700, '2025-01-15', '2025-02-15'),
(3, 8000, 6, 320, 8320, 8320, '2025-02-01', '2025-03-01'),
(4, 2000, 3, 80, 2080, 2080, '2025-01-20', '2025-02-20'),
(5, 15000, 12, 1050, 16050, 16050, '2025-01-10', '2025-02-10'),
(6, 4000, 4, 240, 4240, 4240, '2025-02-05', '2025-03-05'),
(7, 25000, 12, 1750, 26750, 26750, '2025-01-05', '2025-02-05'),
(8, 6000, 6, 240, 6240, 6240, '2025-03-10', '2025-04-10'),
(9, 7000, 6, 280, 7280, 7280, '2025-02-15', '2025-03-15'),
(10, 5000, 3, 200, 5200, 5200, '2025-03-01', '2025-04-01');
GO

------------------------------------------
-- 3. Insertar registros en la tabla Pagos
------------------------------------------
-- Se insertan pagos de ejemplo para algunos préstamos.
-- Nota: Los valores son de ejemplo; en una aplicación real se calcularían en base a la amortización.
INSERT INTO Pagos (ClienteID, PrestamoID, MontoAnterior, InteresPagado, InteresAPagar, MontoAbonado, MontoPendiente, FechaPago)
VALUES
(1, 1, 5200, 200, 200, 5200, 0, '2025-02-01'),
(1, 2, 3150, 150, 150, 3150, 0, '2025-04-01'),
(2, 3, 10700, 700, 700, 3000, 7700, '2025-02-15'),
(2, 3, 7700, 500, 500, 2000, 5700, '2025-03-15'),
(5, 6, 4240, 240, 240, 4240, 0, '2025-03-05'),
(7, 8, 26750, 1750, 1750, 10000, 16750, '2025-02-05'),
(8, 9, 6240, 240, 240, 6240, 0, '2025-04-10'),
(9, 10, 7280, 280, 280, 7280, 0, '2025-03-15');
GO

------------------------------------------
-- 4. Insertar registros en la tabla Amortizacion
------------------------------------------
-- Para cada préstamo, se insertan filas de amortización.
-- Se insertarán 3 filas para préstamos de 3 meses, 6 filas para 6 meses, etc.
-- Aquí se insertan ejemplos para algunos préstamos. Ajusta según la lógica real.
-- Ejemplo para PrestamoID = 1 (6 meses)
INSERT INTO Amortizacion (PrestamoID, NumeroCuota, Cuota, Interes, AmortizacionCapital, SaldoPendiente, FechaCuota)
VALUES 
(1, 1, 867, 87, 780, 4420, DATEADD(MONTH, 1, '2025-01-01')),
(1, 2, 867, 78, 789, 3631, DATEADD(MONTH, 2, '2025-01-01')),
(1, 3, 867, 66, 801, 2830, DATEADD(MONTH, 3, '2025-01-01')),
(1, 4, 867, 57, 810, 2020, DATEADD(MONTH, 4, '2025-01-01')),
(1, 5, 867, 45, 822, 1198, DATEADD(MONTH, 5, '2025-01-01')),
(1, 6, 867, 34, 833, 0, DATEADD(MONTH, 6, '2025-01-01'));

-- Ejemplo para PrestamoID = 3 (12 meses)
INSERT INTO Amortizacion (PrestamoID, NumeroCuota, Cuota, Interes, AmortizacionCapital, SaldoPendiente, FechaCuota)
VALUES 
(3, 1, 892, 89, 803, 9700, DATEADD(MONTH, 1, '2025-01-15')),
(3, 2, 892, 81, 811, 8889, DATEADD(MONTH, 2, '2025-01-15')),
(3, 3, 892, 74, 818, 8071, DATEADD(MONTH, 3, '2025-01-15')),
(3, 4, 892, 67, 825, 7246, DATEADD(MONTH, 4, '2025-01-15')),
(3, 5, 892, 60, 832, 6414, DATEADD(MONTH, 5, '2025-01-15')),
(3, 6, 892, 54, 838, 5576, DATEADD(MONTH, 6, '2025-01-15')),
(3, 7, 892, 47, 845, 4731, DATEADD(MONTH, 7, '2025-01-15')),
(3, 8, 892, 41, 851, 3880, DATEADD(MONTH, 8, '2025-01-15')),
(3, 9, 892, 35, 857, 3023, DATEADD(MONTH, 9, '2025-01-15')),
(3, 10, 892, 29, 863, 2160, DATEADD(MONTH, 10, '2025-01-15')),
(3, 11, 892, 24, 868, 1292, DATEADD(MONTH, 11, '2025-01-15')),
(3, 12, 892, 18, 874, 418, DATEADD(MONTH, 12, '2025-01-15'));
GO

------------------------------------------
-- 5. Insertar registros en la tabla Moras
------------------------------------------
-- Se insertan registros de mora para algunos clientes.
INSERT INTO Moras (ClienteID, CantidadMoras)
VALUES 
(1, 0),
(2, 1),
(3, 0),
(4, 2),
(5, 0),
(6, 1),
(7, 3),  -- Este cliente acumula 3 moras
(8, 0),
(9, 2),
(10, 0);
GO

------------------------------------------
-- 6. Insertar registro en la tabla Fondo
------------------------------------------
-- La tabla Fondo ya tiene un DEFAULT, pero se puede insertar un registro para asegurarse.
INSERT INTO Fondo (MontoDisponible)
VALUES (5000000);
GO
