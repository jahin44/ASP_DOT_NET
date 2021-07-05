using System;
using System.Collections.Generic;
using System.Text;

namespace UserRelationship
{
   public class Class2
    {
        public int GetResult(int Mid,int Final)
        {
            var class1 = new Class1();
            var result = class1.Add(Mid, Final); 
            return result;
              
        }


    }
}
