using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emlak.DAL.EntityConfig.Abstract
{
    public abstract class BaseConfigDAL<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey("Id");

            builder.Property("Name").IsRequired();

            builder.Property("Description").HasMaxLength(255);

        }
    }
}
