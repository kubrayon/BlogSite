﻿using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading()
        {
            return View();
        }
    }
}