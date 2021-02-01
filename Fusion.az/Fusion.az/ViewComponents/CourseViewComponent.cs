using Fusion.az.DAL;
using Fusion.az.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public CourseViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int num)
        {
            ViewBag.num = num;
            List<Course> courses = _context.Courses.ToList();
            return View(await Task.FromResult(courses));
        }
    }
}
