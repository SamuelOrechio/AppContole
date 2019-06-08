using AppControle.AplicationCore.Entity;
using AppControle.InfraStructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace AppControle.InfraStructure.Data
{
    public class DataContext : DbContext 
  
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaTipo> PessoaTipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<PessoaTipo>().ToTable("PessoaTipo");

            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new PessoaTipoMap());
        }
    }
}
