using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ScratchPad.Models
{
    // IComparable = allow sort based on a property
    public class Student : IComparable<Student>
    {
        // Set class attributes
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }

        // Default sort method = compares based on Score
        public int CompareTo([AllowNull] Student other)
        {
            if (this.Score > other.Score) { return 1; }
            else if (this.Score < other.Score) { return -1; }
            else { return 0; };

        }
    }
}
