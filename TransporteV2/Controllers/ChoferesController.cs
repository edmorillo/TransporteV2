using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TransporteV2.Entidades;

namespace TransporteV2.Controllers
{
    public class ChoferesController : Controller
    {
        private readonly TAIProContext _context;

        public ChoferesController(TAIProContext context)
        {
            _context = context;
        }

        // GET: Choferes
        public async Task<IActionResult> Index()
        {
            var tAIProContext = _context.Choferes.Include(c => c.IdProvinciaNavigation).Include(c => c.IdTdocuCNavigation);
            return View(await tAIProContext.ToListAsync());
        }

        // GET: Choferes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Choferes == null)
            {
                return NotFound();
            }

            var chofere = await _context.Choferes
                .Include(c => c.IdProvinciaNavigation)
                .Include(c => c.IdTdocuCNavigation)
                .FirstOrDefaultAsync(m => m.IdChofer == id);
            if (chofere == null)
            {
                return NotFound();
            }

            return View(chofere);
        }

        // GET: Choferes/Create
        public IActionResult Create()
        {
            ViewData["IdProvincia"] = new SelectList(_context.Provincia, "IdProvincia", "Provincia");
            ViewData["IdTdocuC"] = new SelectList(_context.TdocumentoCs, "IdTdocuC", "Detalle");
            return View();
        }

        // POST: Choferes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdChofer,Nombre,Apellido,FechaNacimiento,IdTdocuC,Ndocumento,NuTramite,Cuil,IdProvincia,Direccion,Email,Celular,FechaAlta,FechaBaja")] Chofere chofere)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chofere);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProvincia"] = new SelectList(_context.Provincia, "IdProvincia", "Provincia", chofere.IdProvincia);
            ViewData["IdTdocuC"] = new SelectList(_context.TdocumentoCs, "IdTdocuC", "Detalle", chofere.IdTdocuC);
            return View(chofere);
        }

        // GET: Choferes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Choferes == null)
            {
                return NotFound();
            }

            var chofere = await _context.Choferes.FindAsync(id);
            if (chofere == null)
            {
                return NotFound();
            }
            ViewData["IdProvincia"] = new SelectList(_context.Provincia, "IdProvincia", "Provincia", chofere.IdProvincia);
            ViewData["IdTdocuC"] = new SelectList(_context.TdocumentoCs, "IdTdocuC", "Detalle", chofere.IdTdocuC);
            return View(chofere);
        }

        // POST: Choferes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdChofer,Nombre,Apellido,FechaNacimiento,IdTdocuC,Ndocumento,NuTramite,Cuil,IdProvincia,Direccion,Email,Celular,FechaAlta,FechaBaja")] Chofere chofere)
        {
            if (id != chofere.IdChofer)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chofere);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChofereExists(chofere.IdChofer))
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
            ViewData["IdProvincia"] = new SelectList(_context.Provincia, "IdProvincia", "Provincia", chofere.IdProvincia);
            ViewData["IdTdocuC"] = new SelectList(_context.TdocumentoCs, "IdTdocuC", "Detalle", chofere.IdTdocuC);
            return View(chofere);
        }

        // GET: Choferes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Choferes == null)
            {
                return NotFound();
            }

            var chofere = await _context.Choferes
                .Include(c => c.IdProvinciaNavigation)
                .Include(c => c.IdTdocuCNavigation)
                .FirstOrDefaultAsync(m => m.IdChofer == id);
            if (chofere == null)
            {
                return NotFound();
            }

            return View(chofere);
        }

        // POST: Choferes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Choferes == null)
            {
                return Problem("Entity set 'TAIProContext.Choferes'  is null.");
            }
            var chofere = await _context.Choferes.FindAsync(id);
            if (chofere != null)
            {
                _context.Choferes.Remove(chofere);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChofereExists(int id)
        {
          return (_context.Choferes?.Any(e => e.IdChofer == id)).GetValueOrDefault();
        }
    }
}
