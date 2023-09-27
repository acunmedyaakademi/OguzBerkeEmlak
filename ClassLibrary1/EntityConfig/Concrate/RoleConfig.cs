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
    public class RoleConfig :BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.RoleName).HasMaxLength(128);
            builder.HasIndex(p => p.RoleName).IsUnique();
        }
    }
}
