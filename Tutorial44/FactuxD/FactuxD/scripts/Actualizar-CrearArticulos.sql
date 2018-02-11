USE Administracion
GO

CREATE PROCEDURE ActualizaArticulos
@Id_pro INT,
@Nom_pro VARCHAR(100),
@Precio FLOAT
AS

--Actualiza articulos

IF NOT EXISTS (SELECT Id_pro FROM Articulo WHERE id_pro = @Id_pro)
INSERT INTO Articulo (id_pro, Nom_pro, Precio) VALUES (@Id_pro, @Nom_pro, @Precio)
ELSE
UPDATE Articulo SET id_pro = @Id_pro, Nom_pro= @Nom_pro, Precio = @Precio