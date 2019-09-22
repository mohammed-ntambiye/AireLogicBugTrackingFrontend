using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            model.TimeStamp = DateTime.Now;
            _BugsService.CreateBug(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditBug(int bugId)
        {
            var model = _BugsService.GetBug(bugId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditBug(BugsModel bug)
        {
            _BugsService.EditBug(bug);
            return View();
        }


        [HttpPost]
        public PartialViewResult SingleBug(int bugId)
        {
            var bug = _BugsService.GetBug(bugId);
            return PartialView(bug);
        }    
    }
}