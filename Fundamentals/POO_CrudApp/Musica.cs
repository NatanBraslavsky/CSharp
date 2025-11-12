class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoBanda { get 
        {
            return $"A banda {Nome} pertence à {Artista}";
        } 
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine(DescricaoBanda);
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível nas plataformas de streaming.");
        }
        else
        {
            Console.WriteLine("Indisponível nas plataformas de streaming.");
        }
    }
}
