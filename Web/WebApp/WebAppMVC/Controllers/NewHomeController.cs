using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class NewHomeController : Controller
    {
        public IActionResult FirstPage()
        {
            var Text = new FirstPageText();
            return View(Text);
        }
    }
}
