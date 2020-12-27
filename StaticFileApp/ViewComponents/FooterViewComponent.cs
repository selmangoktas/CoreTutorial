using Microsoft.AspNetCore.Mvc;
using StaticFileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticFileApp.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<SocialMedia> abouts = new List<SocialMedia> {

            new SocialMedia {ID=1,Name="Facebok",Link="/about/vizyon"},
            new SocialMedia {ID=1,Name="İnstagram",Link="/about/vizyon"},
            new SocialMedia {ID=1,Name="Twitter",Link="/about/kalite"},
           

            };
            return View(abouts);
        }
    }
}
