using System.ComponentModel.DataAnnotations;

namespace Filmes.Models;

public class Cinema
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }
}