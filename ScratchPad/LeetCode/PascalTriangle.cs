using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    //https://leetcode.com/problems/pascals-triangle/
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            // Create list of lists
            IList<IList<int>> listOfRowInts = new List<IList<int>>();

            // Create RowIntsGenerator
            for (int i = 1; i <= numRows; i++)
            {
                listOfRowInts.Add(RowIntsGenerator(listOfRowInts, i));
            }

            return listOfRowInts;

        }

        public IList<int> RowIntsGenerator (IList<IList<int>> listOfRowInts, int row)
        {
            if (row == 1)
            {
                return new List<int>(new int[] { 1 });
            }
            else if (row == 2)
            {
                return new List<int>(new int[] { 1, 1 });
            }

            else
            {
                // Refer to previous list
                IList<int> previousRow = listOfRowInts[listOfRowInts.Count - 1];

                // Create new array
                int[] currentRow = new int[row];

                // Set beginning and ends to 1
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;

                // For the rest...
                // For each index of current list, add the index of previousRow + index - 1
                for (int i = 1; i < currentRow.Length - 1; i++)
                {
                    currentRow[i] = previousRow[i - 1] + previousRow[i];
                }

                return currentRow.ToList();

            }


        }


    }
}
