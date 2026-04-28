using Xunit;
using Solutions;

namespace Solutions.Tests
{
    public class Question5Tests
    {
        [Theory]
        [InlineData(3008, 8300)]
        [InlineData(1989, 9981)]
        [InlineData(2679, 9762)]
        [InlineData(9163, 9631)]
        public void SortDescending_ShouldReturnCorrectResult(int input, int expected)
        {
            // Act
            var result = Question5.SortDescending(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}