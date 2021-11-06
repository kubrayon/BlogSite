using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IRepository<T>
    {
        //CRUD
        List<T> List();

        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        //Filtreleme işlemi
        T Get(Expression<Func<T, bool>> filter);
        List<T> List(Expression<Func<T, bool>> filter);

    }
}
