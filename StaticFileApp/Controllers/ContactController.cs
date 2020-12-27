using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticFileApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.activePage = "contact";
            return View();
        }
    }
}
