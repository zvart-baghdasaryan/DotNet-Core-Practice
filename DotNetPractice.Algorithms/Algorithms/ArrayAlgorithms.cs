namespace DotNetPractice.Algorithms;
public static class ArrayAlgorithms
{
    /// <summary>
    /// Provides methods to find missing numbers in sequential arrays.
    /// </summary>
    public static int FindMissingNumber(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty.", nameof(numbers));
        }
        int n = numbers.Length + 1;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = numbers.Sum();
        int missingNumber = expectedSum - actualSum;
        if (missingNumber < 1 || missingNumber > n)
        {
            throw new ArgumentException("Invalid array: Ensure the array contains distinct integers from 1 to n with exactly one missing.");
        }
        return missingNumber;
    }

    //ArrayRotator

    //DuplicateRemover
}