using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace AireLogicBugTrackingFrontend.Gateways.Interfaces
{
    public interface IAccountsGateway
    {
        Task<StatusCodeResult> Register(UserModel model);
    }
}
