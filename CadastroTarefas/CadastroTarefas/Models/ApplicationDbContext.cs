
using Microsoft.EntityFrameworkCore;

namespace CadastroTarefas.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tarefas> Tarefas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefas>()
                .ToTable("Tarefas")
                .HasKey(t => t.IdTarefa);
        }
    }
}