using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;
using AireLogicBugTrackingFrontend.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AireLogicBugTrackingFrontend.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountsService _AccountsService;
        public AccountsController(IAccountsService accountsService)
        {
            _AccountsService = accountsService;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel model)
        {
            _AccountsService.Register(model);
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            return View();
        }
    }
}