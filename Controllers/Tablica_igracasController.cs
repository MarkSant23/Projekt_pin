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
    

        public async Task<IActionResult> Index()
        {
            var context = _context.Tablica_igraca.Include(t => t.klub);
            return View(await _context.Tablica_igraca.ToListAsync());
        }



        public IActionResult Create(int id = 0)
        {
            if (id == 0)
            return View(new Tablica_igraca());
            else
                return View(_context.Tablica_igraca.Find(id));

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detalji(string Pozicija)
        {

            var poz = (from e in _context.Tablica_igraca
                       where Pozicija == e.pozicija
                       select e);
            await _context.SaveChangesAsync();
            return View(poz);

        }

        [HttpGet]
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
                return View("Index", new Tablica_igraca[] { tablica_igraca });
            }
            return View(tablica_igraca);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var tablica_igraca = await _context.Tablica_igraca.FindAsync(id);
            _context.Tablica_igraca.Remove(tablica_igraca);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tablica_igraca = await _context.Tablica_igraca.FindAsync(id);
            _context.Tablica_igraca.Remove(tablica_igraca);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Tablica_igracaExists(int id)
        {
            return _context.Tablica_igraca.Any(e => e.ID == id);
        }


    }
}
