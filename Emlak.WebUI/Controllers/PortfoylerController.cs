using Microsoft.AspNetCore.Mvc;
using Emlak.DAL;
using Emlak.Entities;
using System.Linq;
using System;

namespace Emlak.WebUI.Controllers
{
    public class PortfoylerController : Controller
    {
        private readonly SqlDbContext _context;

        public PortfoylerController(SqlDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, int page = 1)
        {
            var portfoyler = _context.Portfoyler.ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                portfoyler = portfoyler
                    .Where(p => p.PortfoyAdres.Contains(searchString) || p.PortfoyTipi.Contains(searchString))
                    .ToList();
            }

            int pageSize = 10;
            var paginatedPortfoyler = portfoyler.Skip((page - 1) * pageSize).Take(pageSize);

            var model = new
            {
                Portfoyler = paginatedPortfoyler,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)portfoyler.Count / pageSize),
                SearchString = searchString
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var portfoy = _context.Portfoyler.FirstOrDefault(p => p.PortfoyID == id);

            if (portfoy == null)
            {
                return NotFound();
            }

            return View(portfoy);
        }
    }
}
