Album albumTeste = new Album();
albumTeste.Nome = "nomeAlbumTeste";

Musica musica1 = new Musica();
musica1.Nome = "Musica Teste";
musica1.Artista = "Artista Teste";
musica1.Duracao = 300;
musica1.Disponivel = true;


Musica musica2 = new Musica();
musica2.Nome = "Musica 2 Teste";
musica2.Artista = "Artista 2 Teste";
musica2.Duracao = 200;
musica2.Disponivel = false;

albumTeste.AdicionarMusica(musica1);
albumTeste.AdicionarMusica(musica2);

albumTeste.ExibirMusicaDoAlbum();



