using ExercicioApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ExercicioApi.Data;

public class MusicaContext : DbContext
{
    public MusicaContext(DbContextOptions<MusicaContext> opts)
        : base(opts)
    {
        
    }

    public DbSet<Musica> Musicas { get; set; }
}
