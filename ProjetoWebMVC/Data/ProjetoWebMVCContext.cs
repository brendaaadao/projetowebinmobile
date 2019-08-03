using Microsoft.EntityFrameworkCore;

namespace ProjetoWebMVC.Models
{
    public class ProjetoWebMVCContext : DbContext
    {
        public ProjetoWebMVCContext (DbContextOptions<ProjetoWebMVCContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidatoVaga>()
                .HasKey(c => new { c.IdCandidato, c.IdVaga });
        }

        public DbSet<ProjetoWebMVC.Models.Candidato> Candidato { get; set; }

        public DbSet<ProjetoWebMVC.Models.Vaga> Vaga { get; set; }
    }
}
