using Filmes.Data.Dtos.Endereco;

namespace Filmes.Data.Dtos.Cinema;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ReadEnderecoDto Endereco { get; set; }
}