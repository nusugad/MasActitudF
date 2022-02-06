using MasActitud.Data;
using MasActitud.Models;
using MasActitud.Utilidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasActitud.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class Trabajadores : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly MasActitud.Utilidades.ICalculos calculos;

        public Trabajadores(ApplicationDbContext context, MasActitud.Utilidades.ICalculos calculos)
        {
            _context = context;
            this.calculos = calculos;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trabajador.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
               trabajador.Edad = calculos.calculoEdad(trabajador.fechaNacimiento);
                _context.Trabajador.Add(trabajador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) 
            {
                return NotFound();
            }

            var trabajador = _context.Trabajador.Find(id.ToString());

            if (trabajador == null) 
            {
                return NotFound();
            }

            return View(trabajador);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                trabajador.Edad = calculos.calculoEdad(trabajador.fechaNacimiento);
                _context.Trabajador.Update(trabajador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(trabajador);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabajador = _context.Trabajador.Find(id.ToString());

            if (trabajador == null)
            {
                return NotFound();
            }

            return View(trabajador);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRegistro(int? id)
        {
            var usuario = await _context.Trabajador.FindAsync(id.ToString());

            if (usuario == null)
            {
                return View();
            }

            _context.Trabajador.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
