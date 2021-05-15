using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            //Toplam Kategori Sayısı
            var totalCategory = context.Categories.Count(); 
            ViewBag.totalCategory = totalCategory;

            //Yazılım Kategorili Başlık Sayısı
            var SoftwareTitle = context.Headings.Count(x => x.HeadinName == "Yazılım");
            ViewBag.SoftwareT = SoftwareTitle;

            //Yazar Adında 'a' olan yazar sayısı
            var writer = context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.writera = writer;

            //En çok başlığa sahip olan
            var mostTitles = context.Headings.Max(x => x.Category.CategoryName);
            ViewBag.theMostTitles = mostTitles;

            //Durumu true olanlar
            var statusTrue = context.Categories.Count(x => x.CategoryStatus == true);
            ViewBag.status = statusTrue;
            return View();
        }
    }
}