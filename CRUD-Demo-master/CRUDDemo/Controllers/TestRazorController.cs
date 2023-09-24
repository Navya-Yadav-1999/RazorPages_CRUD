using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDDemo.Controllers
{
    public class TestRazorController : Controller
    {
        // GET: TestRazorPage
        public ActionResult TestWithViewData()
        {
            List<string> items = new List<string>() { "Item1", "Item2", "Item3" };

            ViewData["ViewDataItems"] = items;
            return View();
        }

        public ActionResult TestWithViewBag()
        {
            List<string> items = new List<string>() { "Item4", "Item5", "Item6" };

            ViewBag.TestViewBag = items;
            return View();
        }

        public ActionResult TestWithTempData()
        {
            List<string> items = new List<string>() { "Item7", "Item8", "Item9" };

            TempData["TempDataItems"] = items;
            return View();
        }

        public ActionResult AccessTempData()
        {
            if (TempData["TempDataItems"] != null)
            {
                TempData["AccessTempDataItems"] = (List<string>)TempData["TempDataItems"];
                TempData.Keep();
            }

            return View();
        }
    }
}