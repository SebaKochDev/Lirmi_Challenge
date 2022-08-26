using Microsoft.EntityFrameworkCore;

namespace Lirmi.Challenge.API.Context
{
    public class ChallengeDataContext : DbContext
    {
        public ChallengeDataContext(DbContextOptions<ChallengeDataContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Colegio> Colegios { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }




    }
}
