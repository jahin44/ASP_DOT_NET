using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Areas.Admin.Models;

namespace WebAppMVC.Areas.Admin.Controllers
{      
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new CourseListModel();
            model.LoadModelData();
            return View(model);
        } 
        public IActionResult Enroll()
        {
            var model = new EnrollStudentModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Enroll(EnrollStudentModel model)
        {
            if (ModelState.IsValid)
            {
                model.EnrollStudent();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            var model = new CreateCourseModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(CreateCourseModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreateCourse();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Failed to create course");
                    _logger.LogError(ex, "Create Course Failed");
                }
            }
            return View(model);
        }
    }
}
