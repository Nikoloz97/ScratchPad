using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.NBATrivia
{
    public class Player
    {
        public int Id;
        public int Rank;
        public string FirstName;
        public string LastName;



        // Normally, ToString() = produces strange output (whatever's stored in the heap)
        // This overrides it, so that upon console writelining, produces a specific syntax 
        public override string ToString()
        {
            return FirstName + LastName;
        }

    }
}
