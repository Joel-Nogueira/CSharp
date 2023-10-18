using ExercicioFilmeApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ExercicioFilmeApi.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions opts)
        : base(opts)
    {
        
    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }
}
