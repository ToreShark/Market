using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Market.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            var obj = new
            {
                id = 1,
                id2 = 2,
            };
            // string myWiew = "Test";
            // return View("Index");
            return View(obj);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}