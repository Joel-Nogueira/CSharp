Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum();