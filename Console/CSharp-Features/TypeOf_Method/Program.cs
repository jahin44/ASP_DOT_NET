using System;

namespace TypeOf_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Course();
            var type = courses.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var Name = property.PropertyType;
                if (Name.Namespace.StartsWith("System") == true){
            
                  Console.WriteLine(Name);
                    }
            }
            int a=0;
            // Display the type of a
            Console.WriteLine(a);

            // Display the value type
            Console.WriteLine(typeof(int));

            // Display the class type
            Console.WriteLine(typeof(Array));

            // Display the value type
            Console.WriteLine(typeof(char));

            // Display the array reference type
            Console.WriteLine(typeof(int[]));
        }
    }
}
