using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Training.Context;
using WebApp.Training.Entities;
using WebAppMVC.Data;
using WebAppMVC.Training.Repositories;

namespace WebAppMVC.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public IRepository<Student> Students { get; private set; }
        public IRepository<Course> Courses { get; set; }
        public TrainingUnitOfWork(TrainingContext context) : base(context)
        {
            Students = new StudentRepository(context);
            Courses = new CourseRepository(context);
        }
    }
} 
  