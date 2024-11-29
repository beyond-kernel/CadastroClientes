CREATE PROCEDURE AddCliente
    @Nome NVARCHAR(100),
    @Email NVARCHAR(100),
    @Logotipo VARBINARY(MAX)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Clientes WHERE Email = @Email)
        THROW 50001, 'E-mail já cadastrado', 1;

    INSERT INTO Clientes (Nome, Email, Logotipo)
    VALUES (@Nome, @Email, @Logotipo);
END