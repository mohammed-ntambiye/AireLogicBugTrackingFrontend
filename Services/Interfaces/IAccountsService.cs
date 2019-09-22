using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Models;

namespace AireLogicBugTrackingFrontend.Services.Interfaces
{
    public interface IAccountsService
    {
        void Register(UserModel model);
    }
}
