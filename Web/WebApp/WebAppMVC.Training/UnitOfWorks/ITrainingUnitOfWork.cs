using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Training.Entities;
using WebAppMVC.Data;

namespace WebAppMVC.Training.UnitOfWorks
{
        public interface ITrainingUnitOfWork : IUnitOfWork
        {
            IRepository<Course> Courses { get; }
            IRepository<Student> Students { get; }
        }
 
}
