using Microsoft.AspNetCore.Mvc;
using Emlak.DAL;
using Emlak.Entities;
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

        public IActionResult Index()
        {
            var kullaniciAdi = User.Identity.Name;
            var kullanici = _context.Calisanlar.FirstOrDefault(c => c.KullaniciAdi == kullaniciAdi);

            var portfoy = _context.Portfoyler.FirstOrDefault(p => p.CalisanId == kullanici.ID);

            return View(portfoy);
        }

        public IActionResult Edit(int id)
        {
            var kullaniciAdi = User.Identity.Name;
            var kullanici = _context.Calisanlar.FirstOrDefault(c => c.KullaniciAdi == kullaniciAdi);

            var portfoy = _context.Portfoyler.FirstOrDefault(p => p.ID == id && p.CalisanId == kullanici.ID);

            if (portfoy == null)
            {
                return RedirectToAction("Index"); // Ana sayfaya yönlendir
            }

            return View(portfoy);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Portfoy model)
        {
            if (ModelState.IsValid)
            {
                var kullaniciAdi = User.Identity.Name;
                var kullanici = _context.Calisanlar.FirstOrDefault(c => c.KullaniciAdi == kullaniciAdi);

                if (kullanici != null)
                {
                    model.CalisanId = kullanici.ID;
                    _context.Portfoyler.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
    }
}
