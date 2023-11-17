using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KernelTravelGuides.Data;
using KernelTravelGuides.Models;
using Microsoft.Extensions.Hosting;


namespace KernelTravelGuides.Controllers
{
    public class TouriestSpotsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TouriestSpotsController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
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
        public async Task<IActionResult> Create([Bind("t_spot_id,t_spot_name,t_spot_locaion,t_spot_desc,t_spot_rating,main_image1,main_image2,main_image3,t_spot_status,created_at")] TouriestSpots touriestSpots)
        {
            // Img 1
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(touriestSpots.main_image1.FileName);
            string extension = Path.GetExtension(touriestSpots.main_image1.FileName);
            touriestSpots.t_spot_img1 = filename = filename + extension;
            string path = Path.Combine(wwwRootPath + "/images/touriestspotsimg", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                touriestSpots.main_image1.CopyToAsync(filestream);
            }

            // Img 2
            string wwwRootPath2 = _hostEnvironment.WebRootPath;
            string filename2 = Path.GetFileNameWithoutExtension(touriestSpots.main_image2.FileName);
            string extension2 = Path.GetExtension(touriestSpots.main_image2.FileName);
            touriestSpots.t_spot_img2 = filename2 = filename2 + extension2;
            string path2 = Path.Combine(wwwRootPath2 + "/images/touriestspotsimg", filename2);
            using (var filestream2 = new FileStream(path2, FileMode.Create))
            {
                touriestSpots.main_image2.CopyToAsync(filestream2);
            }

            // Img 3
            string wwwRootPath3 = _hostEnvironment.WebRootPath;
            string filename3 = Path.GetFileNameWithoutExtension(touriestSpots.main_image3.FileName);
            string extension3 = Path.GetExtension(touriestSpots.main_image3.FileName);
            touriestSpots.t_spot_img3 = filename3 = filename3 + extension3;
            string path3 = Path.Combine(wwwRootPath3 + "/images/touriestspotsimg", filename3);
            using (var filestream3 = new FileStream(path3, FileMode.Create))
            {
                touriestSpots.main_image3.CopyToAsync(filestream3);
            }

            _context.Add(touriestSpots);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
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
        public async Task<IActionResult> Edit(int id, [Bind("t_spot_id,t_spot_name,t_spot_locaion,t_spot_desc,t_spot_rating,t_spot_img1,t_spot_img2,t_spot_img3,t_spot_status,created_at")] TouriestSpots touriestSpots)
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
