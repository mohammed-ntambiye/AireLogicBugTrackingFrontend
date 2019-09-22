﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Gateways.Interfaces;
using AireLogicBugTrackingFrontend.Models;
using AireLogicBugTrackingFrontend.Services.Interfaces;

namespace AireLogicBugTrackingFrontend.Services
{
    public class BugsService : IBugsService
    {
        private readonly IBugsGateway _bugsGateway;

        public BugsService(IBugsGateway bugsGateway)
        {
            _bugsGateway = bugsGateway;
        }

        public List<BugsModel> GetAllBugs()
        {
            var result = _bugsGateway.GetAllBugs().Result;
            return result;
        }

        public HttpStatusCode ChangeBugStatus(string bugId, string newStatus)
        {
            throw new NotImplementedException();
        }

        public BugsModel CreateBug(BugsModel bug)
        {
            throw new NotImplementedException();
        }

        public BugsModel GetBug(int bugId)
        {
            var result = _bugsGateway.GetBug(bugId);
            return result.Result;
        }

        public HttpStatusCode DeleteBug(int bugId)
        {
            throw new NotImplementedException();
        }

        public HttpStatusCode ChangeBugStatus(int bugId, string newStatus)
        {
            throw new NotImplementedException();
        }

        public HttpStatusCode EditBug(BugsModel bug)
        {
            var result = _bugsGateway.EditBug(bug);
            return result.Result;
        }

        public HttpStatusCode DeleteBug(string bugId)
        {
            throw new NotImplementedException();
        }


        public BugsModel GetBugsAssignedToUser(string userId)
        {
            throw new NotImplementedException();
        }

        public List<BugsModel> GetBugsByStatus(string status)
        {
            throw new NotImplementedException();
        }
    }
}
