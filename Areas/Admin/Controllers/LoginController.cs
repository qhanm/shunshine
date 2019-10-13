using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shunshine.App.EntityCodeFirst;
using shunshine.App.Utilities.Dtos;
using shunshine.Models.AccountViewModels;

namespace shunshine.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        protected readonly UserManager<AppUser> _userManager;
        protected readonly SignInManager<AppUser> _siginManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _siginManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Authen(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _siginManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return new OkObjectResult(new GenericResult(true));
                }

                if (result.IsLockedOut)
                {
                    return new OkObjectResult(new GenericResult(false, "Account block"));
                }
                else
                {
                    return new OkObjectResult(new GenericResult(false, "User or Password Field"));
                }
            }

            return new OkObjectResult(new GenericResult(false, loginViewModel));
        }
    }
}