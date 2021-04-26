using System;
using System.Collections.Generic;
using System.Text;

namespace Properti
{
    public class Class1
    {
        public string firstName;
        public string FirstName       //properti
        {
           set
            {
                if (value.Length >= 2)
                {
                    firstName = value;
                }
            }
            get
            {
                return firstName;

            }
        }

         public string LastName { get; set; }   //Auto properti

            public string NameMethod()
        {
            var FullName = FirstName + " " + LastName;
            return FullName;    
        }

        }

    }

