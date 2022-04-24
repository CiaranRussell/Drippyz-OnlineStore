#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DrippyzOnlineStore.Data;
using DrippyzOnlineStore.Models;
using DrippyzOnlineStore.Areas;

namespace DrippyzOnlineStore.Areas.Admin.Controller1
{
    [Area("Admin")]
    public class BrandNamesController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public BrandNamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BrandNames
        public async Task<IActionResult> Index()
        {
            return View(await _context.BrandNames.ToListAsync());
        }

        // GET: Admin/BrandNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandNames = await _context.BrandNames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brandNames == null)
            {
                return NotFound();
            }

            return View(brandNames);
        }

        // GET: Admin/BrandNames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BrandNames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand")] BrandNames brandNames)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brandNames);
                await _context.SaveChangesAsync();
                TempData["save"] = "New Brand has been Added!";
                return RedirectToAction(nameof(Index));
            }
            return View(brandNames);
        }

        // GET: Admin/BrandNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandNames = await _context.BrandNames.FindAsync(id);
            if (brandNames == null)
            {
                return NotFound();
            }
            return View(brandNames);
        }

        // POST: Admin/BrandNames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand")] BrandNames brandNames)
        {
            if (id != brandNames.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brandNames);
                    TempData["edit"] = "Brand Name has been Updated";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandNamesExists(brandNames.Id))
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
            return View(brandNames);
        }

        // GET: Admin/BrandNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandNames = await _context.BrandNames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brandNames == null)
            {
                return NotFound();
            }

            return View(brandNames);
        }

        // POST: Admin/BrandNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brandNames = await _context.BrandNames.FindAsync(id);
            _context.BrandNames.Remove(brandNames);
            await _context.SaveChangesAsync();
            TempData["delete"] = "Brand has been deleted";
            return RedirectToAction(nameof(Index));
        }

        private bool BrandNamesExists(int id)
        {
            return _context.BrandNames.Any(e => e.Id == id);
        }
    }
}
