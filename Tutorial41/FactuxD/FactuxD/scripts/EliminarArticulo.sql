USE Administracion
GO

CREATE PROCEDURE EliminarArticulos
@Id_pro INT
AS
DELETE FROM Articulo WHERE id_pro = @Id_pro