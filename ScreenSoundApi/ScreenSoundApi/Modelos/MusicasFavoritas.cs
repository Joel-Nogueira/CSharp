using System.Text.Json;

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

    public void GerarJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = Musicas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo json {Path.GetFullPath(nomeDoArquivo)} foi criado com sucesso");
    }
}
