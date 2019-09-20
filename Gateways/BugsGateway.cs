using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Gateways.Interfaces;
using AireLogicBugTrackingFrontend.Models;
using Microsoft.Rest;

namespace AireLogicBugTrackingFrontend.Gateways
{
    public class BugsGateway : IBugsGateway
    {
        public async Task<List<BugsModel>> GetAllBugs()
        {
            return  new List<BugsModel>()
            {
                new BugsModel()
                {
                    TimeStamp = new DateTime(),
                    BugTitle = "Styling Issue",
                    Priority = "High",
                    Description = "The Home page has a slight padding issue",
                    IsOpen = true,
                    Status = "New",
                    TypeOfBug = "Style",
                    Author =  new UserModel()
                      
                },
                new BugsModel()
                {
                    TimeStamp = new DateTime(),
                    BugTitle = "Button press doesn't work",
                    Priority = "High",
                    Description = "The Home page has a slight padding issue",
                    IsOpen = true,
                    Status = "New",
                    TypeOfBug = "Style",
                    Author =  new UserModel()

                }
            };
        }

        public async Task<BugsModel> GetBugsAssignedToUser(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BugsModel>> GetBugsByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public async Task<BugsModel> CreateBug(BugsModel bug)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpStatusCode> DeleteBug(string bugId)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpStatusCode> ChangeBugStatus(string bugId, string newStatus)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpStatusCode> EditBug(string bugId, BugsModel bug)
        {
            throw new NotImplementedException();
        }
    }
}
