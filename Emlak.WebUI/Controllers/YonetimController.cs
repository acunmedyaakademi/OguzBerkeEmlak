using Microsoft.AspNetCore.Mvc;
using Emlak.DAL;
using Emlak.Entities;
using Emlak.WebUI.Models.DTOs;
using System.Linq;
using System;

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
                calisanlar = calisanlar.Where(c => c.IsimSoyisim.Contains(searchString)).ToList();
            }

            int pageSize = 10;
            var paginatedCalisanlar = calisanlar.Skip((page - 1) * pageSize).Take(pageSize);

            var model = new
            {
                Calisanlar = paginatedCalisanlar,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)calisanlar.Count / pageSize),
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Calisan model)
        {
            if (ModelState.IsValid)
            {
                _context.Calisanlar.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var calisan = _context.Calisanlar.Find(id);

            if (calisan == null)
            {
                return NotFound();
            }

            return View(calisan);
        }

        [HttpPost]
        public IActionResult Edit(int id, Calisan model)
        {
            if (id != model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingCalisan = _context.Calisanlar.Find(id);

                if (existingCalisan != null)
                {
                    existingCalisan.IsimSoyisim = model.IsimSoyisim;

                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var calisan = _context.Calisanlar.Find(id);

            if (calisan == null)
            {
                return NotFound();
            }

            return View(calisan);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var calisan = _context.Calisanlar.Find(id);

            if (calisan != null)
            {
                _context.Calisanlar.Remove(calisan);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
