using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Emlak.WebUI.Models;
using System;
using Emlak.DAL;

namespace Emlak.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SqlDbContext _context;

        public LoginController(SqlDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "Kullanıcı adı ve şifre gereklidir.";
                return View("Index");
            }

            var user = await _context.Calisanlar.FirstOrDefaultAsync(u => u.KullaniciAdi == username);

            if (user == null)
            {
                ViewBag.ErrorMessage = "Hatalı Kullanıcı Adı";
                return View("Index");
            }

            if (user.KullaniciSifre != password)
            {
                ViewBag.ErrorMessage = "Hatalı Şifre";
                return View("Index");
            }

            return RedirectToAction("Dashboard", "Profilim");
        }
    }
}
