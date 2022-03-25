using appointmentMaker.Models;
using Microsoft.AspNetCore.Mvc;

namespace appointmentMaker.Controllers
{
    public class appoitmentController : Controller
    {
        static List<appointmentModel> appointments = new List<appointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(appointmentModel appointment)
        {
            appointments.Add(appointment);
            return View("Details", appointment);
        }
    }
}
