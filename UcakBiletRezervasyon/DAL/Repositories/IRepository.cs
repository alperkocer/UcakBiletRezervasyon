using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T :class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);

        T GetById(int id);
        T Get(Expression<Func<T, bool>> predicate);
       
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Delete(int id);
       
       
    }
}
