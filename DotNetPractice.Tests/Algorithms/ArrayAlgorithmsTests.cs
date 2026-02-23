using System.Runtime.InteropServices;
using DotNetPractice.Algorithms;
using Xunit;

namespace DotNetPractice.Tests.Strings;

public class MissingNumberSolverTests
{
    [Theory]
    [InlineData(new int[] {1,2,4,5}, 3)]
    [InlineData(new int[] {1,2,3,4,6,7,8}, 5)]
    [InlineData(new int[] {1, 2, 3, 4}, 5)]

    public void FindMissingNumber_VariousInputs_ReturnsExpectedValue(int[] numbers, int expected)
    {
        // Act
        int result = ArrayAlgorithms.FindMissingNumber(numbers);

        // Assert
        Assert.Equal(expected, result);
    }
}