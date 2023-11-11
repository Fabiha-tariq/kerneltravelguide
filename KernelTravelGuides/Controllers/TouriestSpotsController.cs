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
    public class TouriestSpotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TouriestSpotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TouriestSpots
        public async Task<IActionResult> Index()
        {
              return _context.TouriestSpots != null ? 
                          View(await _context.TouriestSpots.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TouriestSpots'  is null.");
        }

        // GET: TouriestSpots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TouriestSpots == null)
            {
                return NotFound();
            }

            var touriestSpots = await _context.TouriestSpots
                .FirstOrDefaultAsync(m => m.t_spot_id == id);
            if (touriestSpots == null)
            {
                return NotFound();
            }

            return View(touriestSpots);
        }

        // GET: TouriestSpots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TouriestSpots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("t_spot_id,t_spot_name,t_spot_locaion,t_spot_desc,t_spot_rating,t_spot_img1,t_spot_img2,t_spot_img3,t_spot_status,created_at,updated_at")] TouriestSpots touriestSpots)
        {
            if (ModelState.IsValid)
            {
                _context.Add(touriestSpots);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(touriestSpots);
        }

        // GET: TouriestSpots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TouriestSpots == null)
            {
                return NotFound();
            }

            var touriestSpots = await _context.TouriestSpots.FindAsync(id);
            if (touriestSpots == null)
            {
                return NotFound();
            }
            return View(touriestSpots);
        }

        // POST: TouriestSpots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("t_spot_id,t_spot_name,t_spot_locaion,t_spot_desc,t_spot_rating,t_spot_img1,t_spot_img2,t_spot_img3,t_spot_status,created_at,updated_at")] TouriestSpots touriestSpots)
        {
            if (id != touriestSpots.t_spot_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(touriestSpots);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TouriestSpotsExists(touriestSpots.t_spot_id))
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
            return View(touriestSpots);
        }

        // GET: TouriestSpots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TouriestSpots == null)
            {
                return NotFound();
            }

            var touriestSpots = await _context.TouriestSpots
                .FirstOrDefaultAsync(m => m.t_spot_id == id);
            if (touriestSpots == null)
            {
                return NotFound();
            }

            return View(touriestSpots);
        }

        // POST: TouriestSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TouriestSpots == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TouriestSpots'  is null.");
            }
            var touriestSpots = await _context.TouriestSpots.FindAsync(id);
            if (touriestSpots != null)
            {
                _context.TouriestSpots.Remove(touriestSpots);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TouriestSpotsExists(int id)
        {
          return (_context.TouriestSpots?.Any(e => e.t_spot_id == id)).GetValueOrDefault();
        }
    }
}
