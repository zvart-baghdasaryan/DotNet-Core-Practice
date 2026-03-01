using System.IO.Pipelines;
using System.Runtime.InteropServices.Marshalling;

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

    //DuplicateRemover
    public static T[] DuplicateRemover<T>(T[] array)
    {
        if(array == null || array.Length == 0)
            return array;
        HashSet<T> set = new HashSet<T>(array);
        T[] result = new T[set.Count];
        set.CopyTo(result);
        return result;
    }

    public static T[] RemoveDuplicationPreserveOrder<T>(T[] array)
    {
        HashSet<T> set = new HashSet<T>();
        List<T> result = new List<T>();
        foreach (T item in array)
        {
            if(set.Add(item))
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
    
    public static void ArrayRotator<T>(T[] array, int k, bool isRight)
    {
        int n = array.Length;
        if (n==0) return;
        k = k % n;
        if (isRight)
        {
           _reverse(array, 0, n-1);
           _reverse(array, 0, k-1);
           _reverse(array, k, n-1);
        }
        else
        {
           _reverse(array, 0, k-1);
           _reverse(array, k, n-1);
           _reverse(array, 0, n-1);
        }
    }

    private static void _reverse<T>(T[] nums, int start, int end)
    {
        while(start < end)
        {
            T tmp = nums[start];
            nums[start] = nums[end];
            nums[end] = tmp;
            start ++;
            end --;
        }
    }  
}