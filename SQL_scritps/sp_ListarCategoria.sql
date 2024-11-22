create procedure sp_listarCategoria
(
@Buscar varchar(50) = ' '
)
as
begin
select
c.IdCategoria,
c.NombreCategoria,
c.Activo,
m.IdMedida,
m.NomMedida
from
Categoria c
inner join Medida m on m.IdMedida = c.IdMedida
where concat (c.NombreCategoria, m.NomMedida, iif(c.Activo=1, 'SI','NO')) like '%' + @Buscar + '%'
end
