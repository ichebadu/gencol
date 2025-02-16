using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace userAuthentication_module.controller
{
    public class AccountController : Controller
    private readonly SignInManager<Users> signInManager;
    private readonly UserManager<Users> userManager;
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                Users users = new Users();
                FullName = model.FullName;
                Email = model.Email;
                UserName = model.Email;
            };
            var result = await userManager.CreateAsync(users, model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                result View(model)
            }
            result View(model)

        }
        public IActionResult Logout()
        {
            return View();
        }


    }
}