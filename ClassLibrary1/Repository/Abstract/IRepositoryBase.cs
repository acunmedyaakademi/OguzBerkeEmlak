using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
    public interface IRepositoryBase
    {
        
        public interface IRepositoryBase<T> where T : BaseEntity
        {
            public Task<int> Insert(T entity);
            public Task<int> Update(T entity);
            public Task<int> Delete(T entity);
            public Task<T>? GetById(int id);
            public Task<ICollection<T>>? GetAll();
            public Task<T>? FindAsync(Expression<Func<T, bool>> filter);
            public Task<ICollection<T>>? FindAllASync(Expression<Func<T, bool>> filter);

            public Task<IQueryable<T>>? FindAllInclude(
              Expression<Func<T, bool>>? filter = null,// Lamda Expresion Kullanimi icin Gerekli  
              params Expression<Func<T, object>>[]? include // Join işlemi icin gerekli
              );


        }
    }
}
