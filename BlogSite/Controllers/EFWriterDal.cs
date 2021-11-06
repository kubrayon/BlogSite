using DataAccessLayer.Abstracts;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;

namespace BlogSite.Controllers
{
    internal class EFWriterDal :GenericRepository <Writer>,IWriterDal
    {
    }
}