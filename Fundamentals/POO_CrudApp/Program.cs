Album albumTeste = new Album("nomeAlbumTeste");
Banda queen = new Banda("Queen");

Musica musica1 = new Musica(queen, "Musica Teste")
{   
    Duracao = 200,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Musica 2 Teste")
{
    Duracao = 355,
    Disponivel = false,
};

musica1.ExibirFichaTecnica();

albumTeste.AdicionarMusica(musica1);
albumTeste.AdicionarMusica(musica2);
albumTeste.ExibirMusicaDoAlbum();


queen.AdicionarAlbum(albumTeste);
queen.ExibirDiscografia();

