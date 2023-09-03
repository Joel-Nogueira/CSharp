using ExercicioScreenSound.Filtros;
using ExercicioScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

    /*foreach (Musica musica in musicas)
    {
        musica.ExibirInformacoes();
        Console.WriteLine();
    }*/

    LinqFilter.GerarJson(musicas);
}