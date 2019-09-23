using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Gateways.Interfaces;
using AireLogicBugTrackingFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using SmartKitchenFrontend.Configuration;

namespace AireLogicBugTrackingFrontend.Gateways
{
    public class BugsGateway : IBugsGateway
    {

        private readonly HttpClient _client = new HttpClient();
        private readonly IOptions<Configuration> _configuration;

        public BugsGateway(IOptions<Configuration> configuration)
        {
            _configuration = configuration;
        }


        public async Task<List<BugsModel>> GetAllBugs()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_configuration.Value.AirLogicApiBaseUrl + "/api/Bugs");
                if (response.IsSuccessStatusCode)
                {
                    var bugs  = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<BugsModel>>(bugs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public async Task<List<BugsModel>> GetAllOpenBugs()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_configuration.Value.AirLogicApiBaseUrl + "/api/Bugs/OpenBugs");
                if (response.IsSuccessStatusCode)
                {
                    var bugs = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<BugsModel>>(bugs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public async Task<BugsModel> GetBugsAssignedToUser(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BugsModel>> GetBugsByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult> CreateBug(BugsModel bug)
        {
            if (bug == null) return new StatusCodeResult(400);
            try
            {
                HttpResponseMessage response = await _client.PostAsJsonAsync(_configuration.Value.AirLogicApiBaseUrl + "/api/Bugs", bug);      
                response.EnsureSuccessStatusCode();
                return new StatusCodeResult(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new StatusCodeResult(500);
            }
        }

        public async Task<HttpStatusCode> DeleteBug(string bugId)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpStatusCode> ChangeBugStatus(string bugId, string newStatus)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpStatusCode> EditBug(BugsModel bug)
        {
            throw new NotImplementedException();
        }

        public async Task<BugsModel> GetBug(int bugId)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_configuration.Value.AirLogicApiBaseUrl + "/api/Bugs/"+bugId);
                if (response.IsSuccessStatusCode)
                {
                    var bugs = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<BugsModel>(bugs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}