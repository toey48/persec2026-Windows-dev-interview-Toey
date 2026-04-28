using Xunit;
using Solutions;
using System.Collections.Generic;

namespace Solutions.Tests
{
    public class Question6Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5 }, 5, new int[] { 1, 3, 5, 9, 17 })]
        [InlineData(new int[] { 2, 2, 2 }, 3, new int[] { 2, 2, 2 })]
        [InlineData(new int[] { 10, 10, 10 }, 4, new int[] { 10, 10, 10, 30 })]
        public void Tribonacci_NormalCases(int[] seed, int n, int[] expected)
        {
            // Act
            var result = Question6.Tribonacci(seed, n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5)]
        public void Tribonacci_EmptySeed(int n)
        {
            // Act
            var result = Question6.Tribonacci(new int[] { }, n);

            // Assert
            Assert.Equal(new List<int> { 0, 0, 0, 0, 0 }, result);
        }

        [Theory]
        [InlineData(5)]
        public void Tribonacci_OneSeed(int n)
        {
            var result = Question6.Tribonacci(new int[] { 1 }, n);
            Assert.Equal(new List<int> { 1, 0, 0, 1, 1 }, result);
        }

        [Theory]
        [InlineData(5)]
        public void Tribonacci_TwoSeed(int n)
        {
            var result = Question6.Tribonacci(new int[] { 5, 2 }, n);
            Assert.Equal(new List<int> { 5, 2, 0, 7, 9 }, result);
        }

        [Fact]
        public void Tribonacci_NIsZero_ShouldReturnEmpty()
        {
            var result = Question6.Tribonacci(new int[] { 1, 2, 3 }, 0);
            Assert.Empty(result);
        }

        [Fact]
        public void Tribonacci_SeedIsNull_ShouldHandleGracefully()
        {
            var result = Question6.Tribonacci(null, 3);
            Assert.Equal(new List<int> { 0, 0, 0 }, result);
        }
    }
}