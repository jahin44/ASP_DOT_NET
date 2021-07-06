using WebApp.Training.Entities;
using WebAppMVC.Data;

namespace WebAppMVC.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork : IUnitOfWork
        public  IRepository<Course> Courses { get; set; }
        public IRepository<Student> Students { get; set; }
    }
}