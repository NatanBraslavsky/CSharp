class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;
    public void EscreveDisponibilidade(bool value)
    {
        disponivel = value;
    }

    public bool LeDisponibilidade()
    {
        return disponivel;
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível nas plataformas de streaming.");
        }
        else
        {
            Console.WriteLine("Indisponível nas plataformas de streaming.");
        }
    }
}
