using AutoMapper;
using ExercicioApi.Data.Dtos;
using ExercicioApi.Modelos;

namespace ExercicioApi.Profiles;

public class MusicaProfile : Profile
{
    public MusicaProfile()
    {
        CreateMap<MusicaDto, Musica>();
    }
}
