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
    public class ResortsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResortsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Resorts
        public async Task<IActionResult> Index()
        {
              return _context.Resorts != null ? 
                          View(await _context.Resorts.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Resorts'  is null.");
        }

        // GET: Resorts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Resorts == null)
            {
                return NotFound();
            }

            var resorts = await _context.Resorts
                .FirstOrDefaultAsync(m => m.resorts_id == id);
            if (resorts == null)
            {
                return NotFound();
            }

            return View(resorts);
        }

        // GET: Resorts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Resorts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("resorts_id,resorts_name,resorts_location,resorts_img1,resorts_img2,resorts_img3,resorts_status,created_at,updated_at")] Resorts resorts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resorts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resorts);
        }

        // GET: Resorts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Resorts == null)
            {
                return NotFound();
            }

            var resorts = await _context.Resorts.FindAsync(id);
            if (resorts == null)
            {
                return NotFound();
            }
            return View(resorts);
        }

        // POST: Resorts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("resorts_id,resorts_name,resorts_location,resorts_img1,resorts_img2,resorts_img3,resorts_status,created_at,updated_at")] Resorts resorts)
        {
            if (id != resorts.resorts_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resorts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResortsExists(resorts.resorts_id))
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
            return View(resorts);
        }

        // GET: Resorts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Resorts == null)
            {
                return NotFound();
            }

            var resorts = await _context.Resorts
                .FirstOrDefaultAsync(m => m.resorts_id == id);
            if (resorts == null)
            {
                return NotFound();
            }

            return View(resorts);
        }

        // POST: Resorts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Resorts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Resorts'  is null.");
            }
            var resorts = await _context.Resorts.FindAsync(id);
            if (resorts != null)
            {
                _context.Resorts.Remove(resorts);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResortsExists(int id)
        {
          return (_context.Resorts?.Any(e => e.resorts_id == id)).GetValueOrDefault();
        }
    }
}
