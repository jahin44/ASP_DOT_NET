using FirstDemo.DependenciesBydefult;
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
        private IDatabase _databaseaccess;
       
        public JahinController(IDatabase databaseaccess)
        {
            _databaseaccess = databaseaccess;
        }
       
        public IActionResult hasan()
        {
            var value = _databaseaccess.EmailSend();

            var Model = new JahinModel();
            return View(Model);
        }
    }
}
