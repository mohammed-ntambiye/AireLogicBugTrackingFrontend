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

        BugsModel GetBug(int bugId);

        HttpStatusCode DeleteBug (int bugId);

        HttpStatusCode ChangeBugStatus (int bugId, string newStatus );

        HttpStatusCode EditBug (BugsModel bug);

    }
}
