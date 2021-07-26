﻿using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class DashboardController : Controller
    {
        private IDatabaseService _databaseService;
        public DashboardController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public IActionResult Summary()
        {
            var name = _databaseService.GetName();
            var model = new SummaryModel();
            return View(model);
        }

        public IActionResult Test()
        {
            var model = new TestModel();
            return View(model);
        }
    }
}
