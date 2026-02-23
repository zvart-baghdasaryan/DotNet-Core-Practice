using DotNetPractice.Algorithms;
using Xunit;

namespace DotNetPractice.Tests.Algorithms;

public class AnagramCheckerTests
{
    [Theory] //Theory gives the ability to run the same test using different data.
    [InlineData("listen", "silent", true)]
    [InlineData("hello", "world", false)]
    [InlineData("Astronomer", "Moonstarer", true)]
    [InlineData("a", "b", false)]
    [InlineData("", "", false)]
    [InlineData(null, null, false)]
    public void AreAnagrams_ValidInputs_ReturnsExpectedResult(string? s1, string? s2, bool expected)
    {
        //Act
        var result = StringsAlgorithms.AreAnagrams(s1!, s2!);

        //Assert
        Assert.Equal(expected, result);
    }
}

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
        bool result = StringsAlgorithms.IsPalindrome(text!);

        //Assert
        Assert.Equal(expected, result);
    }
}

