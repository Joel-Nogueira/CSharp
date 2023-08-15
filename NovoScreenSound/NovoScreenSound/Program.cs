Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibirDiscografia();

Console.WriteLine();
Console.WriteLine();

Episodio episodio1 = new Episodio(100, 99, "Nove nove");
Episodio episodio2 = new Episodio(100, 33, "Trinta e três");
Episodio episodio3 = new Episodio(100, 88, "Oito oito");

Podcast podcast = new Podcast("Joel", "Podcast do Joel");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);
podcast.ExibirDetalhes();