using AutoMapper;
using ExercicioFilmeApi.Data.Dtos;
using ExercicioFilmeApi.Modelos;

namespace ExercicioFilmeApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<Filme, ReadFilmeDto>();
        CreateMap<CreateFilmeDto, Filme>();
    }
}
