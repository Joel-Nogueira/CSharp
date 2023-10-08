using System.ComponentModel.DataAnnotations;

namespace ExercicioFilmeApi.Modelos;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
}
