using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
   public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingID(int id);
        void Contentadd(Content content);
        Content GetByID(int id);
        void Contentdelete(Content content);
        void Contentupdate(Content content);


    }
}
