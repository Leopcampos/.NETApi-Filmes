using AutoMapper;
using Filmes.Data.Dtos.Cinema;
using Filmes.Data.Dtos.Filme;
using Filmes.Models;

namespace Filmes.Mappings;

public class DtoParaModels : Profile
{
    public DtoParaModels()
    {
        //Filme
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();

        //Cinema
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>();
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}