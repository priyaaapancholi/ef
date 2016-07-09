using SchoolAppEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolAppEF.Controllers
{
    public class courseController : Controller
    {
        // GET: course
        private sContext sc = new sContext();
        public ActionResult cindex()
        {
            return View();
        }
    }
}