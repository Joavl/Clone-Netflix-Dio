using API_EVENTOS.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_EVENTOS.Persistence
{
    public class EventosDbContext : DbContext
    {
        public EventosDbContext(DbContextOptions<EventosDbContext> options) : base(options)
        {

        }
        public DbSet<Eventos> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Eventos>()
                   .HasKey(e => e.Id);
        }

    }
}
