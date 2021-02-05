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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index() 
        {
            ViewBag.CourseCount = _context.Courses.Count();
            List<Course> courses = _context.Courses.Where(c=>c.IsDeleted==false).ToList();
            return View(courses);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Course courses = await _context.Courses.FindAsync(id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (Course course)
        {
           
            if (course.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo is required");
                return View();
            }
            if (!course.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Photo type is required");
                return View();
            } 
            if (course.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photo", "Photo size must be less than 200kb");
                return View();
            } 
            string filename = Guid.NewGuid().ToString() + course.Photo.FileName;
            string path = Path.Combine(_env.WebRootPath, "assets/images/Course", filename);
            using(FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                await course.Photo.CopyToAsync(fileStream);
            }
            course.Image = filename;
            course.IsDeleted = false;
            await  _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Course courses = await _context.Courses.FindAsync(id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Course course)
        {
            if (id == null) return NotFound();
            Course courseDb = await _context.Courses.FindAsync(id);
            if (courseDb == null) return NotFound();
            if (course.Photo != null)
            {
                if (course.Photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photo", "Photo size must be less than 200kb");
                    return View();
                }
                if (!course.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Icon must be png type");
                    return View();

                }
                string oldPath = Path.Combine(_env.WebRootPath, "assets/images/Course", courseDb.Image);
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }
                string filename = Guid.NewGuid().ToString() + course.Photo.FileName;
                string newPath = Path.Combine(_env.WebRootPath, "assets/images/Course", filename);
                using (FileStream fileStream = new FileStream(newPath, FileMode.Create))
                {
                    await course.Photo.CopyToAsync(fileStream);

                }

                courseDb.Image = filename;
            }

            courseDb.Name = course.Name;
            courseDb.Description = course.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task <IActionResult> Delete(int? id)
        {
           
            if (id == null) return NotFound();
            Course courses = await _context.Courses.FindAsync(id);
            if (courses == null) return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")] 
        public async Task<IActionResult> DeletePost(int? id)
        {

            if (id == null) return NotFound();
            Course courses = await _context.Courses.FindAsync(id);
            if (courses == null) return NotFound();
            string path = Path.Combine(_env.WebRootPath, "assets/images/Course", courses.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Courses.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
