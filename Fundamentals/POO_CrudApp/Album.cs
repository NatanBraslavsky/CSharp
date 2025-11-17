class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicaDoAlbum()
    {
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica}");
        }
    }
}