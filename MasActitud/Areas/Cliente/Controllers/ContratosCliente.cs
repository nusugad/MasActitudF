using MasActitud.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasActitud.Areas.Cliente.Controllers
{
    [Authorize]
    [Area("Cliente")]
    public class ContratosCliente : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContratosCliente(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contrato.ToListAsync());
        }

    }
}
