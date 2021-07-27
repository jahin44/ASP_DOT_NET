using WebAppMVC.Data;
using WebAppMVC.Training.Contexts;
using WebAppMVC.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Training.Repositories
{
    public interface IStudentRepository : IRepository<Student, int>
    {
    }
}
