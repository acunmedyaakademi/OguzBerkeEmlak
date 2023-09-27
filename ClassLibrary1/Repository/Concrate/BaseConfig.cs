using Emlak.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Emlak.DAL.EntityConfig.Abstract
{
    public abstract class BaseConfig<TEntity> : IBaseConfig where TEntity : class
    {
        public virtual void Configure(ModelBuilder modelBuilder)
        {
            // TEntity türüne özgü yapılandırmaları burada tanımlayabilirsiniz.
        }
    }
}
