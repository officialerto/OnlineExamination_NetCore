﻿using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            LoginViewModel sessionObj = HttpContext.Session.Get<LoginViewModel>("loginvm");

            if (sessionObj == null)
                return View();

            else
            {
                return RedirectUser(sessionObj);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                LoginViewModel loginVM = _accountService.Login(loginViewModel);
                if (loginVM != null)
                {
                    HttpContext.Session.Set<LoginViewModel>("loginvm", loginVM);
                    return RedirectUser(loginVM);
                }
            }
            return View(loginViewModel);
        }

        public IActionResult RedirectUser(LoginViewModel loginViewModel)
        {
            if (loginViewModel.Role == (int)EnumRoles.Admin)
                return RedirectToAction("Index", "Users");

            else if (loginViewModel.Role == (int)EnumRoles.Teacher)
                return RedirectToAction("Index", "Exams");

            return RedirectToAction("Profile", "Students");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Set<LoginViewModel>("loginvm", null);
            return RedirectToAction("Login");
        }


    }
}
