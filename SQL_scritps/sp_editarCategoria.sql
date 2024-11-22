--sp_help Categoria -- ver información de columnas y tipos de datos en las tablas
--use dbSist
create procedure sp_editarCategoria
(
@IdCategoria  int,
@NombreCat    varchar(50),
@IdMedida     int,
@Activo		  bit,
@MsjError     varchar(100) output
)
as
begin
  set @MsjError = ''
  if (exists(select * from Categoria where NombreCategoria = @NombreCat and IdCategoria != @IdCategoria))
	begin
		set @MsjError = 'El nombre de la Categoria ya existe.'
	return
	end

	update Categoria set
	NombreCategoria = @NombreCat,
	IdMedida        = @IdMedida,
	Activo			= @Activo
	where IdCategoria = @IdCategoria
end