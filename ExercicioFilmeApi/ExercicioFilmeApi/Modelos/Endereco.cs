using System.ComponentModel.DataAnnotations;

namespace ExercicioFilmeApi.Modelos;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public virtual Cinema Cinema { get; set; }
}
