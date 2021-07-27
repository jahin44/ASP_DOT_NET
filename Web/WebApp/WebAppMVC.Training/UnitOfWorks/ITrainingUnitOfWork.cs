using WebAppMVC.Data;
using WebAppMVC.Training.Contexts;
using WebAppMVC.Training.Entities;
using WebAppMVC.Training.Repositories;

namespace WebAppMVC.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork : IUnitOfWork
    {
        IStudentRepository Students { get; }
        ICourseRepository  Courses { get; }
    }
}