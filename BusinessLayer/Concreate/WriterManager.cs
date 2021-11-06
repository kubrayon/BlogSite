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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _writerDal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public void Writeradd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void Writerdelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void Writerupdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
