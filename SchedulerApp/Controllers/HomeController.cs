using Microsoft.AspNetCore.Mvc;
using SchedulerApp.Data;
using SchedulerApp.Models;
using System.Diagnostics;

namespace SchedulerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
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

        public JsonResult GetEvents()
        {
            var events = _db.Events.Select(e => new {
                e.Subject,
                e.Description,
                e.Start,
                e.End,
                e.ThemeColor,
                e.IsFUllDate
            }).ToList();

            return Json(events);
        }



    }
}
