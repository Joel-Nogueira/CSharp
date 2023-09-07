using System.Text.Json.Serialization;

namespace ExercicioApi.Data.Dtos
{
    public class MusicaDto
    {
        public string Artista { get; set; }

        public string? Nome { get; set; }

        public string Ano { get; set; }

        public string Genero { get; set; }

        public int Duracao { get; set; }
    }
}
