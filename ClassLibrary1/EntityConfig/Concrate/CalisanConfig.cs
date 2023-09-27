using Emlak.DAL.EntityConfig.Abstract;
using Emlak.Entities; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emlak.DAL.EntityConfig.Concrete
{
    public class CalisanConfig : BaseConfig<Calisan>
    {



        public override void Configure(EntityTypeBuilder<Calisan> builder)
        {
            base.Configure(builder);
           
            builder.Property(c => c.IsimSoyisim).IsRequired().HasMaxLength(100);
            builder.Property(c => c.KullaniciAdi);
            builder.Property(c => c.KullaniciSifre);
            builder.Property(c => c.GSM).IsRequired().HasMaxLength(20);
            builder.Property(c => c.GSM2).HasMaxLength(20);
            builder.Property(c => c.Mail);
            builder.Property(c => c.Mail2);
            builder.Property(c => c.PortfoySayisi);
           
        }
    }
}

