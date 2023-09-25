using Emlak.Entities;
using Microsoft.EntityFrameworkCore;

namespace Emlak.DAL
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Portfoy> Portfoyler { get; set; }

        public DbSet<Calisan> Calisanlar { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
