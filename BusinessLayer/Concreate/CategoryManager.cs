using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        //public void CategoryAdd(Category category)
        //{
        //    throw new NotImplementedException();
        //}

        public void CategoryAddBL(Category category)
        {
            _categorydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }

        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{

        //    if (p.CategoryName == "" || p.CategoryName.Length <= 2 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        hata mesajı
        //     }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
        public List<Category> GetList()
        {
            return _categorydal.List();
        }
    }
}
