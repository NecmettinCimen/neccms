﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NecCms.Models;

namespace NecCms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new IcerikDto { Baslik = "" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}