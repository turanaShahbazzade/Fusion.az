using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Fusion.az.DAL;
using Fusion.az.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Fusion.az.Areas.FusionAdminRunByAdmin.Controllers
{
    [Area("FusionAdminRunByAdmin")]
    public class FeatureController : Controller
    {
       
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public FeatureController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Features.ToList());
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Feature features = await _context.Features.FindAsync(id);
            if (features == null) return NotFound();
            return View(features);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Feature features = await _context.Features.FindAsync(id);
            if (features == null) return NotFound();
            return View(features);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Feature feature)
        {
            if (id == null) return NotFound();
            Feature featureDb = await _context.Features.FindAsync(id);
            if (featureDb == null) return NotFound();
            if (feature.Photo != null)
            {
                if (feature.Photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photo", "Photo size must be less than 200kb");
                    return View();
                }
                if (!feature.Photo.ContentType.Contains("image/png"))
                {
                    ModelState.AddModelError("Photo", "Icon must be png type");
                    return View();  

                }
                string oldPath = Path.Combine(_env.WebRootPath, "assets/images/icons.png", featureDb.Icon);
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }
                string filename = Guid.NewGuid().ToString() + feature.Photo.FileName;
                string newPath = Path.Combine(_env.WebRootPath, "assets/images/icons.png", filename);
                using (FileStream fileStream = new FileStream(newPath, FileMode.Create))
                {
                    await feature.Photo.CopyToAsync(fileStream);

                }

                featureDb.Icon = filename;
            }

            featureDb.Title = feature.Title;
            featureDb.Description = feature.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
