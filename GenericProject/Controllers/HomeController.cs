using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenericProject.Jobs;

namespace GenericProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Jobs.MaListeGenerique<string> a = new MaListeGenerique<string>();
            bool val = Jobs.MaListeGenerique<string>.AreEqual("aaa", "aaa");
            val = Jobs.MaListeGenerique<int>.AreEqual(2, 2);
            val = Jobs.MaListeGenerique<int>.AreEqual(2, 3);
            val = Jobs.MaListeGenerique<string>.AreEqual("aaa", "bbb");
            return View();
        }

        public JsonResult areEqual()
        {

            return null;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}