using Emlak.Entities;
using Microsoft.EntityFrameworkCore;

namespace Emlak.DAL
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public DbSet<Portfoy> Portfoyler { get; set; }

        public DbSet<Calisan> Calisanlar { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
