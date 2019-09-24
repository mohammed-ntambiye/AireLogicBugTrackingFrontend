using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Gateways.Interfaces;
using AireLogicBugTrackingFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AireLogicBugTrackingFrontend.Gateways
{
    public class AccountsGateway : IAccountsGateway
    {

        private readonly HttpClient _client = new HttpClient();
        private readonly IOptions<Configuration.Configuration> _configuration;

        public AccountsGateway(IOptions<Configuration.Configuration> configuration)
        {
            _configuration = configuration;
        }

        public async Task<StatusCodeResult> Register(UserModel model)
        {
            if (model == null) return new StatusCodeResult(400);
            try
            {
                HttpResponseMessage response = await _client.PostAsJsonAsync(_configuration.Value.AirLogicApiBaseUrl + "/api/Accounts", model);
                response.EnsureSuccessStatusCode();
                return new StatusCodeResult(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new StatusCodeResult(500);
            }
        }
    }
}
