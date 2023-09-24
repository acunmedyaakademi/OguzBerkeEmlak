using Emlak.Entities; 
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Emlak.DAL.Repositories.Abstract
{
    public interface ICalisanRepository
    {
        Calisan GetById(int id);
        IEnumerable<Calisan> GetAll();
        IEnumerable<Calisan> Find(Expression<Func<Calisan, bool>> predicate);
        void Add(Calisan entity);
        void AddRange(IEnumerable<Calisan> entities);
        void Update(Calisan entity);
        void Remove(Calisan entity);
        void RemoveRange(IEnumerable<Calisan> entities);

    }
}
