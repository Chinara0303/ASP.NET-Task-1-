using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id,string name)
        {
            if (id != null)
            {
                if (id > 0)
                {
                    return Content($"sifirdan boyukdu {name}");
                }
                return Content($"sifirdan boyuk deyil {name}");

            }
            return View();

        }
        public IActionResult About(int? id, string name)
        {
            if (id != null)
            {
                if (id > 0)
                {
                    return Content($"sifirdan boyukdu {name}");
                }
                return Content($"sifirdan boyuk deyil {name}");

            }
            return View();
        }
        public IActionResult Contact(int? id, string name)
        {
            if (id != null)
            {
                if (id > 0)
                {
                    return Content($"sifirdan boyukdu {name}");
                }
                return Content($"sifirdan boyuk deyil {name}");

            }
            return View();
        }
    }
}
