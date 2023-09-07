using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme não pode ser vazio.")]
    [MaxLength(50, ErrorMessage = "O título do filme não pode exceder 50 caracteres.")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [StringLength(50, ErrorMessage = "O gênero do filme não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Range(90, 180, ErrorMessage = "A duração deve estar entre 90 a 180 minutos")]
    public int Duracao { get; set; }
}
