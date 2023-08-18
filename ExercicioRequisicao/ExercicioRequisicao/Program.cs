using ExercicioRequisicao.Filtros;
using ExercicioRequisicao.Modelos;
using System.Net.Http.Json;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    //LinqFilter.ExibirApenasTodosOsGenerosMusicais(musicas);
    //LinqFilter.ExibirArtistasPorGeneroMusical(musicas, "pop");
    //LinqFilter.ExibirMusicasPorArtista(musicas, "U2");
    LinqFilter.ExibirMusicasPorAno(musicas, "2000");
    //LinqOrder.OrdenarArtistasPorNome(musicas);
}