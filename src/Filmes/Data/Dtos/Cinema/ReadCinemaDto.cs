using Filmes.Data.Dtos.Endereco;
using Filmes.Data.Dtos.Sessao;

namespace Filmes.Data.Dtos.Cinema;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ReadEnderecoDto Endereco { get; set; }
    public ICollection<ReadSessaoDto> Sessoes { get; set; }
}