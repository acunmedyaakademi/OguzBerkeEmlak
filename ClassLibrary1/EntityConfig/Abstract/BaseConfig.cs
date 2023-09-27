using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entites.Abstract;
using Microsoft.EntityFrameworkCore;


namespace DAL.EntityConfig.Abstract
{
    public class BaseConfig
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CreateTime).HasDefaultValue(DateTime.Now);
        }
    }
}
