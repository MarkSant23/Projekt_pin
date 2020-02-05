using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pin_projekt.Models;

namespace pin_projekt.Controllers
{
    public class Tablica_igracasController : Controller
    {
        private readonly Tablica_igracaContext _context;

        public Tablica_igracasController(Tablica_igracaContext context)
        {
            _context = context;
        }
    
        // GET: Tablica_igracas
        public async Task<IActionResult> Index()
        {
            var context = _context.Tablica_igraca.Include(t => t.klub);
            return View(await _context.Tablica_igraca.ToListAsync());
        }


        // GET: Tablica_igracas/Create
        public IActionResult Create(int id = 0)
        {
            if (id == 0)
            return View(new Tablica_igraca());
            else
                return View(_context.Tablica_igraca.Find(id));

        }

        // POST: Tablica_igracas/DodajIliUredi
        [HttpPost]
        [ValidateAntiForgeryToken]
        

        // GET: Tablica_igracas/Edit/5
        public async Task<IActionResult> Detalji(string Pozicija)
        {

            var poz = (from e in _context.Tablica_igraca
                       where Pozicija == e.pozicija
                       select e);
            await _context.SaveChangesAsync();
            return View(poz);

        }

        // POST: Tablica_igracas/Edit/5       [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,prezime,pozicija,klub")] Tablica_igraca tablica_igraca)
        {
            if (id != tablica_igraca.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tablica_igraca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tablica_igracaExists(tablica_igraca.ID))
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
            return View(tablica_igraca);
        }

        // GET: Tablica_igracas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var tablica_igraca = await _context.Tablica_igraca.FindAsync(id);
            _context.Tablica_igraca.Remove(tablica_igraca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // POST: Tablica_igracas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tablica_igraca = await _context.Tablica_igraca.FindAsync(id);
            _context.Tablica_igraca.Remove(tablica_igraca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tablica_igracaExists(int id)
        {
            return _context.Tablica_igraca.Any(e => e.ID == id);
        }
        // GET: Tablica_igracas/Details/3
    //    public async Task<IActionResult> Details(int? id)
    //    {
           
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var igrac = await _context.Tablica_igraca
    //            .FirstOrDefaultAsync(m => m.ID == id);
    //        if (igrac == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(igrac); 
    //    } 

    }
}
