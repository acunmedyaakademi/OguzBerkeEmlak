using Emlak.DAL.EntityConfig.Abstract;
using Emlak.Entities; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emlak.DAL.EntityConfig.Concrete
{
    public class PortfoyConfig : BaseConfig<Portfoy>
    {

        public override void Configure(EntityTypeBuilder<Portfoy> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.PortfoyTipi).IsRequired();
            builder.Property(p => p.PortfoyAdres).IsRequired().HasMaxLength(255);
           
            builder.Property(p => p.MetrekareAlan);
            builder.Property(p => p.PortfoyDurumu).IsRequired();
            builder.Property(p => p.PortfoyTutar);
            builder.Property(p => p.PortfoyAciklama);
        }
        //public override void Configure(EntityTypeBuilder<Portfoy> builder)
        //{
        //    base.Configure(builder);

        //    // builder.ToTable("Portfoy");

        //    builder.HasKey(p => p.PortfoyID); 
        //    builder.Property(p => p.PortfoyTipi).IsRequired();
        //    builder.Property(p => p.PortfoyAdres).IsRequired().HasMaxLength(255);
        //    builder.Property(p => p.PortfoySahibiID).IsRequired();
        //    builder.Property(p => p.PortfoySahibi2ID);
        //    builder.Property(p => p.MetrekareAlan);
        //    builder.Property(p => p.PortfoyDurumu).IsRequired();
        //    builder.Property(p => p.PortfoyTutar);
        //    builder.Property(p => p.PortfoyAciklama);

        //    // builder.HasOne(p => p.PortfoySahibi)
        //    //        .WithMany(c => c.Portfoys)
        //    //        .HasForeignKey(p => p.PortfoySahibiID)
        //    //        .IsRequired();

        //}
    }
}
