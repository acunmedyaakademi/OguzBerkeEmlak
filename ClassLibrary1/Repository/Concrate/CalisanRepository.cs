using Emlak.DAL.Repositories.Abstract;
using Emlak.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repository.Concrate
{
    public class CalisanRepository : ICalisanRepository
    {
        private readonly DbContext _context;

        public CalisanRepository(DbContext context)
        {
            _context = context;
        }

        public Calisan GetById(int id)
        {
            return _context.Set<Calisan>().Find(id);
        }

        public IEnumerable<Calisan> GetAll()
        {
            return _context.Set<Calisan>().ToList();
        }

        public IEnumerable<Calisan> Find(Expression<Func<Calisan, bool>> predicate)
        {
            return _context.Set<Calisan>().Where(predicate);
        }

        public void Add(Calisan entity)
        {
            _context.Set<Calisan>().Add(entity);
        }

        public void AddRange(IEnumerable<Calisan> entities)
        {
            _context.Set<Calisan>().AddRange(entities);
        }

        public void Update(Calisan entity)
        {
            _context.Set<Calisan>().Update(entity);
        }

        public void Remove(Calisan entity)
        {
            _context.Set<Calisan>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<Calisan> entities)
        {
            _context.Set<Calisan>().RemoveRange(entities);
        }

        // Özel Çalışan işlemleri veya sorguları için yöntemler
    }
}
