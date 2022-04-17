using System;
using System.Linq;
using System.Linq.Expressions;
namespace BoardingHouse.Domain.Base.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> Conditions(Expression<Func<T, bool>> expression);
        IQueryable<T> GetQueryable();
    }
}
