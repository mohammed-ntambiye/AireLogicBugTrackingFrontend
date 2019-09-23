using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Gateways.Interfaces;
using AireLogicBugTrackingFrontend.Models;
using AireLogicBugTrackingFrontend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AireLogicBugTrackingFrontend.Services
{
    public class AccountsService : IAccountsService
    {
        private readonly IAccountsGateway _accountsGateway;

        public AccountsService(IAccountsGateway accountsGateway)
        {
            _accountsGateway = accountsGateway;
        }
        public StatusCodeResult Register(UserModel model)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] Data = System.Text.Encoding.ASCII.GetBytes(model.Password);
            var md5data = md5.ComputeHash(Data);

            model.Password = Encoding.UTF8.GetString(md5data);
            var result = _accountsGateway.Register(model);
            return result.Result;
        }
    }
}
