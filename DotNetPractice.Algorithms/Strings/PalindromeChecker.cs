namespace DotNetPractice.Algorithms.Strings;

public static class PalindromeChecker
{
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
}