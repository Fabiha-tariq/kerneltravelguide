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
using Microsoft.AspNetCore.Authorization;

namespace KernelTravelGuides.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ResortsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ResortsController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
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
        public async Task<IActionResult> Create([Bind("resorts_id,resorts_name,resorts_location,main_image1,main_image2,main_image3,resorts_status,created_at")] Resorts resorts)
        {
            // Img 1
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(resorts.main_image1.FileName);
            string extension = Path.GetExtension(resorts.main_image1.FileName);
            resorts.resorts_img1 = filename = filename + extension;
            string path = Path.Combine(wwwRootPath + "/images/resortimg", filename);
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                resorts.main_image1.CopyToAsync(filestream);
            }

            // Img 2
            string wwwRootPath2 = _hostEnvironment.WebRootPath;
            string filename2 = Path.GetFileNameWithoutExtension(resorts.main_image2.FileName);
            string extension2 = Path.GetExtension(resorts.main_image2.FileName);
            resorts.resorts_img2 = filename2 = filename2 + extension2;
            string path2 = Path.Combine(wwwRootPath2 + "/images/resortimg", filename2);
            using (var filestream2 = new FileStream(path2, FileMode.Create))
            {
                resorts.main_image2.CopyToAsync(filestream2);
            }

            // Img 3
            string wwwRootPath3 = _hostEnvironment.WebRootPath;
            string filename3 = Path.GetFileNameWithoutExtension(resorts.main_image3.FileName);
            string extension3 = Path.GetExtension(resorts.main_image3.FileName);
            resorts.resorts_img3 = filename3 = filename3 + extension3;
            string path3 = Path.Combine(wwwRootPath3 + "/images/resortimg", filename3);
            using (var filestream3 = new FileStream(path3, FileMode.Create))
            {
                resorts.main_image3.CopyToAsync(filestream3);
            }


            _context.Add(resorts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
         

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
        public async Task<IActionResult> Edit(int id, [Bind("resorts_id,resorts_name,resorts_location,resorts_img1,resorts_img2,resorts_img3,resorts_status,created_at")] Resorts resorts)
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
            // img 1
            //var img = await _context.Resorts.FindAsync(id);
            //var image = Path.Combine(_hostEnvironment.WebRootPath, "images/resortimg", img.resorts_img1);

            //if (System.IO.File.Exists(image))
            //{
            //    System.IO.File.Delete(image);
            //}
            // img 2
            //var image2 = Path.Combine(_hostEnvironment.WebRootPath, "images/resortimg", (await _context.Resorts.FindAsync(id)).resorts_img2);

            //if (System.IO.File.Exists(image2))
            //{
            //    System.IO.File.Delete(image2);
            //}
            // img 3
            //var img3 = await _context.Resorts.FindAsync(id);
            //var image3 = Path.Combine(_hostEnvironment.WebRootPath, "images/resortimg", img3.resorts_img3);

            //if (System.IO.File.Exists(image3))
            //{
            //    System.IO.File.Delete(image3);
            //}

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
