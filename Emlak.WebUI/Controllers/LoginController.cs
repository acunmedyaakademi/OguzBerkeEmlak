using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Emlak.WebUI.Models;
using System;
using Emlak.DAL;
using Emlak.WebUI.Models.DTOs;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using NuGet.Protocol.Plugins;
using System.Security.Claims;

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

        public async Task<IActionResult> Login()
        {
            LoginDTO loginDTO = new LoginDTO();
            return View(loginDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (string.IsNullOrEmpty(loginDTO.UserName) || string.IsNullOrEmpty(loginDTO.Password))
            {
                ViewBag.ErrorMessage = "Kullanıcı adı ve şifre gereklidir.";
                return View("Index");
            }

            var user = await _context.Calisanlar.FirstOrDefaultAsync(u => u.KullaniciAdi == loginDTO.UserName);

            if (user == null)
            {
                ViewBag.ErrorMessage = "Hatalı Kullanıcı Adı";
                return View("Index");
            }

            if (user.KullaniciSifre != loginDTO.Password)
            {
                ViewBag.ErrorMessage = "Hatalı Şifre";
                return View();
            }
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, loginDTO.UserName),
                new Claim(ClaimTypes.Role,"Yonetici")

            };

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authenticationProperty = new AuthenticationProperties
            {
                IsPersistent = loginDTO.RememberMe

            };
            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimIdentity),
                authenticationProperty);

            return RedirectToAction("DashBoard", "CalisanProfil");
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login","Login");
        }
    }
}
