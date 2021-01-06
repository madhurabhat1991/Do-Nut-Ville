using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assgn3_Bhat_Madhura.Models;

namespace Assgn3_Bhat_Madhura.Controllers
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
            ViewBag.CurrentMenu = "Index";
            return View();
        }

        [Route("menu")]
        public IActionResult Menu()
        {
            ViewBag.CurrentMenu = "Menu";
            return View();
        }

        [Route("offers")]
        public IActionResult Offers()
        {
            ViewBag.CurrentMenu = "Offers";
            return View();
        }

        [Route("location")]
        public IActionResult Location()
        {
            ViewBag.CurrentMenu = "Location";
            return View();
        }

        [Route("mug")]
        public IActionResult Mug()
        {
            ViewBag.CurrentMenu = "Mug";
            return View();
        }

        public IActionResult Subscribe(EmailModel formInfo)
        {
            ViewBag.EmailAddress = formInfo.EmailAddress;
            return View("ThankYou", formInfo);
        }

        public IActionResult MugPurchase(EmailModel mugInfo)
        {
            ViewBag.FirstName = mugInfo.FirstName;
            ViewBag.LastName = mugInfo.LastName;
            ViewBag.StreetAddress = mugInfo.StreetAddress;
            ViewBag.PostalCode = mugInfo.PostalCode;
            ViewBag.City = mugInfo.City;
            ViewBag.State = mugInfo.State;
            ViewBag.Sample = mugInfo.Sample;
            return View("MugThankYou", mugInfo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
