using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager aboutman = new AboutManager(new EFAboutDal());
        public ActionResult Index()
        {
            var aboutvalues = aboutman.GetList();

            return View(aboutvalues);
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            aboutman.AboutAdd(p);
            return RedirectToAction("Index");
        }
    }
}