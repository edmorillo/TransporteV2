﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TransporteV2.Entidades;

namespace TransporteV2.Controllers
{
    public class LicenciaChofersController : Controller
    {
        private readonly TAIProContext _context;

        public LicenciaChofersController(TAIProContext context)
        {
            _context = context;
        }

        // GET: LicenciaChofers
        public async Task<IActionResult> Index()
        {
            var tAIProContext = _context.LicenciaChofers.Include(l => l.IdChoferNavigation).Include(l => l.IdTiposDocumentosNavigation);
            return View(await tAIProContext.ToListAsync());
        }

        // GET: LicenciaChofers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LicenciaChofers == null)
            {
                return NotFound();
            }

            var licenciaChofer = await _context.LicenciaChofers
                .Include(l => l.IdChoferNavigation)
                .Include(l => l.IdTiposDocumentosNavigation)
                .FirstOrDefaultAsync(m => m.IdLicenciaChofer == id);
            if (licenciaChofer == null)
            {
                return NotFound();
            }

            return View(licenciaChofer);
        }

        // GET: LicenciaChofers/Create
        public IActionResult Create()
        {
            ViewData["IdChofer"] = new SelectList(_context.Choferes, "IdChofer", "IdChofer");
            ViewData["IdTiposDocumentos"] = new SelectList(_context.TiposDocumentos, "IdTiposDocumentos", "IdTiposDocumentos");
            return View();
        }

        // POST: LicenciaChofers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLicenciaChofer,IdChofer,IdTiposDocumentos,FechaVencimiento")] LicenciaChofer licenciaChofer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licenciaChofer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdChofer"] = new SelectList(_context.Choferes, "IdChofer", "IdChofer", licenciaChofer.IdChofer);
            ViewData["IdTiposDocumentos"] = new SelectList(_context.TiposDocumentos, "IdTiposDocumentos", "IdTiposDocumentos", licenciaChofer.IdTiposDocumentos);
            return View(licenciaChofer);
        }

        // GET: LicenciaChofers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LicenciaChofers == null)
            {
                return NotFound();
            }

            var licenciaChofer = await _context.LicenciaChofers.FindAsync(id);
            if (licenciaChofer == null)
            {
                return NotFound();
            }
            ViewData["IdChofer"] = new SelectList(_context.Choferes, "IdChofer", "IdChofer", licenciaChofer.IdChofer);
            ViewData["IdTiposDocumentos"] = new SelectList(_context.TiposDocumentos, "IdTiposDocumentos", "IdTiposDocumentos", licenciaChofer.IdTiposDocumentos);
            return View(licenciaChofer);
        }

        // POST: LicenciaChofers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLicenciaChofer,IdChofer,IdTiposDocumentos,FechaVencimiento")] LicenciaChofer licenciaChofer)
        {
            if (id != licenciaChofer.IdLicenciaChofer)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licenciaChofer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicenciaChoferExists(licenciaChofer.IdLicenciaChofer))
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
            ViewData["IdChofer"] = new SelectList(_context.Choferes, "IdChofer", "IdChofer", licenciaChofer.IdChofer);
            ViewData["IdTiposDocumentos"] = new SelectList(_context.TiposDocumentos, "IdTiposDocumentos", "IdTiposDocumentos", licenciaChofer.IdTiposDocumentos);
            return View(licenciaChofer);
        }

        // GET: LicenciaChofers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LicenciaChofers == null)
            {
                return NotFound();
            }

            var licenciaChofer = await _context.LicenciaChofers
                .Include(l => l.IdChoferNavigation)
                .Include(l => l.IdTiposDocumentosNavigation)
                .FirstOrDefaultAsync(m => m.IdLicenciaChofer == id);
            if (licenciaChofer == null)
            {
                return NotFound();
            }

            return View(licenciaChofer);
        }

        // POST: LicenciaChofers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LicenciaChofers == null)
            {
                return Problem("Entity set 'TAIProContext.LicenciaChofers'  is null.");
            }
            var licenciaChofer = await _context.LicenciaChofers.FindAsync(id);
            if (licenciaChofer != null)
            {
                _context.LicenciaChofers.Remove(licenciaChofer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicenciaChoferExists(int id)
        {
          return _context.LicenciaChofers.Any(e => e.IdLicenciaChofer == id);
        }
    }
}
