using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace S2_NCORE_MVC.Web.Areas.Marketing.Controllers
{
    public class HomeController : Controller
    {
        [Area("Marketing")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
