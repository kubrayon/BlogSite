using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ContentManager : IContentService
    {
        IContentDal _contentdal;

        public ContentManager(IContentDal contentdal)
        {
            _contentdal = contentdal;
        }

        public void Contentadd(Content content)
        {
            throw new NotImplementedException();
        }

        public void Contentdelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void Contentupdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentdal.List(x => x.HeadingID == id);
        }

        //public List<Content> GetListById(int id)
        //{
        //    return _contentdal.List(x => x.HeadingID == id);
        //}
    }
}
