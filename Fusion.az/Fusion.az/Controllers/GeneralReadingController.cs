using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fusion.az.Controllers
{
    public class GeneralReadingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
