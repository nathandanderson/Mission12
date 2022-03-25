using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var entries = daContext.Times
                .Where(x => x.Booked == true)
                .ToList();

            return View(entries);
        }

        private ITempleRepository repo { get; set; }


        [HttpGet]
        public IActionResult SignUp(int timeid)
        {

            var appointment = daContext.Times.Single(x => x.TimeID == timeid);

            return View(appointment);

        }

        [HttpPost]
        public IActionResult Signup(Time t)
        {

            if (ModelState.IsValid)
            {
                t.Booked = true;
                daContext.Update(t);
                daContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Times = daContext.Times.ToList();

                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int timeid)
        {
            var appointment = daContext.Times.Single(x => x.TimeID == timeid);

            return View("Signup", appointment);
        }

        [HttpPost]
        public IActionResult Edit(Time t)
        {
            daContext.Update(t);
            daContext.SaveChanges();

            return RedirectToAction("ViewAll");
        }

        [HttpGet]
        public IActionResult Delete(int timeid)
        {
            var appointment = daContext.Times.Single(x => x.TimeID == timeid);

            return View(appointment);
        }

        [HttpPost]
        public IActionResult Delete(Time t)
        {
            t.Booked = false;
            t.GroupName = null;
            t.GroupSize = 0;
            t.Email = null;
            t.Phone = null;

            daContext.Update(t);
            daContext.SaveChanges();

            return RedirectToAction("ViewAll");
        }

    }
}
