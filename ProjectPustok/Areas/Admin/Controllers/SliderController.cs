using Microsoft.AspNetCore.Mvc;
using ProjectPustok.Data;
using ProjectPustok.Models;
using System.ComponentModel;

namespace ProjectPustok.Areas.Admin.Controllers
{

    [Area("Admin")]

    public class SliderController : Controller
    {

        readonly PustokDbContext _db;

        public SliderController(PustokDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Slider> sliderList = _db.Sliders;
            return View(sliderList);
        }

        // Get
        public IActionResult Create()
        {
            return View();
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider obj)
        {
            if (ModelState.IsValid)
            {
                await _db.Sliders.AddAsync(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            var sliderFromDb = await _db.Sliders.FindAsync(id);
            /*var sliderFromDbFirst = _db.Sliders.FirstOrDefault(u => u.Id == id);
            var sliderFromDbSingle = _db.Sliders.SingleOrDefault(u => u.Id == id);*/

            if (sliderFromDb == null)
            {
                return NotFound();
            }

            return View(sliderFromDb);
        }

        /*public IActionResult Update(Slider slider)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(slider).State = EntityState.Modified;
                _db.SaveChanges;
            }
        }*/

    }
}
