using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExercicioScreenSound.Modelos;

class Musica
{
    /*public Musica(string artista, string nome, int duracao, string ano, string genero)
    {
        Artista = artista;
        Nome = nome;
        Duracao = duracao;
        Ano = ano;
        Genero = genero;
    }*/

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
        Console.WriteLine($"- Artista: {Artista}");
        Console.WriteLine($"- Nome: {Nome}");
        Console.WriteLine($"- Duração: {Duracao}");
        Console.WriteLine($"- Ano: {Ano}");
        Console.WriteLine($"- Gênero: {Genero}");
    }
}
