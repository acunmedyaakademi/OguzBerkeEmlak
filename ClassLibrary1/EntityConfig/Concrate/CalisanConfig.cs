using Emlak.DAL.EntityConfig.Abstract;
using Emlak.Entities; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emlak.DAL.EntityConfig.Concrete
{
    public class CalisanConfig : BaseConfigDAL<Calisan>
    {
        public override void Configure(EntityTypeBuilder<Calisan> builder)
        {
            base.Configure(builder);

            // builder.ToTable("Calisan");

            builder.HasKey(c => c.CalisanID); // Primary Key belirleme
            builder.Property(c => c.CalisanIsimSoyisim).IsRequired().HasMaxLength(100);
            builder.Property(c => c.CalisanGSM).IsRequired().HasMaxLength(20);
            builder.Property(c => c.CalisanGSM2).HasMaxLength(20);
            builder.Property(c => c.CalisanMail);
            builder.Property(c => c.CalisanMail2);
            builder.Property(c => c.CalisanPortfoySayisi);
            builder.Property(c => c.CalisanDurum);

            // Örnek bir ilişki tanımı:
            // builder.HasMany(c => c.Portfoys) // Çalışanın birden fazla portföyü olabilir
            //        .WithOne(p => p.PortfoySahibi)
            //        .HasForeignKey(p => p.PortfoySahibiID)
            //        .OnDelete(DeleteBehavior.Restrict); // İlişkiyi özelleştirmek için kullanılabilir
        }
    }
}
