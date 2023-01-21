using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.LeetCode;

namespace Tests.LeetCode
{
    public class ClimbStairs
    {
        [Fact]
        public void ClimbTestOne()
        {
            ClimbStairs climbStairs = new ClimbStairs();

            int result = climbStairs.GetNumberOfWays(2);

            Assert.Equal(2, result);

        }

        [Fact]
        public void ClimbTestTwo()
        {
            ClimbStairs climbStairs = new ClimbStairs();

            int result = climbStairs.GetNumberOfWays(3);

            Assert.Equal(3, result);
        }
    }
}
