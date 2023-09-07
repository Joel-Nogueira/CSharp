using System.Text.Json.Serialization;

namespace ExercicioApi.Modelos;

public class Musica
{
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string Ano { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
}
