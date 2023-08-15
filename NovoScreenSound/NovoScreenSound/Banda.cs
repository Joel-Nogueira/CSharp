class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    List<Album> _albums = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        _albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in _albums)
        {
            Console.WriteLine($"Álbum {album.Nome} ({album.DuracaoTotal})");
            album.ExibirMusicasDoAlbum();
        }
    }
}