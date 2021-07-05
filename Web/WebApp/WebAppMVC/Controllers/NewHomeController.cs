using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.DependencyAuto;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class NewHomeController : Controller
    {
        private IDatabaseUse _DatabaseUSe;

        public NewHomeController(IDatabaseUse databaseUse)
        {
            _DatabaseUSe = databaseUse;
        }
        public IActionResult FirstPage()
        {
            var massage = _DatabaseUSe.GetInfo();
            var Text = new FirstPageText();
            return View(Text);
        }
    }
}
 