
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly Context _context;
        private readonly DbSet<T> _dbSet;

        public Repository(Context context)
        {
          if(context==null)
                throw new ArgumentNullException("context null olamaz.");

            _context = context;
            _dbSet = context.Set<T>();
        }


        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }  

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }


        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).FirstOrDefault();
        }



        public void Add(T obj)
        {
            _dbSet.Add(obj);
        }

       
        public void Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        

        public void Delete(int id)
        {
            var obj = GetById(id);
            if (obj == null) return;
            else
            {
                if (obj.GetType().GetProperty("IsDelete") != null)
                {
                    T _obj = obj;
                    _obj.GetType().GetProperty("IsDelete").SetValue(_obj, true);

                    this.Update(_obj);
                }
                else
                {
                    Delete(obj);
                }
            }
        }

        public void Delete(T obj)
        {
            if (obj.GetType().GetProperty("IsDelete") != null)
            {
                T _obj = obj;

                _obj.GetType().GetProperty("IsDelete").SetValue(_obj, true);

                this.Update(_obj);
            }
            else
            {
                // Önce entity'nin state'ini kontrol ediyoruz.
                DbEntityEntry dbEntityEntry = _context.Entry(obj);

                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _dbSet.Attach(obj);
                    _dbSet.Remove(obj);
                }
            }
        }

    }
}
