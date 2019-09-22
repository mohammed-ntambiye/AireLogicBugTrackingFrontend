using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace AireLogicBugTrackingFrontend.Gateways.Interfaces
{
    public interface IBugsGateway
    {
        Task<List<BugsModel>> GetAllBugs();

        Task<BugsModel> GetBugsAssignedToUser(string userId);

        Task<List<BugsModel>> GetBugsByStatus(string status);

        Task<ActionResult> CreateBug(BugsModel bug);

        Task<BugsModel> GetBug(int bugId);

        Task<HttpStatusCode> DeleteBug(string bugId);

        Task<HttpStatusCode> ChangeBugStatus(string bugId, string newStatus);

        Task<HttpStatusCode> EditBug(BugsModel bug);
    }
}
