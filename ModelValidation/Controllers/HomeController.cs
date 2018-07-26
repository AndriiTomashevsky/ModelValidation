using System;
using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;
namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("MakeBooking", new Appointment { Date = DateTime.Now });
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            return View("Completed", appt);
        }
    }
}