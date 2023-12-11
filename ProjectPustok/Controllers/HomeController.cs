using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectPustok.Data;

namespace ProjectPustok.Controllers
{
    public class HomeController : Controller
    {
        PustokDbContext _db { get; }

        public HomeController(PustokDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _db.Sliders.ToListAsync();
            return View(sliders);
        }
    }
}
