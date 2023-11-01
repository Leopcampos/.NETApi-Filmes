using AutoMapper;
using Filmes.Data.Dtos;
using Filmes.Models;

namespace Filmes.Mappings;

public class DtoParaModels : Profile
{
    public DtoParaModels()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}