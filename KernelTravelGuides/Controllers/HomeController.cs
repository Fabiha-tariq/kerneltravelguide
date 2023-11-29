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
    

        public IActionResult HotelInfo()
        {
            return View();
        }

        public IActionResult RestaurantInfo()
        {
            return View();
        }

        public IActionResult ResortInfo()
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