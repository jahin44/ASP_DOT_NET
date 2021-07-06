using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Training.Context;
using WebApp.Training.Entities;
using WebAppMVC.Data;

namespace WebAppMVC.Training.Repositories
{
    public class StudentRepository : Repository<Student>  
    {
        public StudentRepository(TrainingContext context)
            :base (context)
        {

        }
    }
}
