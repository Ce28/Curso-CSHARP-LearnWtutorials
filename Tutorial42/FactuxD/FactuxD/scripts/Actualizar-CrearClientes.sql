USE Administracion
GO

CREATE PROCEDURE ActualizaClientes
@Id_cli INT,
@Nom_cli VARCHAR(100),
@Ape_cli VARCHAR(100)
AS

--Actualiza clientes

IF NOT EXISTS (SELECT id_clientes FROM Cliente WHERE id_clientes = @Id_cli)
INSERT INTO Cliente(id_clientes, Nom_cli, Ape_cli) VALUES (@Id_cli, @Nom_cli, @Ape_cli)
ELSE
UPDATE Cliente SET id_clientes = @Id_cli, Nom_cli= @Nom_cli, Ape_cli = @Ape_cli WHERE id_clientes = @Id_cli