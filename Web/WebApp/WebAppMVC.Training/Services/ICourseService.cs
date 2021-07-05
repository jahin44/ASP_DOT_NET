using System.Collections.Generic;
using WebAppMVC.Training.BusinessObject;

namespace WebAppMVC.Training.Services
{
    public interface ICourseService
    {
        IList<Course> GetAllCourses();
    }
}