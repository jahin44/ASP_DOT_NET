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
    public class CourseRepository : Repository<Course> 
    {
        public CourseRepository(TrainingContext context) 
            :base(context)
        {

        }
      
    }
}
 