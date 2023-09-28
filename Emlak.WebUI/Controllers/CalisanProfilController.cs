using Microsoft.AspNetCore.Mvc;
using Emlak.WebUI.Models;
using Emlak.DAL;
using Emlak.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Emlak.WebUI.Controllers
{
    public class CalisanProfilController : Controller
    {
        private readonly SqlDbContext _context;

        public CalisanProfilController(SqlDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var username = User.Identity.Name;

            if (!string.IsNullOrEmpty(username))
            {
                var user = _context.Calisanlar.FirstOrDefault(u => u.KullaniciAdi == username);

                if (user != null)
                {
                   

                    return View(user);
                }
            }

            return View();
        }


        [HttpPost]
        public IActionResult UpdateProfile(Calisan model)
        {
            if (ModelState.IsValid)
            {
                var username = User.Identity.Name;

                if (!string.IsNullOrEmpty(username))
                {
                    var user = _context.Calisanlar.FirstOrDefault(u => u.KullaniciAdi == username);

                    if (user != null)
                    {
                        user.IsimSoyisim = model.IsimSoyisim;
                        user.KullaniciAdi = model.KullaniciAdi;
                        user.KullaniciSifre = model.KullaniciSifre;
                        user.GSM = model.GSM;
                        user.GSM2 = model.GSM2;
                        user.Mail = model.Mail;
                        user.Mail2 = model.Mail2;

                        _context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                }
            }

            return View("Index", model);
        }

        public async Task<IActionResult> DashBoard()
        {
            return View();
        }
    }
}
