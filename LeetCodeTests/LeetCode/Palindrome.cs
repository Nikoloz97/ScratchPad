using ScratchPad.LeetCode;
namespace Tests.LeetCode

{
    public class LC_Tests
    {
        [Fact]
        public void PaliTestOne()
        {
            Palindrome palindrome = new Palindrome();

            bool result = palindrome.IsPalindrome(121);

            Assert.True(result);

        }

        [Fact]
        public void PaliTestTwo()
        {
            Palindrome palindrome = new Palindrome();

            bool result = palindrome.IsPalindrome(3576943);

            Assert.False(result);

        }
    }
}