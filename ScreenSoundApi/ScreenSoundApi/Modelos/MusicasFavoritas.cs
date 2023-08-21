namespace ScreenSoundApi.Modelos;

class MusicasFavoritas
{
    public string Nome { get; set; }
    public List<Musica> Musicas { get; set; }

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        Musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Músicas do(a) {Nome}");
        foreach (Musica musica in Musicas)
        {
            Console.WriteLine($"- {musica.Nome}, {musica.Artista}");
        }
    }
}
