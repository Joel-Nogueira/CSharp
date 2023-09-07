using ExercicioApi.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ExercicioApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MusicaController
{
    private static List<Musica>? _musicas;

    [HttpPost]
    public async void BuscarMusicasNaUrl([FromBody] string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string resposta = await client.GetStringAsync(url);
            _musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        }
    }

    [HttpGet]
    public List<Musica>? RetornarTodasMusicas()
    {
        return _musicas;
    }

    [HttpGet("ano/{ano}")]
    public IEnumerable<Musica> GetMusicasPorAno(string? ano)
    {
        if (_musicas == null)
            return null;

        return _musicas.Where(m => m.Ano.Equals(ano));
    }
}
