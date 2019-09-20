using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;
using AireLogicBugTrackingFrontend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AireLogicBugTrackingFrontend.Controllers
{
    public class BugsController : Controller
    {
        private readonly IBugsService _BugsService;

        public BugsController(IBugsService bugsService)
        {
            _BugsService = bugsService;
        }

        [HttpGet]
        public  ActionResult Index()
        {
            var model = _BugsService.GetAllBugs();
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateBug()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateBug(BugsModel model)
        {
            _BugsService.CreateBug(model);
            return RedirectToAction("Index");

        }



    }
}