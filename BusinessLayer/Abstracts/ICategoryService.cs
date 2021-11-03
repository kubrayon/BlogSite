using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAddBL(Category category);
    }

}
