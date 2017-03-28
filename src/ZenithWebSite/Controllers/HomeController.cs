using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenithSociety.Models;
using ZenithSociety.Data;

namespace ZenithSociety.Controllers {
    public class HomeController : Controller {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context) {
            _context = context;
        }

        private List<Event> getWeekEvents(DateTime date) {
            DateTime start = date.Date.AddDays(-(int)date.DayOfWeek + 1);
            DateTime end = start.AddDays(7);
            var events = _context.Events.Where(e => e.EventFromDate >= start
            & e.EventFromDate < end
            & e.IsActive == true).ToList();
            return events;
        }

        public IActionResult Index()
        {
            return View(getWeekEvents(DateTime.Today));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
