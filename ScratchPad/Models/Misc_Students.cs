using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.Models
{
    public class Students
    {
        public List<Student> StudentsList { get; set; }

        // Constructor = creates mock data
        public Students()
        {
            StudentsList = new List<Student>
            {
                new Student {Id = 1, FirstName = "Joe", LastName = "Shmoe", Score = 78},
                new Student {Id = 2, FirstName = "Alex", LastName = "Georges", Score = 83},
                new Student {Id = 3, FirstName = "Danny", LastName = "Alfiler", Score = 67},
                new Student{Id = 4, FirstName = "Michael", LastName = "Tabachino", Score = 92},

            };

        }

    }
}
