using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fusion.az.DAL;
using Fusion.az.Extentions;
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
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel()
            {
                Bio = _context.Bios.FirstOrDefault(),
            };
           
            return View(model);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login) {

            LoginViewModel model = new LoginViewModel()
            {
                Bio = _context.Bios.FirstOrDefault(),
               
            };
            if (!ModelState.IsValid) return View(model);
            AppUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user== null)
            {
                ModelState.AddModelError("", "Email or password is invalid");
                return View(model);
            }
            if (user.isDeleted)
            {
                ModelState.AddModelError("", "The account is not exist");
                return View(model);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, login.Password, true, true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Please try later");
                return View(model);
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is invalid ");
                return View(model);
            }
            return RedirectToAction("Index", "Home"); 

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
            await _userManager.AddToRoleAsync( newUser,Roles.Member.ToString());
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #region Create USerRole

        //public async Task CreateUserRole()
        //{
        //    if (!(await _roleManager.RoleExistsAsync(Roles.Admin.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
        //    if (!(await _roleManager.RoleExistsAsync(Roles.Member.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
        //}
        #endregion
    }
}
