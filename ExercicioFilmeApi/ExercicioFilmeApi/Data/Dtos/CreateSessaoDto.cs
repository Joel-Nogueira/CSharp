using System.ComponentModel.DataAnnotations;

namespace ExercicioFilmeApi.Data.Dtos;

public class CreateSessaoDto
{
    [Required]
    public int FilmeId { get; set; }
}
