using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
   public interface IWriterService
    {
        List<Writer> GetList();
        void Writeradd(Writer writer);
        void Writerdelete(Writer writer);
        void Writerupdate(Writer writer);
        Writer GetByID(int id);

    }
}
