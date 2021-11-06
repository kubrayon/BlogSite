using DataAccessLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context cont = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = cont.Set<T>();
        }
        public void Delete(T p)
        {
            var deleteEntity = cont.Entry(p);
            deleteEntity.State = EntityState.Deleted;
            cont.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addEntity = cont.Entry(p);
            addEntity.State = EntityState.Added;
            cont.SaveChanges();

        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updateEntity = cont.Entry(p);
            updateEntity.State = EntityState.Modified;
            cont.SaveChanges();
        }
    }
}
