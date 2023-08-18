using System.Text.Json.Serialization;

namespace ExercicioRequisicao.Modelos;

class Musica
{
    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("year")]
    public string Ano { get; set; }

    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração em milissegundos: {Duracao}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine();
        Console.WriteLine();
    }
}
