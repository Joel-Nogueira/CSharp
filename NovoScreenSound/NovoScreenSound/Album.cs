class Album
{
    private List<Musica> _musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal { get; set; }

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
    }
}