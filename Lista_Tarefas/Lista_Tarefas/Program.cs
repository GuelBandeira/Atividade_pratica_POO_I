
using Lista_Tarefas.src;

Random random = new Random();

Usuario usuario1 = new Usuario("Pedro Huguenin","143.569.547-00","Dev");
Usuario usuario2 = new Usuario("Katsu","666.666.666-66","Streamer");

Console.WriteLine($"Funcionario: {usuario1.Nome}; CPF: {usuario1.Cpf}, Cargo: {usuario1.Cargo}");
Console.WriteLine($"Funcionario: {usuario2.Nome}; CPF: {usuario2.Cpf}, Cargo: {usuario2.Cargo}");

Tarefa tarefa1 = new Tarefa(random.Next(100), "CSS", "Alterar Navbar", true, usuario1);
Tarefa tarefa2 = new Tarefa(random.Next(100), "Behappy", "Ajustar bug", true, usuario2);

Console.WriteLine($"Numero Tarefa: {tarefa1.NumeroTarefa}; Titulo: {tarefa1.Titulo}, Descrição: {tarefa1.Descricao},Status: {(tarefa1.Status == false ? "Em Progresso" : "Concluida")},Encarregado: {tarefa1.Titular.Nome}");
Console.WriteLine($"Numero Tarefa: {tarefa2.NumeroTarefa}; Titulo: {tarefa2.Titulo}, Descrição: {tarefa2.Descricao},Status: {(tarefa2.Status == false ? "Em Progresso" : "Concluida")},Encarregado: {tarefa2.Titular.Nome}");

Console.WriteLine($"Numero de tarfeas concluídas: {tarefa1.Concluidas}");

