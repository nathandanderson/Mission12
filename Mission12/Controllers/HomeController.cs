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
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAll()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        //private TestISignupRepository repo { get; set; }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new Appointment());
        }

        [HttpPost]
        public IActionResult Signup(Appointment appointment)
        {

            if (ModelState.IsValid)
            {
                repo.SaveAppointment(appointment);

                return RedirectToPage("/Index");
            }
            else
            {
                return View();
            }
        }

    }
}
