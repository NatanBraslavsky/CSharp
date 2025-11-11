Musica musica1 = new Musica();

musica1.nome = "Musica Teste";
musica1.artista = "Artista Teste";
musica1.duracao = 300;
musica1.EscreveDisponibilidade(true);

Console.WriteLine(musica1.LeDisponibilidade());
musica1.ExibirFichaTecnica();
