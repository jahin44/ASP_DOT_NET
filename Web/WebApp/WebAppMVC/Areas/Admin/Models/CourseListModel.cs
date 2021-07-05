using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Training.BusinessObject;
using WebAppMVC.Training.Services;

namespace WebAppMVC.Areas.Admin.Models
{
    
    public class CourseListModel
    {
        public IList<Course> Courses { get; set; }
        private readonly ICourseService _courseService;

        public CourseListModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();

        }
        public CourseListModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public void LoadModelData()
        {
            Courses = _courseService.GetAllCourses();
        }


    }
    
}
