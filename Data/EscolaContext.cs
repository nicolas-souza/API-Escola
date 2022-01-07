
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class EscolaContext: DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
        
        }

        public DbSet<Professor> Professores {get; set;}

        public DbSet<Aluno> Aluno {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professor>().ToTable("Professor");
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
        }
    }
}