using Emlak.DAL.Repositories.Abstract;
using Emlak.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repository.Concrate
{
    public class PortfoyRepository : IPortfoyRepository
    {
        private readonly DbContext _context;

        public PortfoyRepository(DbContext context)
        {
            _context = context;
        }

        public Portfoy GetById(int id)
        {
            return _context.Set<Portfoy>().Find(id);
        }

        public IEnumerable<Portfoy> GetAll()
        {
            return _context.Set<Portfoy>().ToList();
        }

        public IEnumerable<Portfoy> Find(Expression<Func<Portfoy, bool>> predicate)
        {
            return _context.Set<Portfoy>().Where(predicate);
        }

        public void Add(Portfoy entity)
        {
            _context.Set<Portfoy>().Add(entity);
        }

        public void AddRange(IEnumerable<Portfoy> entities)
        {
            _context.Set<Portfoy>().AddRange(entities);
        }

        public void Update(Portfoy entity)
        {
            _context.Set<Portfoy>().Update(entity);
        }

        public void Remove(Portfoy entity)
        {
            _context.Set<Portfoy>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<Portfoy> entities)
        {
            _context.Set<Portfoy>().RemoveRange(entities);
        }

        // Özel Portfoy işlemleri veya sorguları için yöntemler
    }
}
