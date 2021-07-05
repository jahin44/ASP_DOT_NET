﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Training.Context;
using WebAppMVC.Training.BusinessObject;
 

namespace WebAppMVC.Training.Services
{
    public class CourseService : ICourseService
    {
        private readonly TrainingContext _trainingContext;
        public CourseService (TrainingContext trainingContext)
            {
            _trainingContext = trainingContext;
            }
        public IList<Course> GetAllCourses()
        {
            var courseEntities = _trainingContext.Courses.ToList();
            var courses = new List<Course>();

            foreach(var entity in courseEntities)
            {
                var course = new Course()
                {
                    Titel = entity.Titel,
                    Fees = entity.Fees
                };
                courses.Add(course);
            }
            return courses;
        }

        public void CreateCourse(Course course)
        {
            _trainingContext.Courses.Add(
                
                new Entities.Course
                {
                    Title = course.Titel,
                    Fees= course.Fees,
                    StartData= course.StartDate
                }

                );

            }

        }
    }
}
