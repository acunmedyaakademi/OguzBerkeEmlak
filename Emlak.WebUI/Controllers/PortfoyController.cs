using Microsoft.AspNetCore.Mvc;
using Emlak.DAL;
using Emlak.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Emlak.WebUI.Controllers
{
    public class PortfoyumController : Controller
    {
        private readonly SqlDbContext _context;

        public PortfoyumController(SqlDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, string selectedOption, int page = 1)
        {
            var kullaniciPortfoyler = _context.Portfoyler
                .Where(p => p.Calisan.IsimSoyisim == User.Identity.Name);

            if (!string.IsNullOrEmpty(searchString))
            {
                kullaniciPortfoyler = kullaniciPortfoyler
                    .Where(p => p.PortfoyTipi.Contains(searchString)
                                || p.PortfoyAdres.Contains(searchString)
                                || p.PortfoyDurumu.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(selectedOption))
            {
                kullaniciPortfoyler = kullaniciPortfoyler
                    .Where(p => p.PortfoyTipi == selectedOption);
            }

            int pageSize = 10;
            var paginatedPortfoyler = kullaniciPortfoyler
                .OrderBy(p => p.ID)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var model = new
            {
                Portfoyler = paginatedPortfoyler,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)kullaniciPortfoyler.Count() / pageSize),
                SearchString = searchString,
                SelectedOption = selectedOption,
                OptionList = GetPortfoyOptions() 
            };

            return View(model);
        }

        private List<string> GetPortfoyOptions()
        {
            return new List<string>
            {
                "1+0 Ev",
                "1+1 Ev",
            };
        }
    }
}
