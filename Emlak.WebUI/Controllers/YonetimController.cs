using Microsoft.AspNetCore.Mvc;
using Emlak.DAL;
using Emlak.Entities;
using Emlak.WebUI.Models.DTOs;
using System.Linq;

namespace Emlak.WebUI.Controllers
{
    public class YonetimController : Controller
    {
        private readonly SqlDbContext _context;

        public YonetimController(SqlDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, int page = 1)
        {
            var calisanlar = _context.Calisanlar.ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                calisanlar = calisanlar
                    .Where(c => c.IsimSoyisim.Contains(searchString))
                    .ToList();
            }

            int pageSize = 10;
            var paginatedCalisanlar = calisanlar.Skip((page - 1) * pageSize).Take(pageSize);

            var model = new
            {
                Calisanlar = paginatedCalisanlar,
                CurrentPage = page,
                TotalPages = (int)System.Math.Ceiling((double)calisanlar.Count / pageSize),
                SearchString = searchString
            };

            var user = new YonetimDTO
            {
                UserID = 1,
                RoleID = 1
            };

            if (!IsUserAdmin(user))
            {
                return View("Unauthorized");
            }

            return View(model);
        }

        private bool IsUserAdmin(YonetimDTO user)
        {
            return user.RoleID == 1;
        }
    }
}
