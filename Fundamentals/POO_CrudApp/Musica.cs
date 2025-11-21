class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get;}
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero genero { get; set; }
    public string DescricaoBanda { get 
        {
            return $"A banda {Nome} pertence à {Artista.Nome}";
        } 
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine(DescricaoBanda);
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
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
