﻿Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life");
musica1.Duracao = 200;

Musica musica2 = new Musica(queen, "Bohemian Rhapsody");
musica2.Duracao = 200;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();