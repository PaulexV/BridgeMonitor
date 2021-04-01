﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PontChaban.Models;

namespace PontChaban.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var closing = GetBridgeInfosFromApi();
            return View(closing);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private static readonly HttpClient client = new HttpClient();
        private static List<BridgeInfos> GetBridgeInfosFromApi()
        {
            var stringTask = client.GetStringAsync("https://api.alexandredubois.com/pont-chaban/api.php");
            var myJsonResponse = stringTask.Result;
            var result = JsonConvert.DeserializeObject<List<BridgeInfos>>(myJsonResponse);
            return result;
        }
    }
}
