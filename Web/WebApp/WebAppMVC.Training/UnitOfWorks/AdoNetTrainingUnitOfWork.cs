using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Training.Entities;
using WebAppMVC.Data;

namespace WebAppMVC.Training.UnitOfWorks
{
    public class AdoNetTrainingUnitOfWork : ITrainingUnitOfWork
    {
        public IRepository<Course> Courses => throw new NotImplementedException();

        public IRepository<Student> Students => throw new NotImplementedException();

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
