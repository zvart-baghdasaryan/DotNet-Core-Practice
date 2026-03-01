using DotNetPractice.Algorithms;

/*
Console.Write("Enter Numbers:");
int[] numbers = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int missingNumber = ArrayAlgorithms.FindMissingNumber(numbers); 
Console.WriteLine($"Missing NUmber: {missingNumber}");
*/
/*
string a = "als dhf sj kfkf lsdk sjfkdf h    jdkdk";
Console.WriteLine(StringsAlgorithms.WordReverser(a));
*/

/*
//Fibonacii
Console.WriteLine(MathAlgorithms.FibonacciGenerator(0));
Console.WriteLine(MathAlgorithms.FibonacciGenerator(-1));
Console.WriteLine(MathAlgorithms.FibonacciGenerator(2));
*/

//DuplicateRemover
/*
string[] a = ["aa", "dh", "aa", "dh", "bb"];
string[] res = ArrayAlgorithms.DuplicateRemover(a);
Console.WriteLine(string.Join(", ", res));

int[] b = [1, 2, 1, 3, 4, 2, 1, 2, 3, 4, 45, 54, 65, 64, 4];
int[] b_res = ArrayAlgorithms.RemoveDuplicationPreserveOrder(b);
Array.ForEach(b_res, n => Console.WriteLine(n));
*/

//FizzBuzz
/*
int n = 15;
MathAlgorithms.FizzBuzzRunner(n);
*/

//CharFinder
/*
string a = "teddf ahsdk te skdj s; d";
Console.WriteLine(StringsAlgorithms.CharFinder(a));
*/

//ArrayRotation
/*
int[] a = [1, 2, 3, 4, 5];
ArrayAlgorithms.ArrayRotator(a, 2, true);
Console.WriteLine(String.Join(",", a));
int[] b = [1, 2, 3, 4, 5];
ArrayAlgorithms.ArrayRotator(b, 2, false);
Console.WriteLine(String.Join(",", b));
*/

//BinarySearcher
/*
int[] a = [1, 2, 3, 4, 5, 6, 7];
Console.WriteLine(SearchAlgorithms.BinarySearcher(a, 6));
*/

