using Microsoft.AspNetCore.Mvc;
using StaticFileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticFileApp.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<About> abouts = new List<About> { 
            
            new About {ID=1,Name="Vizyon",Link="/about/vizyon"},
            new About {ID=1,Name="Misyon",Link="/about/vizyon"},
            new About {ID=1,Name="Kalite Politikası",Link="/about/kalite"},
            new About {ID=1,Name="Foto Galeri",Link="/about/foto"},
            new About {ID=1,Name="Video Galeri",Link="/about/video"},
            
            }; 
            return View(abouts);
        }
    }
}
