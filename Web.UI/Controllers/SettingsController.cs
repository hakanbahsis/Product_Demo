﻿using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
