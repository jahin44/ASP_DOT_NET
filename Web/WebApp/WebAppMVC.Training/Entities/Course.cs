using System;
using System.Collections.Generic;

namespace WebApp.Training.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public int Fees { get; set; }
        public DateTime StartDate { get; set; }

        public List<Topic> Topics { get; set; }

    }
}
