using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KernelTravelGuides.Data;
using KernelTravelGuides.Models;

namespace KernelTravelGuides.Controllers
{
    public class PackagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PackagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Packages
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Packages.Include(p => p.resorts).Include(p => p.t_spot).Include(p => p.tra_category).Include(p => p.transport);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Packages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Packages == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages
                .Include(p => p.resorts)
                .Include(p => p.t_spot)
                .Include(p => p.tra_category)
                .Include(p => p.transport)
                .FirstOrDefaultAsync(m => m.packages_id == id);
            if (packages == null)
            {
                return NotFound();
            }

            return View(packages);
        }

        // GET: Packages/Create
        public IActionResult Create()
        {
            ViewData["resorts_id"] = new SelectList(_context.Resorts, "resorts_id", "resorts_name");
            ViewData["t_spot_id"] = new SelectList(_context.TouriestSpots, "t_spot_id", "t_spot_name");
            ViewData["tra_category_id"] = new SelectList(_context.TravelCategories, "tra_category_id", "tra_category_name");
            ViewData["transport_id"] = new SelectList(_context.Transports, "transport_id", "transport_name");
            return View();
        }

        // POST: Packages/Createy
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("packages_id,packages_name,packages_desc,packages_or_price,packages_img,resorts_id,tra_category_id,t_spot_id,transport_id,packages_status,created_at")] Packages packages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(packages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["resorts_id"] = new SelectList(_context.Resorts, "resorts_id", "resorts_img1", packages.resorts_id);
            ViewData["t_spot_id"] = new SelectList(_context.TouriestSpots, "t_spot_id", "t_spot_desc", packages.t_spot_id);
            ViewData["tra_category_id"] = new SelectList(_context.TravelCategories, "tra_category_id", "tra_category_desc", packages.tra_category_id);
            ViewData["transport_id"] = new SelectList(_context.Transports, "transport_id", "transport_desc", packages.transport_id);
            return View(packages);
        }

        // GET: Packages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Packages == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages.FindAsync(id);
            if (packages == null)
            {
                return NotFound();
            }
            ViewData["resorts_id"] = new SelectList(_context.Resorts, "resorts_id", "resorts_img1", packages.resorts_id);
            ViewData["t_spot_id"] = new SelectList(_context.TouriestSpots, "t_spot_id", "t_spot_desc", packages.t_spot_id);
            ViewData["tra_category_id"] = new SelectList(_context.TravelCategories, "tra_category_id", "tra_category_desc", packages.tra_category_id);
            ViewData["transport_id"] = new SelectList(_context.Transports, "transport_id", "transport_desc", packages.transport_id);
            return View(packages);
        }

        // POST: Packages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("packages_id,packages_name,packages_desc,packages_or_price,packages_img,resorts_id,tra_category_id,t_spot_id,transport_id,packages_status,created_at")] Packages packages)
        {
            if (id != packages.packages_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(packages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackagesExists(packages.packages_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["resorts_id"] = new SelectList(_context.Resorts, "resorts_id", "resorts_img1", packages.resorts_id);
            ViewData["t_spot_id"] = new SelectList(_context.TouriestSpots, "t_spot_id", "t_spot_desc", packages.t_spot_id);
            ViewData["tra_category_id"] = new SelectList(_context.TravelCategories, "tra_category_id", "tra_category_desc", packages.tra_category_id);
            ViewData["transport_id"] = new SelectList(_context.Transports, "transport_id", "transport_desc", packages.transport_id);
            return View(packages);
        }

        // GET: Packages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Packages == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages
                .Include(p => p.resorts)
                .Include(p => p.t_spot)
                .Include(p => p.tra_category)
                .Include(p => p.transport)
                .FirstOrDefaultAsync(m => m.packages_id == id);
            if (packages == null)
            {
                return NotFound();
            }

            return View(packages);
        }

        // POST: Packages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Packages == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Packages'  is null.");
            }
            var packages = await _context.Packages.FindAsync(id);
            if (packages != null)
            {
                _context.Packages.Remove(packages);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PackagesExists(int id)
        {
          return (_context.Packages?.Any(e => e.packages_id == id)).GetValueOrDefault();
        }
    }
}
