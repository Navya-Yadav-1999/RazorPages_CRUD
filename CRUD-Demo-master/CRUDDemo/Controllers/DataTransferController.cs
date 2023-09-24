using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDDemo.Controllers
{
    public class DataTransferController : Controller
    {
        public ActionResult DataTransferWithParamter(string fname_name, string lname_name)
        {
            string fname = fname_name;
            string lname = lname_name;
            Response.Write("Get name from Parameter = " + fname + " " + lname);

            return View();
        }

        public ActionResult DataTransferWithFormCollection(FormCollection data)
        {
            string fname = data["fname_name"];
            string lname = data["lname_name"];
            Response.Write("Get name from Form Collection = " + fname + " " + lname);

            return View();
        }

        public ActionResult DataTransferWithRequestObject()
        {
            string fname = Request["fname_name"];
            string lname = Request["lname_name"];
            Response.Write("Get name from Request Object = " + fname + " " + lname);

            return View();
        }
    }
}