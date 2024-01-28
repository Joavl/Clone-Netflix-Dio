use Corporativo
go
CREATE TABLE Tarefas
(
	IdTarefa INT NOT NULL,
	NomeTarefa VARCHAR(30),
	Descricao VARCHAR(400),
	DataTarefa datetime,
	Prioridade int,
	Responsavel VARCHAR(20)
)