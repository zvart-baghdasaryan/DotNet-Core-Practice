using DotNetPractice.Algorithms.Strings;
using Xunit;

namespace DotNetPractice.Tests.Strings;

public class PalindromeCheckerTests
{
    [Theory]
    [InlineData("radar", true)]
    [InlineData("level", true)]
    [InlineData("Radar", true)]
    [InlineData("hello", false)]
    [InlineData("A man,  a plan,  a canal: Panama", true)]
    [InlineData("", false)]
    [InlineData(null, false)]

    public void IsPalindrome_ShouldReturnExpectedResult(string? text, bool expected)
    {
        //Act
        bool result = PalindromeChecker.IsPalindrome(text!);

        //Assert
        Assert.Equal(expected, result);
    }
}