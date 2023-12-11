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

        /* public IActionResult Update(int id)
         {
             Slider slider = _db.Sliders.Find(id);
             if (slider == null)
             {
                 return HttpNotFound();
             }
             return View(slider);
         }

         public IActionResult Update(Slider slider)
         {
             if (ModelState.IsValid)
             {
                 _db.Entry(slider).State = EntityState.Modified;
                 _db.SaveChanges;
             }
         }*/

    }
}
