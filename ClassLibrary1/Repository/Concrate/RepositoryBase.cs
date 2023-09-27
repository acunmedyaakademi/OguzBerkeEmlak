using DAL.Repository.Abstract;
using Emlak.DAL;
using Entites.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static DAL.Repository.Abstract.IRepositoryBase;

namespace DAL.Repository.Concrate
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        public readonly SqlDbContext dbContext;
        public RepositoryBase()
        {
            dbContext = new SqlDbContext();
        }





        public async Task<int> Insert(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<T>? GetById(int id)
        {
            return await dbContext.FindAsync<T>(id);
        }

        public async Task<ICollection<T>>? GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T>? FindAsync(Expression<Func<T, bool>> filter)
        {
            if (filter == null)
            {
                return await dbContext.Set<T>().FirstOrDefaultAsync();
            }
            else
            {
                return await dbContext.Set<T>().Where(filter).FirstOrDefaultAsync();
            }
        }

        public async Task<ICollection<T>>? FindAllASync(Expression<Func<T, bool>> filter)
        {
            if (filter == null)
            {
                return await dbContext.Set<T>().ToListAsync();
            }
            else
            {
                return await dbContext.Set<T>().Where(filter).ToListAsync();
            }
        }

        public async Task<IQueryable<T>> FindAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? include)
        {
            var query = dbContext.Set<T>();
            if (filter != null)
            {
                query.Where(filter);
            }
            var result = include.Aggregate(query.AsQueryable(),
                (current, includeprop) => current.Include(includeprop));
            return result;
        }

    }
}
