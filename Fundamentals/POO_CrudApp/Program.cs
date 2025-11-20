Album albumTeste = new Album();
albumTeste.Nome = "nomeAlbumTeste";
Banda queen = new Banda();
queen.Nome = "Queen";

Musica musica1 = new Musica(queen);
musica1.Nome = "Musica Teste";
musica1.Duracao = 300;
musica1.Disponivel = true;


Musica musica2 = new Musica(queen); 
musica2.Nome = "Musica 2 Teste";
musica2.Duracao = 200;
musica2.Disponivel = false;

albumTeste.AdicionarMusica(musica1);
albumTeste.AdicionarMusica(musica2);
albumTeste.ExibirMusicaDoAlbum();


queen.AdicionarAlbum(albumTeste);
queen.ExibirDiscografia();

