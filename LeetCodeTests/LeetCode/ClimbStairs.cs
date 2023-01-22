using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.LeetCode;

namespace Tests.LeetCode
{
    // Test class names = should NOT be the same name as the class you're testing against
    public class ClimbStairsTests
    {
       
        [Fact]
        public void NumberOfWaysEven_One ()
        {
            ClimbStairs climbStairs = new ClimbStairs();

            int result = climbStairs.NumberOfWays(2);

            Assert.Equal(2, result);

        }

        [Fact]
        public void NumberOfWaysEven_Two()
        {
            ClimbStairs climbStairs = new ClimbStairs();

            int result = climbStairs.NumberOfWays(8);

            Assert.Equal(34, result);
        }

        [Fact]
        public void NumberOfWaysOdd_One()
        {
            ClimbStairs climbStairs = new ClimbStairs();

            int result = climbStairs.NumberOfWays(3);

            Assert.Equal(3, result);
        }

        // This is the correct test (rest are faulty)...
        [Fact]
        public void NumberOfWaysOdd_Two()
        {
            ClimbStairs climbStairs = new ClimbStairs();

            int result = climbStairs.NumberOfWays(5);

            Assert.Equal(8, result);
        }

        [Fact]
        public void NumberOfWaysOdd_Three()
        {
            ClimbStairs climbStairs = new ClimbStairs();

            int result = climbStairs.NumberOfWays(9);

            Assert.Equal(55, result);
        }



    }
}
