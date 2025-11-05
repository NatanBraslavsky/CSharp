Console.Write("Digite a quantidade de Funcionários que deseja cadastrar: ");
int quantidadeFuncionario = int.Parse(Console.ReadLine());

string[] funcionarios = new string[quantidadeFuncionario];

for(int i = 0; i < quantidadeFuncionario; i++){
    Console.Write($"Digite o {i+1}º Funcionário: ");
    funcionarios[i] = Console.ReadLine();
}

Console.WriteLine("\nLista de Funcionários...\n");
for(int i = 0; i < funcionarios.Length; i++){
    Console.WriteLine($"-{funcionarios[i]}");
}

