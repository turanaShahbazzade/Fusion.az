using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Fusion.az.DAL;
using Fusion.az.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Fusion.az.Areas.FusionAdminRunByAdmin.Controllers
{ 
    [Area("FusionAdminRunByAdmin")]
    [Authorize(Roles ="Admin")]
    public class BioController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BioController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env=env;
        }
        public IActionResult Index()
        {
            return View(_context.Bios.FirstOrDefault());
        }
       
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Bio bio = await _context.Bios.FindAsync(id);
            if (bio == null) return NotFound();
            return View(bio);
        }

        public async Task <IActionResult> Update(int? id)

        { 
            if (id == null) return NotFound();
            Bio bioDB = await _context.Bios.FindAsync(id);
            if (bioDB == null) return NotFound();
            return View(bioDB);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id ,Bio bios)
        {
            if (id == null) return NotFound();
            Bio bioD = await _context.Bios.FindAsync(id);
            if (bioD == null) return NotFound();
            if (bios.Photo !=null) {

                if (!bios.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Please Select Photo Type");
                    return View();
                }
                if (bios.Photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photo", "Photo size must be less than 200kb");
                    return View();
                }

                string pathOld = Path.Combine(_env.WebRootPath, "assets/images", bioD.Logo);
                if (System.IO.File.Exists(pathOld))
                {
                    System.IO.File.Delete(pathOld);
                }

                string fileName = Guid.NewGuid().ToString() + bios.Photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "assets/images", fileName);
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    await bios.Photo.CopyToAsync(fileStream);
                }
                bioD.Logo = fileName;
            }
            bioD.Mail = bios.Mail;
            bioD.Phone = bios.Phone;
            bioD.Address = bios.Address;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
