﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sgo_back_end.Models;

namespace sgo_back_end.Controllers
{
    [Authorize]
    public class VoluntariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoluntariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Voluntarios
        public async Task<IActionResult> Index()
        {
              return View(await _context.Voluntarios.ToListAsync());
        }

        // GET: Voluntarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Voluntarios == null)
            {
                return NotFound();
            }

            var voluntario = await _context.Voluntarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voluntario == null)
            {
                return NotFound();
            }

            return View(voluntario);
        }

        // GET: Voluntarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Voluntarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Funcao,Disponivel,Nome,Telefone,Email")] Voluntario voluntario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voluntario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voluntario);
        }

        // GET: Voluntarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Voluntarios == null)
            {
                return NotFound();
            }

            var voluntario = await _context.Voluntarios.FindAsync(id);
            if (voluntario == null)
            {
                return NotFound();
            }
            return View(voluntario);
        }

        // POST: Voluntarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Funcao,Disponivel,Nome,Telefone,Email")] Voluntario voluntario)
        {
            if (id != voluntario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voluntario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoluntarioExists(voluntario.Id))
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
            return View(voluntario);
        }

        // GET: Voluntarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Voluntarios == null)
            {
                return NotFound();
            }

            var voluntario = await _context.Voluntarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voluntario == null)
            {
                return NotFound();
            }

            return View(voluntario);
        }

        // POST: Voluntarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Voluntarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Voluntarios'  is null.");
            }
            var voluntario = await _context.Voluntarios.FindAsync(id);
            if (voluntario != null)
            {
                _context.Voluntarios.Remove(voluntario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoluntarioExists(int id)
        {
          return _context.Voluntarios.Any(e => e.Id == id);
        }
    }
}
