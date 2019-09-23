using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace AireLogicBugTrackingFrontend.Services.Interfaces
{
    public interface IBugsService
    {
        List<BugsModel> GetAllBugs();

        List<BugsModel> GetAllOpenBugs();

        BugsModel GetBugsAssignedToUser(string userId);

        List<BugsModel> GetBugsByStatus(string status);

        ActionResult CreateBug (BugsModel bug);

        BugsModel GetBug(int bugId);

        HttpStatusCode DeleteBug (int bugId);

        HttpStatusCode ChangeBugStatus (int bugId, string newStatus );

        HttpStatusCode EditBug (BugsModel bug);

    }
}
