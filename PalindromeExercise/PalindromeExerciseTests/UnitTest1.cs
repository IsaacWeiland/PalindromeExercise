using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("RAce Car", true)]
        [InlineData("I am Hungry", false)]
        public void Test1(string possiblePal, bool expected)
        {
            var wordSmith = new WordSmith();
            var actual = wordSmith.IsAPalindrome(possiblePal);
            Assert.Equal(expected, actual);
        }
    }
}
