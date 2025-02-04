CREATE OR ALTER PROCEDURE sp_login
    @Usuario NVARCHAR(50),
    @Contrase�a NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ClienteID, Rol, Usuario, Contrase�a
    FROM Cliente
    WHERE Usuario = @Usuario AND Contrase�a = @Contrase�a;
END;
GO
