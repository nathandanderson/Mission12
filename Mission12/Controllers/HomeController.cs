using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission12.Models;
using Mission12.Models.ViewModels;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {
        private TempleContext daContext { get; set; }

        private ITempleRepository repo { get; set; }
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

            var entries = daContext.Times.Select(i => new Time
            {
                TimeID = i.TimeID,
                Date = i.Date,
                Booked = i.Booked,
                TimeValue = i.TimeValue
            })
          .ToList();

            var x = new TimeViewModel
            {
                Times = entries
            };

            return View(x);
        }

        public IActionResult ViewAll( )
        {
            var entries = daContext.Appointments
                .Include(x => x.Time)
                .OrderBy(x => x.GroupName)
                .ToList();

            return View(entries);
        }

        [HttpGet]
        public IActionResult SignUp(string Date, string TimeValue) { 


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
