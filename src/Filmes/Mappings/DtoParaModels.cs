using AutoMapper;
using Filmes.Data.Dtos.Cinema;
using Filmes.Data.Dtos.Endereco;
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
        CreateMap<Cinema, ReadCinemaDto>().
            ForMember(cinemaDto => cinemaDto.Endereco,
            opt => opt.MapFrom(cinema => cinema.Endereco));
        CreateMap<UpdateCinemaDto, Cinema>();

        //Endereco
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<Endereco, ReadEnderecoDto>();
        CreateMap<UpdateEnderecoDto, Endereco>();
    }
}