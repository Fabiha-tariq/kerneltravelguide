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
    public class TransportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Transports
        public async Task<IActionResult> Index()
        {
              return _context.Transports != null ? 
                          View(await _context.Transports.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Transports'  is null.");
        }

        // GET: Transports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transports == null)
            {
                return NotFound();
            }

            var transport = await _context.Transports
                .FirstOrDefaultAsync(m => m.transport_id == id);
            if (transport == null)
            {
                return NotFound();
            }

            return View(transport);
        }

        // GET: Transports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("transport_id,transport_name,transport_number,transport_price,transport_rating,transport_desc,transport_status,created_at")] Transport transport)
        {

            
                _context.Add(transport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            return View(transport);
        }

        // GET: Transports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transports == null)
            {
                return NotFound();
            }

            var transport = await _context.Transports.FindAsync(id);
            if (transport == null)
            {
                return NotFound();
            }
            return View(transport);
        }

        // POST: Transports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("transport_id,transport_name,transport_number,transport_price,transport_rating,transport_desc,transport_status,created_at")] Transport transport)
        {
            if (id != transport.transport_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportExists(transport.transport_id))
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
            return View(transport);
        }

        // GET: Transports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transports == null)
            {
                return NotFound();
            }

            var transport = await _context.Transports
                .FirstOrDefaultAsync(m => m.transport_id == id);
            if (transport == null)
            {
                return NotFound();
            }

            return View(transport);
        }

        // POST: Transports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transports == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Transports'  is null.");
            }
            var transport = await _context.Transports.FindAsync(id);
            if (transport != null)
            {
                _context.Transports.Remove(transport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportExists(int id)
        {
          return (_context.Transports?.Any(e => e.transport_id == id)).GetValueOrDefault();
        }
    }
}
