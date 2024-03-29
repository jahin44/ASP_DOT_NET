﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Training.BusinessObjects;
using WebAppMVC.Training.Services;

namespace WebAppMVC.Areas.Admin.Models
{
    public class CreateCourseModel
    {
        public string Title { get; set; }
        public int Fees { get; set; }
        public DateTime StartDate { get; set; }

        private readonly ICourseService _courseService;

        public CreateCourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public CreateCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        internal void CreateCourse()
        {
            var course = new Course
            {
                Title = Title,
                Fees = Fees,
                StartDate = StartDate
            };

            _courseService.CreateCourse(course);
        }
    }
}
