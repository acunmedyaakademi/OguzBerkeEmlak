using Emlak.Entities; 
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Emlak.DAL.Repositories.Abstract
{
    public interface IPortfoyRepository
    {
        Portfoy GetById(int id);
        IEnumerable<Portfoy> GetAll();
        IEnumerable<Portfoy> Find(Expression<Func<Portfoy, bool>> predicate);
        void Add(Portfoy entity);
        void AddRange(IEnumerable<Portfoy> entities);
        void Update(Portfoy entity);
        void Remove(Portfoy entity);
        void RemoveRange(IEnumerable<Portfoy> entities);

    }
}
