using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment3.Models;


namespace COMP003B.Assignment3.Controllers
{
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult RegisterEvent()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPost([FromForm] EventRegistration registration)
        {
            if (!ModelState.IsValid)
            {
                return View(registration);
            }
            return RedirectToAction("Success", registration);

        }

        [HttpGet]
        public IActionResult Success(EventRegistration registration)
        {
            return View(registration);
        }

    }
}
