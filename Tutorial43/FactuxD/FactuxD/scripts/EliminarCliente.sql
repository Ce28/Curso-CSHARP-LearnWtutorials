USE Administracion
GO

CREATE PROCEDURE EliminarCliente
@Id_cli INT
AS
DELETE FROM Cliente WHERE id_clientes = @Id_cli