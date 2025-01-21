using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeAlgorithms.Tests
{
    public class EasyTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSum(int[] nums, int target, int[] resultData)
        {
            // Arrange
            var twoSum = new TwoSumSolution();

            // Act
            var result = twoSum.TwoSum(nums, target);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(resultData);
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void Palindrome(int num, bool resultData)
        {
            // Arrange
            var solution = new PalindromeSolution();

            // Act
            var result = solution.IsPalindrome(num);

            // Assert
            result.Should().Be(resultData);
        }

        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInteger(string roman, int resultData)
        {
            // Arrange
            var solution = new RomanToInteger();

            // Act
            var result = solution.RomanToInt(roman);

            // Assert
            result.Should().Be(resultData);
        }
    }
}
