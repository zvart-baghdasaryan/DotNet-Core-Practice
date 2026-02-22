using DotNetPractice.Algorithms.Strings;
using Xunit;

namespace DotNetPractice.Tests.Strings;

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
        var result = AnagramChecker.AreAnagrams(s1!, s2!);

        //Assert
        Assert.Equal(expected, result);
    }
}