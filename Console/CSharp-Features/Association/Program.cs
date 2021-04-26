using System;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address();
            address.HomeNo = "A 9/7";
            address.RoadNo = "118";
            address.City = "Dhaka";
            address.Country = "Bangladesh";
           

            var person = new Person();
            person.Location = address;
            Address personLocation = person.Location;

            Console.WriteLine(personLocation.HomeNo + "\n" + personLocation.RoadNo
                + "\n" + personLocation.City + "\n" + personLocation.Country);

            
        }
    }
}
