using DotNetPractice.Algorithms.Strings;

Console.Write("Enter String: ");
string? input = Console.ReadLine();
if (input != null)
    Console.WriteLine(PalindromeChecker.IsPalindrome(input));

