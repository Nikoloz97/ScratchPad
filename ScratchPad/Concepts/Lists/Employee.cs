using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.Concepts.Lists
{
    public class Employee
    {
        public int Id;
        public string Name;

        // Normally, ToString() = produces strange output for the employee variable
        // This overrides it, so that upon console writelining, produces a nice syntax 
        public override string ToString()
        {
            return Id + " " + Name;
        }

    }
}
