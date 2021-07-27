using WebAppMVC.Data;
using WebAppMVC.Training.Contexts;
using WebAppMVC.Training.Entities;
using WebAppMVC.Training.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public IStudentRepository Students { get; private set; }
        public ICourseRepository Courses { get; private set; }

        public TrainingUnitOfWork(ITrainingContext context,
            IStudentRepository students,
            ICourseRepository courses
            ) : base((DbContext)context)
        {
            Students = students;
            Courses = courses;
        }
    }
}
