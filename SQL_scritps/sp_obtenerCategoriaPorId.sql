create procedure sp_obtenerCategoriaPorId
(
@IdCategoria int
)
as
begin
    select IdCategoria, NombreCategoria, IdMedida, Activo
    from Categoria
    where IdCategoria = @IdCategoria
end
