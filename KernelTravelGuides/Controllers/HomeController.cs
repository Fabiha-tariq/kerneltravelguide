using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KernelTravelGuides.Data;
using KernelTravelGuides.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KernelTravelGuides.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            var applicationDbContext2 = _context.Feedback;
            return View(await applicationDbContext2.ToListAsync());
         
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Packages()
        {
            var applicationDbContext = _context.Packages.Include(p => p.resorts).Include(p => p.t_spot).Include(p => p.tra_category).Include(p => p.transport);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> TouriestSpots()
        {
                var applicationDbContext = _context.TouriestSpots.Include(t => t.country);
                return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> TravelInfo()
        {
                var applicationDbContext2 = _context.TravelCategories;
                return View(await applicationDbContext2.ToListAsync());
        }
        public async Task<IActionResult> TransportInfo()
        {
            var applicationDbContext2 = _context.Transports;
            return View(await applicationDbContext2.ToListAsync());
        }
        public async Task<IActionResult> HotelInfo()
        {
            var applicationDbContext3 = _context.Hotels;
            return View(await applicationDbContext3.ToListAsync());

        }
        public async Task<IActionResult> RestaurantInfo()
        {
            var applicationDbContext3 = _context.Restaurants;
            return View(await applicationDbContext3.ToListAsync());
        }
        public async Task<IActionResult> ResortInfo()
        {
            var applicationDbContext3 = _context.Resorts;
            return View(await applicationDbContext3.ToListAsync());
        }
        
        // get method for user contact us page
        public IActionResult Contact()
        {
            return View();
        }

        // post method for user contact us form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact([Bind("messages_id,messages_user_name,messages_desc,messages_status,messages_content,created_at")] Messages messages)
        {

            _context.Add(messages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            return View(messages);
        }

        public async Task<IActionResult> Feedback()
        {
            var applicationDbContext35 = _context.Feedback;
            return View(await applicationDbContext35.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}