using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KernelTravelGuides.Data;
using KernelTravelGuides.Models;
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
        public IActionResult Touriest(string? t_spot_name)
        {

            var applicationDbContext = _context.TouriestSpots.Include(t => t.country).
            Where(t => t.t_spot_name == t_spot_name).ToList();


            if (t_spot_name == null)
            {
                applicationDbContext = _context.TouriestSpots.Include(t => t.country).ToList();
            }
            return View(applicationDbContext); 
        }
        public async Task<IActionResult> _IndexHeaderPartial()
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

        public async Task<IActionResult> _IndexPackages()
        {
             var applicationDbContext = _context.Packages.Include(p => p.resorts).Include(p => p.t_spot).Include(p => p.tra_category).Include(p => p.transport);
            return View(await applicationDbContext.ToListAsync());

        }

        public async Task<IActionResult> _IndexCountries()
        {
            var applicationDbContext35 = _context.Countries;
            return View(await applicationDbContext35.ToListAsync());
        }

        public async Task<IActionResult> _IndexCities()
        {
            var applicationDbContext = _context.Cities.Include(c => c.country);
            return View(await applicationDbContext.ToListAsync());

        }
    }
}