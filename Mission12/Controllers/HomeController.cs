using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {
        private TempleContext daContext { get; set; }

        // Constructor
        public HomeController(TempleContext temple)
        {
            daContext = temple;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Times()
        {
            ViewBag.Times = daContext.Times.ToList();
            return View();
        }

        public IActionResult ViewAll()
        {
            return View();
        }

        private ITempleRepository repo { get; set; }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Appointment a)
        {

            if (ModelState.IsValid)
            {
                daContext.Add(a);
                daContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Times = daContext.Times.ToList();

                return View();
            }
        }

    }
}
