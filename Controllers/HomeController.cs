using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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

        public IActionResult AllClosing()
        {
            var closing = GetBridgeInfosFromApi();
            return View(closing);
        }
        public IActionResult Details()
        {
            var closing = GetBridgeInfosFromApi();
            return View(closing);
        }
        public IActionResult DownloadCalendar()
        {
            var closing = GetBridgeInfosFromApi();
            return View(closing);
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
            var SortedListOfClosing = result.OrderBy(closing =>
            Convert.ToDateTime(closing.ClosingDate)).ToList();
            for (var i = 0; i < SortedListOfClosing.Count; i++)
            {
                SortedListOfClosing[i].Id = i;
            }
            return SortedListOfClosing;
        }
    }
}
