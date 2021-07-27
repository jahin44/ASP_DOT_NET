using WebAppMVC.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Training.Services
{
    public interface ICourseService
    {
        IList<Course> GetAllCourses();
        void EnrollStudent(Course course, Student student);
        void CreateCourse(Course course);
    }
}
