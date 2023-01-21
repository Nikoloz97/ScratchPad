using ScratchPad.LeetCode;
namespace Tests.LeetCode

{
    public class MissingNumbTests
    {
        [Fact]
        public void FindNumberTestOne()
        {
            MissingNumbs missingNumb = new MissingNumbs();

            int result = missingNumb.FindMissingNumber(new int[] { 3, 0, 1 });

            Assert.Equal(2, result);
        }

        [Fact]
        public void FindNumberTestTwo()
        {

            MissingNumbs missingNumb = new MissingNumbs();

            int result = missingNumb.FindMissingNumber(new int[] { 0,1 });

            Assert.Equal(2, result);


        }

        [Fact]
        public void FindNumberTestThree()
        {

            MissingNumbs missingNumb = new MissingNumbs();

            int result = missingNumb.FindMissingNumber(new int[] { 9,6,4,2,3,5,7,0,1 });

            Assert.Equal(8, result);

        }


    }
}
