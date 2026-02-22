namespace DotNetPractice.Algorithms.Strings;

public static class AnagramChecker
{
    ///<summary>
    /// Check if two words are anagrams
    /// </summary>
    public static bool AreAnagrams(string first, string second)
    {
        //Edge cases: handle empty or null inputs.
        if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
            return false;
        //If the strings have different lengths, they cannot be anagrams.
        if (first.Length != second.Length)
            return false;
        //Algorithm: make both strings lowercase, sort the characters, and check if the results are equal.
        var firstSorted = first.ToLower().OrderBy(c => c);
        var secondSorted = second.ToLower().OrderBy(c => c);

        return firstSorted.SequenceEqual(secondSorted);
    }
}