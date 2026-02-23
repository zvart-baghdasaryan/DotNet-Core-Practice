using DotNetPractice.Algorithms;

Console.Write("Enter Numbers:");
int[] numbers = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int missingNumber = ArrayAlgorithms.FindMissingNumber(numbers); 
Console.WriteLine($"Missing NUmber: {missingNumber}");


