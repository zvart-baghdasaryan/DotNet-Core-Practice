namespace DotNetPractice.Algorithms;
public static class MathAlgorithms
{
    public static int FibonacciGenerator(int n)
    {
        /*
        //Recursion
        if (n <= 1)
            return n;
        return FibonacciGenerator(n-1) + FibonacciGenerator(n);
        */
        
        //For loop
        if (n <= 1)
            return n;
        
        int a = 0;
        int b = 1;
        int result = 0;
        for(int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }

    public static void FizzBuzzRunner(int n)
    {
        /*
        for(int i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                continue;
            }
            if(i % 3 == 0)
            {
                Console.WriteLine("Fizz");
                continue;
            }
            if(i % 5 == 0)
            {
                Console.WriteLine("Buzz");
                continue;
            }
            else
            {
                Console.WriteLine(i);
            }

        }
        */
        for (int i = 1; i <= n; i++)
        {
            string result = "";
            if(i % 3 == 0) result +="Fizz";
            if(i % 5 == 0) result +="Buzz";
            Console.WriteLine(string.IsNullOrEmpty(result)? i: result); 
        }
    }
}
