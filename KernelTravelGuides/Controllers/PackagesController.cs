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

        private readonly IWebHostEnvironment _hostEnvironment;

        public PackagesController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Packages
        public async Task<IActionResult> Index()
        {
              return _context.Packages != null ? 
                          View(await _context.Packages.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Packages'  is null.");
        }

        // GET: Packages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Packages == null)
            {
                return NotFound();
            }

            var packages = await _context.Packages
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
            return View();
        }

        // POST: Packages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("packages_id,packages_name,packages_desc,packages_or_price,main_image,packages_status,created_at,updated_at")] Packages packages)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(packages.main_image.FileName);
            string extension = Path.GetExtension(packages.main_image.FileName);
            packages.packages_img = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/images/packageimg", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                packages.main_image.CopyToAsync(filestream);
            }

            DateTime created_at = DateTime.UtcNow;

            _context.Add(packages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
         
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
            return View(packages);
        }

        // POST: Packages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("packages_id,packages_name,packages_desc,packages_or_price,packages_img,packages_status,created_at,updated_at")] Packages packages)
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
