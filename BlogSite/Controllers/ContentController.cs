using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager contm = new ContentManager(new EFContentDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = contm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}