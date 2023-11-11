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
    public class TravelCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TravelCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TravelCategories
        public async Task<IActionResult> Index()
        {
              return _context.TravelCategories != null ? 
                          View(await _context.TravelCategories.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TravelCategories'  is null.");
        }

        // GET: TravelCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TravelCategories == null)
            {
                return NotFound();
            }

            var travelCategory = await _context.TravelCategories
                .FirstOrDefaultAsync(m => m.tra_category_id == id);
            if (travelCategory == null)
            {
                return NotFound();
            }

            return View(travelCategory);
        }

        // GET: TravelCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("tra_category_id,tra_category_name,tra_category_desc,tra_category_status,created_at,updated_at")] TravelCategory travelCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelCategory);
        }

        // GET: TravelCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TravelCategories == null)
            {
                return NotFound();
            }

            var travelCategory = await _context.TravelCategories.FindAsync(id);
            if (travelCategory == null)
            {
                return NotFound();
            }
            return View(travelCategory);
        }

        // POST: TravelCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("tra_category_id,tra_category_name,tra_category_desc,tra_category_status,created_at,updated_at")] TravelCategory travelCategory)
        {
            if (id != travelCategory.tra_category_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelCategoryExists(travelCategory.tra_category_id))
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
            return View(travelCategory);
        }

        // GET: TravelCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TravelCategories == null)
            {
                return NotFound();
            }

            var travelCategory = await _context.TravelCategories
                .FirstOrDefaultAsync(m => m.tra_category_id == id);
            if (travelCategory == null)
            {
                return NotFound();
            }

            return View(travelCategory);
        }

        // POST: TravelCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TravelCategories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TravelCategories'  is null.");
            }
            var travelCategory = await _context.TravelCategories.FindAsync(id);
            if (travelCategory != null)
            {
                _context.TravelCategories.Remove(travelCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelCategoryExists(int id)
        {
          return (_context.TravelCategories?.Any(e => e.tra_category_id == id)).GetValueOrDefault();
        }
    }
}
