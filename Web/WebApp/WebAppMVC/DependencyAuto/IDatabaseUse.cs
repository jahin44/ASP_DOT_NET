using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.DependencyAuto
{
   public interface IDatabaseUse
    {
        string GetInfo();

        string GetAge();


    }
}
