using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaticFileApp.Models;
using StaticFileApp.Tools;

namespace StaticFileApp.Controllers
{
    public class HomeController : Controller
    {
        List<News> news = new List<News> {
        new News{ID = 1, Title = "Maraton Koşuları Başladı", Picture = "/contents/news/1.jpg", Description = "Birinci Haberin Başlığı", RecDate = DateTime.Now.AddDays(-10) },
           new News{ ID = 2, Title = "Aşı Haberlerinde Çelişki Uyandıran Bilgiler", Picture = "/contents/news/2.jpg", Description = "İkinci Haberin Başlığı", RecDate = DateTime.Now.AddDays(-22) },
            new News{ID = 3, Title = "Haber Başlığı 3 ", Picture = "/contents/news/3.jpg", Description = "Üçüncü Haberin Başlığı Something short and leading about the collection below—its contents, the creator, etc. Make it short and sweet, but not too short so folks don’t simply skip over it entirely.", RecDate = DateTime.Now.AddDays(-14) },
         new News{ ID = 4, Title = "Haber Başlığı 4", Picture = "/contents/news/4.jpg", Description = "Dördüncü Haberin Başlığı", RecDate = DateTime.Now.AddDays(-10)},
            new News{ ID = 5, Title = "Haber Başlığı 5", Picture = "/contents/news/5.jpg", Description = "Beşinci Haberin Başlığı", RecDate = DateTime.Now.AddDays(-12)},
           new News{ ID = 6, Title = "Haber Başlığı 6", Picture = "/contents/news/6.jpg", Description = "Altıncı Haberin Başlığı", RecDate = DateTime.Now.AddDays(-4) }
        };

        public IActionResult Index()
        {
            //List Icollection IQueryable:IEnumarable  

            ViewBag.activePage = "home";
            return View(news);
        }
        //public IActionResult Detay(int id)
        //{
        //    //int x = 5;
        //    //string sonuc;
        //    ////if (x > 0) sonuc = "Pozitif Tam Sayı";
        //    ////else sonuc = "Sıfır veya Negatif Tam Sayı";

        //    //sonuc = x > 0 ? "Pozitifi" : "Negatif veya Sıfır";

        //    News selectedNews = news.FirstOrDefault(x => x.ID == id) ?? null;
        //    if (selectedNews == null) return Redirect("/");
        //    else return View(selectedNews);
        //}

        //public IActionResult Detay(string title)
        //{
        //    if (!string.IsNullOrEmpty(title))
        //    {
        //        News selectedNews = news.FirstOrDefault(x => GeneralTool.UrlConvert(x.Title) == title) ?? null;
        //        if (selectedNews == null) return Redirect("/");
        //        else return View(selectedNews);
        //    }
        //    else return Redirect("/");
        //}

        [Route("/Haber/{title}-{id}-karatekin")]
        public IActionResult Detay(string title, int id)
        {
            if (!string.IsNullOrEmpty(title))
            {
                News selectedNews = news.FirstOrDefault(x => GeneralTool.UrlConvert(x.Title) == title && x.ID == id) ?? null;
                if (selectedNews == null) return Redirect("/");
                else return View(selectedNews);
            }
            else return Redirect("/");
        }

        //Route
        //Taghelper - Custom TagHelper
        //MiddleWare
        //Dependency Injection
        //EFCORE
    }
}
