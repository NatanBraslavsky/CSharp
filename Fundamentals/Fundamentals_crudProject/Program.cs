Dictionary<string, List<float>> listaAlunos = new Dictionary<string, List<float>>();

menuPrincipal();

void menuPrincipal()
{
    exibirTituloInicio("Sistema de cadastro de Alunos");
    Console.WriteLine(@"
1 - Cadastrar Alunos
2 - Listar Alunos
3 - Dar Nota ao Aluno
4 - Exibir Média do aluno
5 - Sair
    ");

    Console.Write("Selecione a opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            CadastrarAluno();
            break;
        case 2:
            ExibirAlunos();
            break;
        case 3:
            AvaliarAluno();
            break;
        case 4:
            ExibirMedia();
            break;
        case 5:
            Console.WriteLine("Encerrando o programa...");
            Thread.Sleep(1000);
            return;
        default:
            Console.WriteLine("Opção ainda não desenvolvida...");
            Thread.Sleep(1000);
            menuPrincipal();
            break;
    }
}

void CadastrarAluno()
{
    Console.Clear();
    exibirTituloInicio("Cadastro de aluno");

    Console.Write("Digite o nome do aluno: ");
    string aluno = Console.ReadLine()!;
    listaAlunos.Add(aluno, new List<float>());

    Console.WriteLine($"Aluno {aluno} cadastrado com sucesso...");
    Thread.Sleep(1000);
    Console.Clear();
    menuPrincipal();
}

void ExibirAlunos()
{
    Console.Clear();
    exibirTituloInicio("Exibição de alunos");
    if (listaAlunos.Count == 0)
    {
        Console.WriteLine("Nenhum aluno registrado...");
    }
    foreach (string aluno in listaAlunos.Keys)
    {
        Console.WriteLine($"-{aluno}");
    }
    Console.Write("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
    Console.Clear();
    menuPrincipal();
}

void AvaliarAluno()
{
    exibirTituloInicio("Avaliar aluno");
    Console.Write("Digite o aluno que deseja avaliar: ");
    string nomeAlunoAvaliar = Console.ReadLine()!;
    if (listaAlunos.ContainsKey(nomeAlunoAvaliar))
    {
        Console.Write($"Digite a nota que deseja para o aluno {nomeAlunoAvaliar}: ");
        float notaAluno = float.Parse(Console.ReadLine()!);
        listaAlunos[nomeAlunoAvaliar].Add(notaAluno);
        Console.WriteLine("Nota adicionada com sucesso...");
        Thread.Sleep(2000);
        Console.Clear();
        menuPrincipal();
    }
    else
    {
        Console.WriteLine("Aluno não encontrado...");
        Console.Write("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
        menuPrincipal();
    }
}

void ExibirMedia()
{
    Console.WriteLine("Selecione o aluno que deseja ver a média: ");
    string aluno = Console.ReadLine()!;

    if (listaAlunos.ContainsKey(aluno))
    {
        List<float> notas = listaAlunos[aluno];
        
        float soma = 0;
        float media = 0;

        Console.WriteLine($"Notas do aluno {aluno}:");
        foreach (float nota in notas)
        {
            soma += nota;
            Console.Write($"| {nota} ");
        }

        media = soma / notas.Count();
        Console.Write($"\nMedia: {media:F2}\n");

        Console.Write("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        Console.Clear();
        menuPrincipal();
    }

}

void exibirTituloInicio(string titulo)
{
    Console.Clear();
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos);
}