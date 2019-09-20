using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;

namespace AireLogicBugTrackingFrontend.Services.Interfaces
{
    public interface IBugsService
    {
        List<BugsModel> GetAllBugs();

        BugsModel GetBugsAssignedToUser(string userId);

        List<BugsModel> GetBugsByStatus(string status);

        BugsModel CreateBug (BugsModel bug);

        HttpStatusCode DeleteBug (string bugId);

        HttpStatusCode ChangeBugStatus (string bugId, string newStatus );

        HttpStatusCode EditBug (string bugId ,BugsModel bug);

    }
}
