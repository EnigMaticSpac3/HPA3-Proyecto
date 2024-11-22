--sp_help Categoria -- ver informacion de columnas y tipos de datos en las tabla, para asignarlos en los parametros a recibir.

create procedure sp_crearCategoria
(
@NombreCat varchar(50),
@IdMedida  int,
@MsError   varchar(100) output
)

as
begin
	set @MsError = ''

	if (exists(select * from Categoria where NombreCategoria = @NombreCat))
	begin
		set @MsError = 'El nombre de la Categoria ya existe.'
	return
	end

	insert into Categoria (NombreCategoria, IdMedida)
		values(@NombreCat, @IdMedida)

end