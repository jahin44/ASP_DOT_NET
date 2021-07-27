using WebAppMVC.Common.Utilities;
using WebAppMVC.Training.BusinessObjects;
using WebAppMVC.Training.Contexts;
using WebAppMVC.Training.Exceptions;
using WebAppMVC.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Training.Services
{
    public class CourseService : ICourseService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IDateTimeUtility _dateTimeUtility;

        public CourseService(ITrainingUnitOfWork trainingUnitOfWork, 
            IDateTimeUtility dateTimeUtility)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _dateTimeUtility = dateTimeUtility;
        }

        public IList<Course> GetAllCourses()
        {
            var courseEntities = _trainingUnitOfWork.Courses.GetAll();
            var courses = new List<Course>();

            foreach(var entity in courseEntities)
            {
                var course = new Course()
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Fees = entity.Fees
                };

                courses.Add(course);
            }

            return courses;
        }

        public void CreateCourse(Course course)
        {
            if (course == null)
                throw new InvalidParameterException("Course was not provided");

            if (IsTitleAlreadyUsed(course.Title))
                throw new DuplicateTitleException("Course title already exists");

            if (!IsValidStartDate(course.StartDate))
                throw new InvalidOperationException("Start date should be atleast 30 days ahead");
            
            _trainingUnitOfWork.Courses.Add(
                new Entities.Course
                {
                    Title = course.Title,
                    Fees = course.Fees,
                    StartDate = course.StartDate
                }
            );

            _trainingUnitOfWork.Save();
        }

        public void EnrollStudent(Course course, Student student)
        {
            var courseEntity = _trainingUnitOfWork.Courses.GetById(course.Id);

            if (courseEntity == null)
                throw new InvalidOperationException("Course was not found");

            if(courseEntity.EnrolledStudents == null)
                courseEntity.EnrolledStudents = new List<Entities.CourseStudents>();

            courseEntity.EnrolledStudents.Add(new Entities.CourseStudents
            {
                Student = new Entities.Student
                {
                    Name = student.Name,
                    DateOfBirth = student.DateOfBirth
                }
            });

            _trainingUnitOfWork.Save();
        }

        private bool IsTitleAlreadyUsed(string title) =>
            _trainingUnitOfWork.Courses.GetCount(x => x.Title == title) > 0;

        private bool IsValidStartDate(DateTime startDate) =>
            startDate.Subtract(_dateTimeUtility.Now).TotalDays > 30;
    }
}
