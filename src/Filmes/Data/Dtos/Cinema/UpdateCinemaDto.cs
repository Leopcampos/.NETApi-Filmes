using System.ComponentModel.DataAnnotations;

namespace Filmes.Data.Dtos.Cinema;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }
}