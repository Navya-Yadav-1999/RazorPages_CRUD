using CRUDDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CRUDDemo.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]    
        public ActionResult create(Student model)
        {
            using(var context = new DemoCRUDContext()) 
            {
                context.Student.Add(model); 
                context.SaveChanges(); 
            }
            string message = "Created the record successfully";
            ViewBag.Message = message;     
            return View(); 
        }

        [HttpGet] 
        public ActionResult Read()
        {
            using(var context = new DemoCRUDContext())
            {
                var data = context.Student.ToList(); 
                return View(data);
            }
            
        }

        [HttpGet] 
        public ActionResult Details(int id)
        {
            using (var context = new DemoCRUDContext())
            {
                var data = context.Student.Where(x => x.StudentNo == id).SingleOrDefault();
                return View(data);
            }

        }

        public ActionResult Update(int Studentid) 
        {
            using(var context = new DemoCRUDContext())
            {
                var data = context.Student.Where(x => x.StudentNo == Studentid).SingleOrDefault();
                return View(data);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Update(int Studentid, Student model)
        {
            using(var context = new DemoCRUDContext())
            {
                var data = context.Student.FirstOrDefault(x => x.StudentNo == Studentid); 
                if (data != null) 
                {
                    data.Name = model.Name;
                    data.Section = model.Section;
                    data.EmailId = model.EmailId;
                    data.Branch = model.Branch;
                    context.SaveChanges();
                    return RedirectToAction("Read"); 
                }
                else
                    return View();
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Studentid)
        {
            using(var context = new DemoCRUDContext())
            {
                var data = context.Student.FirstOrDefault(x => x.StudentNo == Studentid);
                if (data != null)
                {
                    context.Student.Remove(data);
                    context.SaveChanges();
                    return RedirectToAction("Read");
                }
                else
                    return View();
            }
        }
    }
}

