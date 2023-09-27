using Emlak.DAL.EntityConfig.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfig.Concrate
{
    public class MenuConfig : BaseConfig<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            base.Configure(builder);
           
            builder.Property(p => p.MenuAdi).HasMaxLength(50);
            builder.Property(p => p.Action).HasMaxLength(50);
            builder.Property(p => p.Controller).HasMaxLength(50);
            builder.Property(p => p.Area).HasMaxLength(50);
            builder.Property(p => p.CssClass).HasMaxLength(50);
            builder.Property(p => p.CssClass2).HasMaxLength(50);
            builder.Property(p => p.IconClass).HasMaxLength(50);
            builder.Property(p => p.IconClass2).HasMaxLength(50);


        }
    }
}
