using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace AireLogicBugTrackingFrontend.Services.Interfaces
{
    public interface IAccountsService
    {
        StatusCodeResult Register(UserModel model);
    }
}
