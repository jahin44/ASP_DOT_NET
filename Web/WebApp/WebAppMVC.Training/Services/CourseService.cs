using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Training.Context;
using WebAppMVC.Training.BusinessObject;
using WebAppMVC.Training.UnitOfWorks;

namespace WebAppMVC.Training.Services
{
    public class CourseService : ICourseService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        public CourseService (ITrainingUnitOfWork trainingUnitOfWork)
        {
         _trainingUnitOfWork = trainingUnitOfWork;
        }
        public IList<Course> GetAllCourses()
        {
            var courseEntities = _trainingUnitOfWork.Courses.GetAll();
            var courses = new List<Course>();

            foreach(var entity in courseEntities)
            {
                var course = new Course()
                {
                    Title = entity.Titel,
                    Fees = entity.Fees
                };
                courses.Add(course);
            }
            return courses;
        }

        public void CreateCourse(Course course)
        {
            _trainingUnitOfWork.Courses.Add(
                
                new WebApp.Training.Entities.Course
                {
                    Titel = course.Title,
                    Fees = course.Fees,
                    StartDate = course.StartTime
                }

                );
            _trainingUnitOfWork.Save();




        }
    }
}
