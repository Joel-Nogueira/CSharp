class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> _musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => _musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");
        foreach (Musica musica in _musicas)
        {
            Console.WriteLine($"Música: { musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}