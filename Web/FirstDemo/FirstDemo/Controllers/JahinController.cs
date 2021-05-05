using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDemo.Controllers
{
    public class JahinController : Controller
    {
        public IActionResult Jahin()
        {
            var Model = new JahinModel();
            return View(Model);
        }
    }
}
