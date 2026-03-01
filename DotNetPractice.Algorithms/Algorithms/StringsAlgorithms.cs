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

     /// <summary>
     /// Reverses the order of words in a given string sentence.
     /// </summary>
     public static string WordReverser(string text)
    {
        /*
        string[] words = text.Split(' ');
        string[] reverseWords = new string[words.Length];
       for (int i = 0; i < words.Length; i++)
        {
            reverseWords[i] = words[words.Length - 1 - i];
        }
        return string.Join(" ", reverseWords);
        */
        return string.Join(' ', text.Split(' ').Reverse());
    }


    //CharFinder
    public static string CharFinder(string text)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();
        foreach(char c in text)
        {
            if(counts.ContainsKey(c)) counts[c] ++;
            else counts[c] = 1;
        }
        foreach(char c in text)
        {
            if(counts[c] == 1)
                return c.ToString();
        }
        return "There is no no repetative char";
    }
}