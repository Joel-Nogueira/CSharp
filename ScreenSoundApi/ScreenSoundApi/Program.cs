using System.Text.Json;
using ScreenSoundApi.Filtros;
using ScreenSoundApi.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        MusicasFavoritas musicasFavoritas = new MusicasFavoritas("Aleatórias");
        musicasFavoritas.AdicionarMusica(musicas[99]);
        musicasFavoritas.AdicionarMusica(musicas[666]);
        musicasFavoritas.AdicionarMusica(musicas[1414]);
        musicasFavoritas.AdicionarMusica(musicas[908]);
        musicasFavoritas.AdicionarMusica(musicas[1234]);
        musicasFavoritas.ExibirMusicas();
        musicasFavoritas.GerarJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}