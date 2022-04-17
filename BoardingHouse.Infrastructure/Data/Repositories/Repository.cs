using BoardingHouse.Domain.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoardingHouse.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Conditions(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
