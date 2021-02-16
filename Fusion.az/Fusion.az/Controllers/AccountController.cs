using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fusion.az.DAL;
using Fusion.az.Models;
using Fusion.az.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Fusion.az.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            AccountViewModel model = new AccountViewModel()
            {
                Bio = _context.Bios.FirstOrDefault(),
            };
           
            return View(model);
        } 

        public IActionResult Register()
        {
        RegisterViewModel model = new RegisterViewModel()
            {
                Bio = _context.Bios.FirstOrDefault(),
               
            };
            return View(model);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            RegisterViewModel model = new RegisterViewModel()
            {
                Bio = _context.Bios.FirstOrDefault(),
            };
            
            if (!ModelState.IsValid) return View(model);
            
           
            if (!register.PhoneNumber.Contains("(") && !register.PhoneNumber.Contains(")") && !register.PhoneNumber.Contains("+"))
            {
                ModelState.AddModelError("PhoneNumber", ("Format must be '(+County number code)"));
                return View(model);
            }
            string username = register.UserName ?? register.Email;
            AppUser newUser = new AppUser
            {
                Name = register.Name,
                Surname = register.Surname,
                PhoneNumber = register.PhoneNumber,
                Email = register.Email,
                UserName=username,
               
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            } 
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
