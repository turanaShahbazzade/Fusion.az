using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fusion.az.Extentions;
using Fusion.az.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Fusion.az.Areas.FusionAdminRunByAdmin.Controllers
{ 
    [Area("FusionAdminRunByAdmin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            List<AppUser> users = _userManager.Users.Where(u=>u.isDeleted==false).ToList();  
            return View(users);
        }
    }
}
