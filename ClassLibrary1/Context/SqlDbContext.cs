using Emlak.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Emlak.DAL
{
    public class SqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
            public DbSet<Portfoy> Portfoyler { get; set; }

            public DbSet<Calisan> Calisanlar { get; set; }
        
        public SqlDbContext()
        {
            
        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {


        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EmlakDb;trusted_connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
