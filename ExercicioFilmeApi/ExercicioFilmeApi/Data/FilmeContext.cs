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
}
