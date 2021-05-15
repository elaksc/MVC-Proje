using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Listeleme için kullanılır genelde index()
        {
            return View();
        }

        public ActionResult About()//Hakkında Metodu
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()//İletişim Metodu
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}