﻿using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class RolesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
