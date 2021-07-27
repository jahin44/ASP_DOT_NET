using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Training.Services;
using WebAppMVC.Training.BusinessObjects;

namespace WebAppMVC.Areas.Admin.Models
{
    public class EnrollStudentModel
    {
        public int StudentId { get; set; }
        public string CourseName { get; set; }

        private readonly ICourseService _courseService;
        public EnrollStudentModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public EnrollStudentModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void EnrollStudent()
        {
            var courses = _courseService.GetAllCourses();

            var selectedCourse = courses.Where(x => x.Title == CourseName).FirstOrDefault();

            var student = new Student
            {
                Id = StudentId,
                DateOfBirth = DateTime.Now,
                Name = "Jalaluddin",
            };

            _courseService.EnrollStudent(selectedCourse, student);
        }
    }
}
