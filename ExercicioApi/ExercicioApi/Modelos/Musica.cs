using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExercicioApi.Modelos;

public class Musica
{
    [Key]
    [Required]
    public int Id { get; set; }

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
