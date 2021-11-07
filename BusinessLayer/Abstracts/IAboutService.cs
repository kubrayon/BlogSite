using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
   public interface IAboutService
    {
        List<About> GetList();
        void AboutAdd(About about);
        About GetByID(int id);
        void Aboutdelete(About about);
        void Aboutupdate(About about);
    }
}
