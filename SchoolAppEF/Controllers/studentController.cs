using SchoolAppEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SchoolAppEF.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        private sContext sc = new sContext();
        public ActionResult sindex()
        {
               return View(sc.student.ToList());
        }

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create([Bind(Include ="sID,sn")]student student)
        {
            if(ModelState.IsValid)
            {
                sc.student.Add(student);
                sc.SaveChanges();
                return RedirectToAction("sindex");
            }
            return View(student);
        }



        [HttpGet]
        public ActionResult Edit(int? id)
        {
           if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            student s = sc.student.Find(id);
            if(s==null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(student s)
        {
            if (ModelState.IsValid)
            {
                sc.Entry(s).State = EntityState.Modified;
                sc.SaveChanges();
                return RedirectToAction("sindex");
            }
            return View(s);
        }




        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            student s = sc.student.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }



        [HttpPost]
        public ActionResult Delete(int id)
        {

            student st = sc.student.Find(id);
            sc.student.Remove(st);
            sc.SaveChanges();
            return RedirectToAction("sindex");

            
        }



        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            student s = sc.student.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }
    }
}