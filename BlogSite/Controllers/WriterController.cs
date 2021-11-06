using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using EntityLayer.Concreate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer
        WriterManager wm = new WriterManager(new EFWriterDal());
        public ActionResult Index()
        {
            var Writervalues = wm.GetList();
            return View(Writervalues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
            WriterValidator writervalidator = new WriterValidator();
            ValidationResult results = writervalidator.Validate(p);
            if (results.IsValid)
            {
                wm.Writeradd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}