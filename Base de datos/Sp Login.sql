CREATE OR ALTER PROCEDURE sp_login
    @Usuario NVARCHAR(50),
    @Contraseņa NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ClienteID, Rol, Usuario, Contraseņa
    FROM Cliente
    WHERE Usuario = @Usuario AND Contraseņa = @Contraseņa;
END;
GO
