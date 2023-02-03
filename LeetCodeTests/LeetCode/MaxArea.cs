using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.LeetCode;

namespace Tests.LeetCode
{
    public class MaxArea
    {
        [Fact]
        public void MaxArea_One()
        {
            // "ScratchPad.LeetCode." = necessary since corresponding file has the same name
            ScratchPad.LeetCode.MaxArea maxArea = new();

            int actual = maxArea.GetMaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

            int expected = 49;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MaxArea_Two()
        {
            // "ScratchPad.LeetCode." = necessary since corresponding file has the same name
            ScratchPad.LeetCode.MaxArea maxArea = new();

            int actual = maxArea.GetMaxArea(new int[] { 1, 1 });

            int expected = 1;

            Assert.Equal(expected, actual);

        }


    }
}
