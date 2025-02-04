CREATE OR ALTER PROCEDURE sp_login
    @Usuario NVARCHAR(50),
    @Contraseña NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ClienteID, Rol, Usuario, Contraseña
    FROM Cliente
    WHERE Usuario = @Usuario AND Contraseña = @Contraseña;
END;
GO
