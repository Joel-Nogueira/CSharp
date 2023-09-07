using AutoMapper;
using ExercicioApi.Data;
using ExercicioApi.Data.Dtos;
using ExercicioApi.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MusicaController
{ 
    private MusicaContext _context;
    private IMapper _mapper;

    public MusicaController(MusicaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper; 
    }

    [HttpPost]
    public void CriarMusica([FromBody] MusicaDto musicaDto)
    {
        Musica musica = _mapper.Map<Musica>(musicaDto);
        _context.Musicas.Add(musica);
        _context.SaveChanges();
    }

    [HttpGet]
    public IEnumerable<Musica> RetornarTodasMusicas()
    {
        return _context.Musicas;
    }

    [HttpGet("ano/{ano}")]
    public IEnumerable<Musica> GetMusicasPorAno(string? ano)
    {
        return _context.Musicas.Where(m => m.Ano.Equals(ano));
    }
}
