using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emlak.DAL.EntityConfig.Abstract
{
    public abstract class BaseConfigDAL<TEntity> where TEntity : class
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {

            // Örnek: Primary Key belirleme
            object value = builder.HasKey(e => e.Id);

            // Örnek: Bir özelliğin zorunlu olduğunu belirleme
            builder.Property(e => e.Name).IsRequired();

            // Örnek: Bir özelliğin maksimum uzunluğunu belirleme
            builder.Property(e => e.Description).HasMaxLength(255);

        }
    }
}
