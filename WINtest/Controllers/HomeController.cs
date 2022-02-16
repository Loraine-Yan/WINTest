using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WINtest.Models;

namespace WINtest.Controllers
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
            return View();
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

        public class Solution
        {
            public int[] Question1(int[] nums, int target)
            {
                Dictionary<int, int> temp = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int left = target - nums[i];
                    if (temp.ContainsKey(left))
                    {
                        return new int[] { temp[left], i };
                    }
                    if (!temp.ContainsKey(nums[i]))
                    {
                        temp.Add(nums[i], i);
                    }
                }
                return null;
            }
        };
    }
}
