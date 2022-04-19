using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace myEntityFrameWorkProject_01.Models
{
    public class TblKitaplarsController : Controller
    {
        private readonly aKutuphaneContext _context;

        public TblKitaplarsController(aKutuphaneContext context)
        {
            _context = context;
        }

        // GET: TblKitaplars
        public async Task<IActionResult> Index()
        {
            var aKutuphaneContext = _context.TblKitaplars.Include(t => t.Tur).Include(t => t.YayinEvi).Include(t => t.Yazar);
            return View(await aKutuphaneContext.ToListAsync());
        }

        // GET: TblKitaplars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblKitaplar = await _context.TblKitaplars
                .Include(t => t.Tur)
                .Include(t => t.YayinEvi)
                .Include(t => t.Yazar)
                .FirstOrDefaultAsync(m => m.Isbn == id);
            if (tblKitaplar == null)
            {
                return NotFound();
            }

            return View(tblKitaplar);
        }

        // GET: TblKitaplars/Create
        public IActionResult Create()
        {
            ViewData["TurId"] = new SelectList(_context.TblTurlers, "Id", "TurAd");
            ViewData["YayinEviId"] = new SelectList(_context.TblYayinevleris, "Id", "YayineviAd");
            ViewData["YazarId"] = new SelectList(_context.TblYazarlars, "Id", "YazarAd");
            return View();
        }

        // POST: TblKitaplars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Isbn,KitapAd,KitapSayfaSayisi,KitapStokAdedi,TurId,YazarId,YayinEviId")] TblKitaplar tblKitaplar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblKitaplar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TurId"] = new SelectList(_context.TblTurlers, "Id", "TurAd", tblKitaplar.TurId);
            ViewData["YayinEviId"] = new SelectList(_context.TblYayinevleris, "Id", "YayineviAd", tblKitaplar.YayinEviId);
            ViewData["YazarId"] = new SelectList(_context.TblYazarlars, "Id", "YazarAd", tblKitaplar.YazarId);
            return View(tblKitaplar);
        }

        // GET: TblKitaplars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblKitaplar = await _context.TblKitaplars.FindAsync(id);
            if (tblKitaplar == null)
            {
                return NotFound();
            }
            ViewData["TurId"] = new SelectList(_context.TblTurlers, "Id", "TurAd", tblKitaplar.TurId);
            ViewData["YayinEviId"] = new SelectList(_context.TblYayinevleris, "Id", "YayineviAd", tblKitaplar.YayinEviId);
            ViewData["YazarId"] = new SelectList(_context.TblYazarlars, "Id", "YazarAd", tblKitaplar.YazarId);
            return View(tblKitaplar);
        }

        // POST: TblKitaplars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Isbn,KitapAd,KitapSayfaSayisi,KitapStokAdedi,TurId,YazarId,YayinEviId")] TblKitaplar tblKitaplar)
        {
            if (id != tblKitaplar.Isbn)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblKitaplar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblKitaplarExists(tblKitaplar.Isbn))
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
            ViewData["TurId"] = new SelectList(_context.TblTurlers, "Id", "TurAd", tblKitaplar.TurId);
            ViewData["YayinEviId"] = new SelectList(_context.TblYayinevleris, "Id", "YayineviAd", tblKitaplar.YayinEviId);
            ViewData["YazarId"] = new SelectList(_context.TblYazarlars, "Id", "YazarAd", tblKitaplar.YazarId);
            return View(tblKitaplar);
        }

        // GET: TblKitaplars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblKitaplar = await _context.TblKitaplars
                .Include(t => t.Tur)
                .Include(t => t.YayinEvi)
                .Include(t => t.Yazar)
                .FirstOrDefaultAsync(m => m.Isbn == id);
            if (tblKitaplar == null)
            {
                return NotFound();
            }

            return View(tblKitaplar);
        }

        // POST: TblKitaplars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblKitaplar = await _context.TblKitaplars.FindAsync(id);
            _context.TblKitaplars.Remove(tblKitaplar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblKitaplarExists(int id)
        {
            return _context.TblKitaplars.Any(e => e.Isbn == id);
        }
    }
}
