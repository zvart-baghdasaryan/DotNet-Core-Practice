namespace DotNetPractice.Algorithms;

public static class StringsAlgorithms
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

    ///<summary>
    /// Check if the provided text is a palindrome, ignoring case, spaces, and punctuation.
    /// </summary>
    public static bool IsPalindrome(string text)
    {
        //Edge cases: handle empty or null inputs.
        if(string.IsNullOrEmpty(text))
            return false;
        //Algorithm: Convert the input to lowercase, filter out all non‑alphanumeric characters, reverse the cleaned string, and check whether the reversed string equals the cleaned string.
        var cleanedString = text.ToLower().Where(c => char.IsLetterOrDigit(c));
        var reversedString = cleanedString.Reverse();

        return cleanedString.SequenceEqual(reversedString);
    }

    //WordReverser
    //CharFinder
}