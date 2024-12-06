create procedure sp_listarMedida
as
begin
 select IdMedida, NomMedida, Abreviatura, Equivalente, Valor from Medida

end