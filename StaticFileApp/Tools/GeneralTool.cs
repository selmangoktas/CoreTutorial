using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticFileApp.Tools
{
    public class GeneralTool
    {
        public static string UrlConvert(string link)
        {
            return link.ToLower().Replace(" ", "-").Replace("ü", "u").Replace("ö", "o").Replace("ş","s").Replace("ç","c").Replace("ğ","g").Replace("ı","i").Replace("'","").Replace("&","-");
        }
    }
}
